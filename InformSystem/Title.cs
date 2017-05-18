using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformSystem
{
    public partial class Title : Form
    {
        public Title()
        {
            
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Visible = false;
            Main m = new Main();
            m.ShowDialog();

            if (m.DialogResult == DialogResult.OK)
            {
                m.Dispose();
                this.Close();
            }

        }
    }
}
