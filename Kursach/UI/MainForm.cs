using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach.Modules;

namespace Kur
{
    public partial class MainForm : Form
    {
        Simulation s;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s = new Simulation();
            s.Label = label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.Stop();
        }
    }
}
