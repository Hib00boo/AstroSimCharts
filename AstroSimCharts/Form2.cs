using System;
using CelestialObject;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstroSimCharts
{
    public partial class ObjectDialogBox : Form
    {
        public enum State
        {
            PLANET,
            SATELLITE,
        }

        public Planet createdPlanet;

        public Satellite createdSatellite;
        public ObjectDialogBox(State state)
        {
            InitializeComponent();
            this.state = state;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private bool validateTextboxFormats()
        {
            TextBox[] textBoxes = { massTextBox, xPositionTextBox, yPositionTextBox, zPositionTextBox };
            bool isCorrectFormat = true;

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                Console.WriteLine($"Error : Empty text in {nameTextBox.Name}");
                isCorrectFormat = false;
            }

            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    Console.WriteLine($"Error : Empty text in {textBox.Name}");
                    isCorrectFormat = false;
                }
                else if (!float.TryParse(textBox.Text, out _))
                {
                    Console.WriteLine($"Error : Incorrect format in {textBox.Name}");
                    isCorrectFormat = false;
                }
            }

            return isCorrectFormat;
        }

        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            if(validateTextboxFormats())
            {
                string objectName = nameTextBox.Text;
                float objectMass = float.Parse(massTextBox.Text);
                float positionX = float.Parse(xPositionTextBox.Text);
                float positionY = float.Parse(yPositionTextBox.Text);
                float positionZ = float.Parse(zPositionTextBox.Text);

                switch (state)
                {
                    case State.PLANET:
                        createdPlanet = new Planet(objectName, objectMass, positionX, positionY, positionZ);
                        break;

                    case State.SATELLITE:
                        createdSatellite = new Satellite(objectName, objectMass, positionX, positionY, positionZ);
                        break;

                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
