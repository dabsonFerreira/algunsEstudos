using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{

    public partial class Emulador : Form
    {
        public Emulador()
        {
            InitializeComponent();
           
        }

       private void conexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfigConex fCC = new FormConfigConex(this.serialPort1);
            fCC.Show();
        }

        private void Bt_inicio_Click(object sender, EventArgs e)
        {

        }
    }
}
