using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect to a PostgreSQL database
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; " + "Password = 123; Database = DataLoggerDB;");
            conn.Open();
            // Define a query
            string analayer_60_query = "SELECT tn,tp,toc,new FROM analayer_60";
            NpgsqlCommand command = new NpgsqlCommand(analayer_60_query, conn);

            // Execute the query and obtain a result set
            NpgsqlDataReader dr = command.ExecuteReader();

            // Output rows
            DataTable analayer_60 = new DataTable();
            analayer_60.Load(dr);

            var tableEnumerable_analayer = analayer_60.AsEnumerable();
            var tableArray_analayer = tableEnumerable_analayer.ToArray();

            string data_60minute_query = "SELECT id,created FROM data_60minute_values";
            command = new NpgsqlCommand(data_60minute_query, conn);


            dr = command.ExecuteReader();
            DataTable data_60 = new DataTable();
            data_60.Load(dr);

            var tableEnumerable_data = data_60.AsEnumerable();
            var tableArray_data = tableEnumerable_data.ToArray();

            foreach (var time in tableArray_analayer)
            {
                foreach (var date in tableArray_data)
                {
                    string stringdatetime = date[1].ToString();
                    //stringdatetime = stringdatetime.Substring
                    DateTime _datetime = DateTime.Parse(stringdatetime);
                    //DateTime _datetime = DateTime.ParseExact(stringdatetime, "M-dd-yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
                    string datetime = _datetime.ToString("dd/MM/yyyy HH", System.Globalization.CultureInfo.InvariantCulture);
                    if (datetime.Equals(time[3]))
                    {
                        NpgsqlCommand cmd = conn.CreateCommand();
                        int id = Convert.ToInt32(date[0]);
                        double tn = Convert.ToDouble(time[0]);
                        double tp = Convert.ToDouble(time[1]);
                        double toc = Convert.ToDouble(time[2]);
                        if (update(tn, tp, toc, id, cmd, dr, conn)) {
                            Console.WriteLine(datetime);
                        }

                    }
                }
            }
            Console.ReadLine();
            conn.Close();
        }
        public static Boolean update(double tn, double tp, double toc, int id, NpgsqlCommand command, NpgsqlDataReader dr, NpgsqlConnection conn)
        {
            try
            {
                string sql_command = "UPDATE data_60minute_values set  " +

                                    " TN =:TN, " +
                                    " TP =:TP,  " +
                                    " TOC =:TOC " +

                                    " where id = :id";
                command.CommandText = sql_command;

                command.Parameters.Add(":TN", NpgsqlTypes.NpgsqlDbType.Double).Value = tn;
                command.Parameters.Add(":TP", NpgsqlTypes.NpgsqlDbType.Double).Value = tp;
                command.Parameters.Add(":TOC", NpgsqlTypes.NpgsqlDbType.Double).Value = toc;

                command.Parameters.Add(new NpgsqlParameter(":id", id));

                command.ExecuteNonQuery();

                return true;

            }
            catch(Exception ex)
            {

                return false;
            }

        }
    }
}
