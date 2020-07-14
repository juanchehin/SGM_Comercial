using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class formSplashScreen : Form
    {
        public formSplashScreen()
        {
            InitializeComponent();
        }

        private void formSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            System.Windows.Forms.Application.Exit();
            // this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(2);
            if (this.progressBar1.Value == 100)
            {

                Program.OpenDetailFormOnClose = true;

                this.Close();

            }
            
        }

    }
}
