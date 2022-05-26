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
        private Vazao vz;


        public Emulador()
        {
            InitializeComponent();
            vz = new Vazao(0);
           
        }

       private void conexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfigConex fCC = new FormConfigConex(this.serialPort1);
            fCC.Show();
        }
        
        private void enable()
        {
            try
            {
                serialPort1.Open();
                this.bt_inicio.Text = "Parar";
                this.timer1.Enabled = true;
            }

            catch(System.Exception e)
            {
                MessageBox.Show("Erro ao iniciar conexão: " + e.Message);
            }
                
        }
        private void disable()
        {
            try
            {
                this.serialPort1.WriteLine("EOT");
                this.serialPort1.Close();
            }
             catch(System.Exception e)
            {
                MessageBox.Show("Falha o desligar o sensor: " + e.Message);
            }
            this.timer1.Enabled = false;
            this.bt_inicio.Text = "INICIAR";
            this.med_lb.Text = "";


        }

        private void bt_inicio_Click(object sender, EventArgs e)
        {
            if (this.bt_inicio.Text == "INICIAR")
            {
                this.enable();
            }
            else
                this.disable();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.vz.calculaVazao();
            this.vz.contador = (this.vz.contador + 1) % 10;
            this.med_lb.Text = this.vz.vazao.ToString();
            try
            {
                serialPort1.WriteLine(this.vz.vazao.ToString());
            }
            catch(System.Exception ex)
            {
                MessageBox.Show("Falha o enviar os dados: " + ex.Message);
                this.disable();
            }
        }
    }
}
