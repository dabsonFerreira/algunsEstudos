﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class FormConfigConex : Form
    {
        public void Inicializacao()
        { 
            string[] baudrate = {"9600","115200"};
            Parity[] paridades = { Parity.Even, Parity.Odd, Parity.None };
            int[] databits = { 7, 8 };
            StopBits[] sb = {StopBits.One,StopBits.OnePointFive,StopBits.Two};

            cb_COM.Items.AddRange(SerialPort.GetPortNames());
            cb_baudrate.Items.AddRange(baudrate);

            foreach (Parity P in paridades)
            {
                cb_paridade.Items.Add(P.ToString());
            }

            foreach (StopBits S in sb)
            {
                cb_stopbit.Items.Add(S.ToString());
            }

            foreach (int db in databits)
            {
                cb_databits.Items.Add(db.ToString());
            }
          
        }

        public void UpdateSerial(SerialPort SP)
        {
            SP.BaudRate = Convert.ToInt32(cb_baudrate.SelectedItem);
            SP.PortName = cb_COM.SelectedItem.ToString();
            SP.Parity = (Parity)Enum.Parse(typeof(Parity), cb_paridade.SelectedItem.ToString());
            SP.DataBits = Convert.ToInt32((cb_databits.SelectedItem.ToString()));
            SP.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cb_stopbit.SelectedItem.ToString());
        }

        public SerialPort sp1;
  
        public FormConfigConex(SerialPort S1)
        {
            InitializeComponent();
            this.Inicializacao();
            this.sp1 = S1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateSerial(this.sp1);
            MessageBox.Show("Porta serial configurada com sucesso");
        }
        
    }
}
