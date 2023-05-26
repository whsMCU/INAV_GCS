using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GMap.NET.Entity.OpenStreetMapRouteEntity;

namespace INAV_GCS
{
    public partial class Form1 : Form
    {
        UTF8 UTF8 = new UTF8();
        GMapOverlay markers = new GMapOverlay("markers");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadIntoMap_Click(object sender, EventArgs e)
        {
            double lat = Convert.ToDouble(textLat.Text);
            double lng = Convert.ToDouble(textLng.Text);
            map.Position = new GMap.NET.PointLatLng(lat, lng);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 15;

            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);

            //GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }

        private void Form1_Load(object sender, EventArgs e)  //폼이 로드되면
        {
            comboBox_port.DataSource = SerialPort.GetPortNames(); //연결 가능한 시리얼포트 이름을 콤보박스에 가져오기 
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new GMap.NET.PointLatLng(35.1965882, 126.8295163);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 15;
            PointLatLng point = new PointLatLng(35.1965882, 126.8295163);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);

            //GMapOverlay markers = new GMapOverlay("markers");

            marker.ToolTipText = $"Latitude : {map.Position.Lat}, \nLongitude : {map.Position.Lng}";

            var toolTip = new GMapToolTip(marker)
            {
                Fill = new SolidBrush(Color.Blue),
                Foreground = new SolidBrush(Color.White),
                Offset = new Point(50, -50),
                Stroke = new Pen(new SolidBrush(Color.Red))

            };
            marker.ToolTip = toolTip;

            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }

        private void Button_connect_Click(object sender, EventArgs e)  //통신 연결하기 버튼
        {
            if (!serialPort1.IsOpen)  //시리얼포트가 열려 있지 않으면
            {
                serialPort1.PortName = comboBox_port.Text;  //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                serialPort1.BaudRate = 9600;  //보레이트 변경이 필요하면 숫자 변경하기
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //이것이 꼭 필요하다

                serialPort1.Open();  //시리얼포트 열기

                label_status.Text = "포트가 열렸습니다.";
                comboBox_port.Enabled = false;  //COM포트설정 콤보박스 비활성화
            }
            else  //시리얼포트가 열려 있으면
            {
                label_status.Text = "포트가 이미 열려 있습니다.";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)  //수신 이벤트가 발생하면 이 부분이 실행된다.
        {
            this.Invoke(new EventHandler(MySerialReceived));  //메인 쓰레드와 수신 쓰레드의 충돌 방지를 위해 Invoke 사용. MySerialReceived로 이동하여 추가 작업 실행.
        }

        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            //int ReceiveData = serialPort1.ReadByte();  //시리얼 버터에 수신된 데이타를 ReceiveData 읽어오기
            //richTextBox_received.Text = richTextBox_received.Text + string.Format("{0:X2}", ReceiveData);  //int 형식을 string형식으로 변환하여 출력
            try
            {
                int iRecSize = serialPort1.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize != 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    //          Console.Write("rx:" + iRecSize.ToString());

                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        serialPort1.Read(buff, 0, iRecSize);

                        //if (this.tsbRxViewText.Checked || this.tsbRxViewBoth.Checked)
                        //{
                            string strTemp = this.UTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);
                            TextBox_received.AppendText(strTemp);
                        //if (objSaveFile != null)
                        //    objSaveFile.Write(strTemp);

                        //}

                        //if (this.tsbRxViewHex.Checked || this.tsbRxViewBoth.Checked)
                        //{
                        //    //     Console.WriteLine("HEX");
                        TextBox_received_hex.AppendText(BitConverter.ToString(buff).Replace("-", " ") + " ");
                        //}
                    }
                    catch { }
                }
            }
            catch (System.Exception)
            {
            }
        }

        private void Button_send_Click(object sender, EventArgs e)  //보내기 버튼을 클릭하면
        {
            serialPort1.Write(textBox_send.Text);  //텍스트박스의 텍스트를 시리얼통신으로 송신
        }

        private void Button_disconnect_Click(object sender, EventArgs e)  //통신 연결끊기 버튼
        {
            if (serialPort1.IsOpen)  //시리얼포트가 열려 있으면
            {
                serialPort1.Close();  //시리얼포트 닫기

                label_status.Text = "포트가 닫혔습니다.";
                comboBox_port.Enabled = true;  //COM포트설정 콤보박스 활성화
            }
            else  //시리얼포트가 닫혀 있으면
            {
                label_status.Text = "포트가 이미 닫혀 있습니다.";
            }
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                var mappoint = map.FromLocalToLatLng(e.X, e.Y);
                double lat = mappoint.Lat;
                double lng = mappoint.Lng;

                textLat.Text = lat.ToString();
                textLng.Text = lng.ToString();

                //map.Position = new GMap.NET.PointLatLng(lat, lng);

                PointLatLng point = new PointLatLng(lat, lng);

                //MessageBox.Show(point.ToString());

                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);


                marker.ToolTipText = $"Latitude : {lat}, \nLongitude : {lng}";

                var toolTip = new GMapToolTip(marker)
                {
                    Fill = new SolidBrush(Color.Blue),
                    Foreground = new SolidBrush(Color.White),
                    Offset = new Point(50, -50),
                    Stroke = new Pen(new SolidBrush(Color.Red))

                };
                marker.ToolTip = toolTip;

                markers.Markers.Add(marker);
                map.Overlays.Add(markers);
            }
        }
    }
}
