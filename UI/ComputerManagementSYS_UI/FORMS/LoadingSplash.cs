using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerManagementSYS_UI
{
    public partial class LoadingSplash : Form
    {
        private Timer _timer;
        private int _progressval = 0;
        public LoadingSplash()
        {
            InitializeComponent();
            InitializeLoading();
        }
        private void InitializeLoading()
        {
            _timer = new Timer();
            _timer.Interval = 70; //Set interval in milliseconds
            _timer.Tick += new EventHandler(OnTimerTick);
            _timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (_progressval < 100)
            {
                _progressval += 2; // Adjust as needed to control speed
                prgbLoading.Value = _progressval;
                //lblPercent.Text = $"{_progressval}%";
            }
            else
            {
                _timer.Stop();
                this.Hide(); // Hide the loading screen
            }
        }
    }
}
