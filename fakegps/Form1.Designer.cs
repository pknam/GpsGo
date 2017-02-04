namespace fakegps
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLat = new System.Windows.Forms.Label();
            this.lbLng = new System.Windows.Forms.Label();
            this.lbZoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(14, 89);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 20;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(843, 592);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 6D;
            this.gMapControl1.OnPositionChanged += new GMap.NET.PositionChanged(this.gMapControl1_OnPositionChanged);
            this.gMapControl1.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMapControl1_OnMapZoomChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lng";
            // 
            // lbLat
            // 
            this.lbLat.AutoSize = true;
            this.lbLat.Location = new System.Drawing.Point(48, 19);
            this.lbLat.Name = "lbLat";
            this.lbLat.Size = new System.Drawing.Size(0, 15);
            this.lbLat.TabIndex = 5;
            // 
            // lbLng
            // 
            this.lbLng.AutoSize = true;
            this.lbLng.Location = new System.Drawing.Point(48, 52);
            this.lbLng.Name = "lbLng";
            this.lbLng.Size = new System.Drawing.Size(0, 15);
            this.lbLng.TabIndex = 6;
            // 
            // lbZoom
            // 
            this.lbZoom.AutoSize = true;
            this.lbZoom.Location = new System.Drawing.Point(203, 40);
            this.lbZoom.Name = "lbZoom";
            this.lbZoom.Size = new System.Drawing.Size(45, 15);
            this.lbZoom.TabIndex = 7;
            this.lbZoom.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 696);
            this.Controls.Add(this.lbZoom);
            this.Controls.Add(this.lbLng);
            this.Controls.Add(this.lbLat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gMapControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLat;
        private System.Windows.Forms.Label lbLng;
        private System.Windows.Forms.Label lbZoom;
    }
}

