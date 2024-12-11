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


        public static DataTable FillDataTable (string query)
        {
            DataTable data = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            return data;
        }

        public static void InsertTable(DataTable tb, object[] gt)
        {
            // Kiểm tra nếu số lượng giá trị không khớp với số lượng cột
            if (gt.Length != tb.Columns.Count)
            {
                throw new ArgumentException("Số lượng giá trị trong mảng không khớp với số lượng cột của bảng.");
            }

            // Tạo một hàng mới
            DataRow newRow = tb.NewRow();

            // Gán giá trị cho từng cột
            for (int i = 0; i < gt.Length; i++)
            {
                newRow[i] = gt[i] ?? DBNull.Value; // Nếu giá trị null thì gán DBNull.Value
            }

            // Thêm hàng mới vào bảng
            tb.Rows.Add(newRow);
        }

        public static void UpdateTable(DataTable tb, object[] gt)
        {
            if (gt.Length < 2)
            {
                throw new ArgumentException("Mảng giá trị phải chứa ít nhất mã nhân viên và một giá trị thuộc tính mới.");
            }

            // Tìm dòng có mã nhân viên bằng gt[0]
            DataRow rowToUpdate = tb.Rows.Find(gt[0]); // Yêu cầu DataTable có primary key.

            if (rowToUpdate == null)
            {
                throw new ArgumentException($"Không tìm thấy mã nhân viên: {gt[0]}");
            }

            // Cập nhật các giá trị thuộc tính mới
            for (int i = 1; i < gt.Length; i++)
            {
                rowToUpdate[i - 1] = gt[i] ?? DBNull.Value; // Cập nhật giá trị mới, nếu null thì dùng DBNull.Value
            }
        }

        public static void DeleteTable(DataTable tb, string MaNV)
        {
            // Tìm dòng cần xóa
            DataRow rowToDelete = tb.Rows.Find(MaNV);

            if (rowToDelete != null)
            {
                tb.Rows.Remove(rowToDelete);
            }
            else
            {
                throw new ArgumentException($"Không tìm thấy mã nhân viên: {MaNV}");
            }
        }

        public static void UpdateTableToDataBase(DataTable dt, string tenbang)
        {
            // Kết nối cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Sử dụng SqlDataAdapter để cập nhật DataTable
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {tenbang}", connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                adapter.Update(dt);
            }
        }


    }
}

