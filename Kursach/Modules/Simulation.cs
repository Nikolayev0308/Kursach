using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Kursach.Modules
{
    public class Simulation
    {
        private bool _isActive = false;
        public Label Label;
        public void Start()
        {
            _isActive = true;
            Task.Run(() => Generate());
            Label.Invoke(new Action(() => Label.Text = "Badgers"));
        }
        public void Stop()
        {
            _isActive = false;
        }
        private void Generate()
        {
            while (_isActive)
            {
                Label.Text = "Badgers";
                Thread.Sleep(2000);
            }
        }

    }
}
