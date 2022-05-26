using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace LeituraDadosSerial
{
    class Program
    {
        public static int cont = 0;

        private static void TratamentodeDados (object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            sp.DiscardInBuffer();

            Program.cont = Program.cont + 1;

            if (Program.cont == 21)
            {
                Console.Clear();
                Program.PrintCabecalho();
                Program.cont = 0;
            }

            try
            {
                if (indata == "EOT")
                {
                    Console.WriteLine("Sensor finalizou a transmissão");
                }
                else
                    Console.WriteLine(" " + System.DateTime.Now + " " + indata + " L/s");
            }
            catch
            {
                Console.WriteLine("Dados Perdidos");
            }
        }

        public static void PrintCabecalho()
        {
            Console.WriteLine("---------- Programa de leitura dos dados de um sensor de vazão---------- \n");
            Console.WriteLine(" Dia Horário Valor");
        }
            

        static void Main(string[] args)
        {
            Program.PrintCabecalho();
            SerialPort S1 = new SerialPort("COM11", 9600, Parity.None, 8);
            S1.ReadTimeout = 500;
            S1.DataReceived += new SerialDataReceivedEventHandler(TratamentodeDados);

            try
            {
                S1.Open();
                S1.DiscardInBuffer();
            }

            catch
            {
                Console.WriteLine("Porta Serial Inválida");
            }

            if (S1.IsOpen)
            {
                while (!Console.KeyAvailable) { }
                S1.Close();
            }
        }
    }
}
