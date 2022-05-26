using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace PlotGrafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<double> dados = new List<double>();
        public List<double> tempo = new List<double>();


        private void bt_selecDados_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            LerDados(filename);
        }



        public void LerDados(string filename)
        {
            string data;
            int indicevirgula;
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            try
            {
                StreamReader sr = new StreamReader(filename);
                if(sr.ReadLine() == "%Arquivo de Dados")
                {
                    if(sr.ReadLine() == "%Tempo[s], Valor[A]")
                    {
                        while (!sr.EndOfStream)
                        {
                            data = sr.ReadLine();
                            if (data == "\n")
                                break;
                            indicevirgula = data.IndexOf(',');
                            tempo.Add(Convert.ToDouble(data.Substring(0, indicevirgula), nfi));
                            dados.Add(Convert.ToDouble(data.Substring(indicevirgula + 1, data.Length - indicevirgula - 1), nfi));
                        }
                        MessageBox.Show("Dados Lidos Com Sucesso");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if(dados.Count > 0)
            {
                chart1.Series[0].IsVisibleInLegend = false;
                chart1.ChartAreas[0].AxisX.Title = "Tempo[s]";
                chart1.ChartAreas[0].AxisY.Title = "Corrente [A]";
                for(int i = 0; i < dados.Count; i++)
                {
                    chart1.Series[0].Points.AddXY(tempo[i], dados[i]);
                }                
            }
            else
            {
                MessageBox.Show("Por favor carregue os dados!");
            }
        }

          
    }
    
}

