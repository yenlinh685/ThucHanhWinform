using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai1
{
    class DataHelper
    {

        static string connectionString = "";

        public DataHelper(string SV, string DN)
        {
            connectionString = @"server=" + SV + "; database=" + DN + "; Integrated security=true";
        }
        public DataHelper(string SV, string DN, String UN, string PW)
        {
            connectionString = @"server=" + SV + "; database=" + DN + "; UId=" + UN + "; Pwd=" + PW;
        }

        public void MoKetNoi()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                con.Close();
            }
        }

        public static void DocTep(String tentep, out string Quyen, out string SN, out String DN, out String UN, out String PW)
        {
            StreamReader dr = new StreamReader(tentep);
            if (!dr.EndOfStream)
                Quyen = dr.ReadLine();
            else
                Quyen = "";
            if (!dr.EndOfStream)
                SN = dr.ReadLine();
            else
                SN = "";
            if (!dr.EndOfStream)
                DN = dr.ReadLine();
            else
                DN = "";
            if (!dr.EndOfStream)
                UN = dr.ReadLine();
            else
                UN = "";
            if (!dr.EndOfStream)
                PW = dr.ReadLine();
            else
                PW = "";
            dr.Close();
        }

        public static void GhiTep(String tentep, string Quyen, string SN, String DN, String UN, String PW)
        {
            StreamWriter dw = new StreamWriter(tentep);
            dw.WriteLine(Quyen);
            dw.WriteLine(SN);
            dw.WriteLine(DN);
            dw.WriteLine(UN);
            dw.WriteLine(PW);
            dw.Close();
        }

        public static bool KiemTraKetNoi()
        {
            string quyen;
            string SN;
            string DN;
            string PW;
            string UC;

            DataHelper.DocTep("config.txt", out quyen, out SN, out DN, out UC, out PW);
            if (quyen == "WD")
            {
                DataHelper dt = new DataHelper(SN, DN);
                try
                {
                    dt.MoKetNoi();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                DataHelper dt = new DataHelper(SN, DN, UC, PW);
                try
                {
                    dt.MoKetNoi();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public static SqlDataReader ExcuteReader(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sql, connection);

            // Chỉ trả về reader, không đóng connection
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public static int ExcuteNonQuery(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                return command.ExecuteNonQuery();
            }
        }

        public static int StoreNonQuery(string storeProcedureName, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storeProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    rowsAffected = command.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }


        public static SqlDataReader StoreReader(string storeProcedureName, SqlParameter[] parameters = null)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(storeProcedureName, connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            // Sử dụng CommandBehavior.CloseConnection để đóng connection khi reader bị dispose
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

    }
}

