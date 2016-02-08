using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamOne
{
    public partial class Form1 : Form
    {
        double vehicleSpeedInput, vehicleDistanceTraveled;
        //Time variables to avoid hardcoding into each method
        double fiveHoursTime = 5, eightHoursTime = 8, twelveHoursTime = 12;

        public Form1()
        {
            InitializeComponent();
        }

        //Distance = Speed * Time

        private void btnFiveHours_Click(object sender, EventArgs e)
        {
            vehicleSpeedInput = double.Parse(tbVehicleSpeed.Text);
            vehicleDistanceTraveled = vehicleSpeedInput * fiveHoursTime;
            lblDisplayOutput.Text = "Traveling at " + vehicleSpeedInput.ToString() 
                + " mph, the vehicle would travel " + vehicleDistanceTraveled.ToString() + " miles."; 
        }

        private void btnEightHours_Click(object sender, EventArgs e)
        {
            vehicleSpeedInput = double.Parse(tbVehicleSpeed.Text);
            vehicleDistanceTraveled = vehicleSpeedInput * eightHoursTime;
            lblDisplayOutput.Text = "Traveling at " + vehicleSpeedInput.ToString()
                + " mph, the vehicle would travel " + vehicleDistanceTraveled.ToString() + " miles."; 
        }

        private void btnTwelveHours_Click(object sender, EventArgs e)
        {
            vehicleSpeedInput = double.Parse(tbVehicleSpeed.Text);
            vehicleDistanceTraveled = vehicleSpeedInput * twelveHoursTime;
            lblDisplayOutput.Text = "Traveling at " + vehicleSpeedInput.ToString()
                + " mph, the vehicle would travel " + vehicleDistanceTraveled.ToString() + " miles."; 
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            tbVehicleSpeed.Clear();
            lblDisplayOutput.Text = string.Empty;
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            Application.Exit();
        }
    }
}
