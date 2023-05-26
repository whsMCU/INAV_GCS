namespace INAV_GCS
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TextBox_received_hex = new System.Windows.Forms.TextBox();
            this.TextBox_received = new System.Windows.Forms.TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.label_send = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.label_receive = new System.Windows.Forms.Label();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.label_port = new System.Windows.Forms.Label();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.textLng = new System.Windows.Forms.TextBox();
            this.textLat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadIntoMap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            //this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.TextBox_received_hex);
            this.splitContainer1.Panel1.Controls.Add(this.TextBox_received);
            this.splitContainer1.Panel1.Controls.Add(this.label_status);
            this.splitContainer1.Panel1.Controls.Add(this.label_send);
            this.splitContainer1.Panel1.Controls.Add(this.button_send);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_send);
            this.splitContainer1.Panel1.Controls.Add(this.label_receive);
            this.splitContainer1.Panel1.Controls.Add(this.button_disconnect);
            this.splitContainer1.Panel1.Controls.Add(this.button_connect);
            this.splitContainer1.Panel1.Controls.Add(this.label_port);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_port);
            this.splitContainer1.Panel1.Controls.Add(this.textLng);
            this.splitContainer1.Panel1.Controls.Add(this.textLat);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadIntoMap);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.map);
            this.splitContainer1.Size = new System.Drawing.Size(1197, 640);
            this.splitContainer1.SplitterDistance = 641;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(260, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 257);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(323, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(323, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TextBox_received_hex
            // 
            this.TextBox_received_hex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_received_hex.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_received_hex.Location = new System.Drawing.Point(387, 331);
            this.TextBox_received_hex.Multiline = true;
            this.TextBox_received_hex.Name = "TextBox_received_hex";
            this.TextBox_received_hex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_received_hex.Size = new System.Drawing.Size(237, 144);
            this.TextBox_received_hex.TabIndex = 32;
            // 
            // TextBox_received
            // 
            this.TextBox_received.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_received.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_received.Location = new System.Drawing.Point(39, 331);
            this.TextBox_received.Multiline = true;
            this.TextBox_received.Name = "TextBox_received";
            this.TextBox_received.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_received.Size = new System.Drawing.Size(326, 150);
            this.TextBox_received.TabIndex = 31;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(47, 253);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(53, 12);
            this.label_status.TabIndex = 30;
            this.label_status.Text = "연결상태";
            // 
            // label_send
            // 
            this.label_send.AutoSize = true;
            this.label_send.Location = new System.Drawing.Point(35, 530);
            this.label_send.Name = "label_send";
            this.label_send.Size = new System.Drawing.Size(29, 12);
            this.label_send.TabIndex = 29;
            this.label_send.Text = "송신";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(387, 545);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 28;
            this.button_send.Text = "보내기";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(37, 545);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(328, 21);
            this.textBox_send.TabIndex = 27;
            // 
            // label_receive
            // 
            this.label_receive.AutoSize = true;
            this.label_receive.Location = new System.Drawing.Point(37, 316);
            this.label_receive.Name = "label_receive";
            this.label_receive.Size = new System.Drawing.Size(29, 12);
            this.label_receive.TabIndex = 26;
            this.label_receive.Text = "수신";
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(144, 268);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_disconnect.TabIndex = 24;
            this.button_disconnect.Text = "연결끊기";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.Button_disconnect_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(47, 268);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 23;
            this.button_connect.Text = "연결하기";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(47, 203);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(90, 12);
            this.label_port.TabIndex = 22;
            this.label_port.Text = "COM 포트 설정";
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(47, 221);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(121, 20);
            this.comboBox_port.TabIndex = 21;
            // 
            // textLng
            // 
            this.textLng.Location = new System.Drawing.Point(39, 87);
            this.textLng.Name = "textLng";
            this.textLng.Size = new System.Drawing.Size(100, 21);
            this.textLng.TabIndex = 20;
            // 
            // textLat
            // 
            this.textLat.Location = new System.Drawing.Point(39, 39);
            this.textLat.Name = "textLat";
            this.textLat.Size = new System.Drawing.Size(100, 21);
            this.textLat.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Longitude";
            // 
            // btnLoadIntoMap
            // 
            this.btnLoadIntoMap.Location = new System.Drawing.Point(39, 124);
            this.btnLoadIntoMap.Name = "btnLoadIntoMap";
            this.btnLoadIntoMap.Size = new System.Drawing.Size(75, 23);
            this.btnLoadIntoMap.TabIndex = 17;
            this.btnLoadIntoMap.Text = "Load";
            this.btnLoadIntoMap.UseVisualStyleBackColor = true;
            this.btnLoadIntoMap.Click += new System.EventHandler(this.btnLoadIntoMap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Latitude";
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(3, 3);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(505, 563);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 640);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_send;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Label label_receive;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.TextBox textLng;
        private System.Windows.Forms.TextBox textLat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadIntoMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_received;
        private System.Windows.Forms.TextBox TextBox_received_hex;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

