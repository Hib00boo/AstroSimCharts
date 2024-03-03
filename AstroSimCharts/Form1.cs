using System;
using System.Windows.Forms;
using CelestialObject;

namespace AstroSimCharts
{
    public partial class SystemVisualisation : Form
    {
        ObjectSystem objectSystem { get; set; }

        public SystemVisualisation()
        {
            InitializeComponent();
            objectSystem = new ObjectSystem();
        }

        private void systemPointChart_Click(object sender, EventArgs e)
        {
            /*fillChart();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjectDialogBox planetDialogBox = new ObjectDialogBox(ObjectDialogBox.State.PLANET);
            planetDialogBox.ShowDialog();
            if(planetDialogBox.DialogResult == DialogResult.OK)
            {
                Planet createdPlanet = planetDialogBox.createdPlanet;
                objectSystem.addPlanet(createdPlanet);
            }
        }

        private void AddSatelliteButton_Click(object sender, EventArgs e)
        {
            ObjectDialogBox satelliteDialogBox = new ObjectDialogBox(ObjectDialogBox.State.SATELLITE);
            satelliteDialogBox.ShowDialog();
            if(satelliteDialogBox.DialogResult == DialogResult.OK)
            {
            Satellite createdSatellite = satelliteDialogBox.createdSatellite;
                objectSystem.addSatellite(createdSatellite);
            }
        }

        /*        private void fillChart()
                {
                    systemPointChart.Series["Objects"].Points.AddXY()
                }*/
    }
}
