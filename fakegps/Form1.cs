using GMap.NET;
using NETGeographicLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakegps
{
    public partial class Form1 : Form
    {
        private Geodesic geod = new Geodesic(Constants.WGS84.MajorRadius, Constants.WGS84.Flattening);

        public Form1()
        {
            InitializeComponent();

            gMapControl1.Position = new GMap.NET.PointLatLng(37.5155639198688, 126.736648475197);
            gMapControl1.Zoom = 16;
            gMapControl1.Manager.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.IgnoreMarkerOnMouseWheel = true;
        }

        private void gMapControl1_OnPositionChanged(GMap.NET.PointLatLng point)
        {
            lbLat.Text = Convert.ToString(point.Lat);
            lbLng.Text = Convert.ToString(point.Lng);
        }

        private void gMapControl1_OnMapZoomChanged()
        {
            lbLng.Text = Convert.ToString(gMapControl1.Position.Lat);
            lbLat.Text = Convert.ToString(gMapControl1.Position.Lng);
            lbZoom.Text = Convert.ToString(gMapControl1.Zoom);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            PointLatLng pos = gMapControl1.Position;
            double tmpLat = 0;
            double tmpLng = 0;

            switch(keyData)
            {
                case Keys.Down:
                    geod.Direct(pos.Lat, pos.Lng, 180, 5, out tmpLat, out tmpLng);
                    gMapControl1.Position = new PointLatLng(tmpLat, tmpLng);
                    break;

                case Keys.Up:
                    geod.Direct(pos.Lat, pos.Lng, 0, 5, out tmpLat, out tmpLng);
                    gMapControl1.Position = new PointLatLng(tmpLat, tmpLng);
                    break;

                case Keys.Left:
                    geod.Direct(pos.Lat, pos.Lng, 270, 5, out tmpLat, out tmpLng);
                    gMapControl1.Position = new PointLatLng(tmpLat, tmpLng);
                    break;

                case Keys.Right:
                    geod.Direct(pos.Lat, pos.Lng, 90, 5, out tmpLat, out tmpLng);
                    gMapControl1.Position = new PointLatLng(tmpLat, tmpLng);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
