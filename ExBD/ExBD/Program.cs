using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Collections;
using ConsoleTables;

namespace IntroDB
{
    class DbAccess
    {
        public string tablename;
        private NpgsqlConnection con;

        public DbAccess(string cstr, string table)
        {
            tablename = table;
            con = new NpgsqlConnection(cstr);
        }

        public void Connect()
        {
            try
            {
                con.Open();
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Erro ao realizar conexão: " + e.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                con.Close();
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Erro ao fechar conexão: " + e.Message);
            }
        }

        public void InsertData(string[] columns, List<string[]> values)
        {
            string cmd = "insert into " + tablename + " (";

            foreach (string col in columns)
            {
                cmd += col + ",";
            }
            cmd = cmd.Remove(cmd.Length - 1);
            cmd += ") values";

            foreach (string[] vet in values)
            {
                cmd += "(";
                foreach (string val in vet)
                {
                    cmd += val + ",";
                }
                cmd = cmd.Remove(cmd.Length - 1);
                cmd += "),";
            }
            cmd = cmd.Remove(cmd.Length - 1);
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(cmd, con);
               command.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Erro ao realizar inserção no banco: " + e.Message);
            }
        }

        public List<List<string>> ReadData(string[] columns, string filter_exp)
        {
            List<List<string>> result = new List<List<string>>();
            string cmd = "select ";
            foreach (string col in columns)
            {
                cmd += col + ",";
            }
            cmd = cmd.Remove(cmd.Length - 1) + " from " + tablename;
            if (filter_exp != null)
            {
                cmd += " where " + filter_exp;
            }
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(cmd, con);
                NpgsqlDataReader dr = command.ExecuteReader();
                List<string> row = new List<string>();
                while (dr.Read())
                {
                    for(int i=0;i<dr.FieldCount;i++)
                    {
                        row.Add(dr[i].ToString());
                    }
                    result.Add(new List<string>(row));
                    row.Clear();
                }                
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Erro ao realizar consulta no banco: " + e.Message);
            }
            return result;                                 
        }



    }
    class Program
    {

        static void Main(string[] args)
        {
            string connstring = "Server=10.15.20.15; Port=5433; User Id=**** ; Password=****; Database=****;";
            DbAccess mybd = new DbAccess(connstring, "dados_sensores");
            mybd.Connect();

            string[] cols_to_write = { "idbancada", "sensor", "valor", "timestamp" };

            List<string[]> vals = new List<string[]>();

            for (int i = 0; i < 10; i++)
            {
                string[] dados = { "1", "'temp_carcaça'", (25.5 + i).ToString().Replace(',', '.'), "'" + DateTime.Now.AddSeconds(i).ToString() + "'" };
                vals.Add(dados);
            }

            mybd.InsertData(cols_to_write, vals);

            string[] cols_to_read = { "medid","idbancada", "sensor", "valor", "timestamp"};
            List<List<string>> resultado_busca = mybd.ReadData(cols_to_read, "timestamp between '09/11/2019 17:16:57' and '09/11/2019 17:21:59'");

            var tabela = new ConsoleTable(cols_to_read);
            foreach(List<string> row in resultado_busca)
            {
                tabela.AddRow(row.ToArray());
            }

            tabela.Write();
            mybd.Disconnect();
            
            Console.ReadKey();
        }
    }
}
