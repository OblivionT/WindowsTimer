using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTimer
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }
        int Hours = 0, Minutes = 0, Seconds = 0, HourNow, MinuteNow, ReelHours, ReelMinutes;



        bool IsSpecific = true;


        private void btnSpecific_Click(object sender, EventArgs e)
        {
            IsSpecific = true;
            cmbMinutes.Visible = true;
            cmbHours.Visible = true;
            txtMinutes.Visible = false;
            txtHours.Visible = false;
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            IsSpecific = false;
            cmbMinutes.Visible = false;
            cmbHours.Visible = false;
            txtMinutes.Visible = true;
            txtHours.Visible = true;
        }



        private void btnSet_Click(object sender, EventArgs e)
        {
            if (IsSpecific)
            {

                try
                {
                    HourNow = Convert.ToInt32(DateTime.Now.Hour);
                    MinuteNow = Convert.ToInt32(DateTime.Now.Minute);
                    Hours = Convert.ToInt32(cmbHours.Text);
                    Minutes = Convert.ToInt32(cmbMinutes.Text);
                }
                catch(FormatException)
                {
                    MessageBox.Show("Select numbers");
                    return;
                }
               

                ReelHours = Hours - HourNow;

                if (ReelHours < 0)
                    ReelHours += 24;

                ReelMinutes = Minutes - MinuteNow;

                if (ReelHours == 0 && ReelMinutes < 0)
                    ReelHours += 24;


                Seconds += (ReelHours * 60 * 60) + (ReelMinutes * 60);
                System.Diagnostics.Process.Start("shutdown", $"/s /t {Seconds}");
                Seconds = 0;
            }
            else
            {
                try
                {
                    Hours = Convert.ToInt32(txtHours.Text);
                    Minutes = Convert.ToInt32(txtMinutes.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter a number");
                    return;

                }

                Seconds += (Hours * 60 * 60) + (Minutes * 60);
                System.Diagnostics.Process.Start("shutdown", $"/s /t {Seconds}");

            
                Seconds = 0;
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/a");
        }

    }

   


}
