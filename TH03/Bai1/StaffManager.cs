using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class StaffManager : Form
    {
        public StaffManager()
        {
            InitializeComponent();
            LoadStaffList();
            Binding();
        }

        private void Binding()
        {
            AddBinding(txbStaffCode, "Text", "Mã nhân viên");
            AddBinding(txbStaffName, "Text", "Tên nhân viên");
            AddBinding(txbStaffAddress, "Text", "Địa chỉ");
            AddBinding(txbStaffUserName, "Text", "Tên đăng nhập");
            AddBinding(txbStaffPassword, "Text", "Mật khẩu");
            AddBinding(cbbStaffPermission, "Text", "Quyền hạn");
        }

        private void AddBinding(Control control, string propertyName, string dataMember)
        {
            Binding binding = new Binding(propertyName, dgvStaff.DataSource, dataMember);

            // Chỉ cho phép đọc dữ liệu
            binding.Format += (s, e) =>
            {
                // Không làm gì, chỉ truyền dữ liệu từ DataSource sang control
            };

            control.DataBindings.Clear(); // Xóa binding cũ nếu có
            control.DataBindings.Add(binding);
        }

        private void LoadStaffList()
        {
            string query = @"
                SELECT
                  nhanvien.manhanvien AS 'Mã nhân viên',
                  nhanvien.hoten AS 'Tên nhân viên',
                  nhanvien.diachi AS 'Địa chỉ',
                  nhanvien.tendangnhap AS 'Tên đăng nhập',
                  nhanvien.matkhau AS 'Mật khẩu',
                  nhanvien.quyenhan AS 'Quyền hạn'
                FROM
                  nhanvien 
                ";

            SqlDataReader reader = DataHelper.ExcuteReader(query);

            // convert to datatable 
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            dgvStaff.Controls.Clear();

            dgvStaff.DataSource = dataTable;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string staffCode = txbStaffCode.Text;
            string staffName = txbStaffName.Text;
            string staffAddress = txbStaffAddress.Text;
            string staffUserName = txbStaffUserName.Text;
            string staffPassword = txbStaffPassword.Text;
            string staffPermission = cbbStaffPermission.Text;

            // check if exists staff code

            string existsQuery = $@"
                SELECT tendangnhap
                FROM nhanvien
                WHERE tendangnhap = '{staffUserName}'
            ";

            SqlDataReader reader = DataHelper.ExcuteReader(existsQuery);
            if (reader.HasRows)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
                return;
            }

            string query = $@"
                INSERT INTO nhanvien
                VALUES('{staffCode}', '{staffName}', '{staffAddress}', '{staffUserName}', '{staffPassword}', '{staffPermission}')
            ";

            int rowAffected = DataHelper.ExcuteNonQuery(query);

            if (rowAffected != 0)
            {
                MessageBox.Show("Cập nhật thành công");
                LoadStaffList();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string staffCode = txbStaffCode.Text;

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string query = $"DELETE FROM nhanvien WHERE manhanvien = {staffCode}";

                int rowAffected = DataHelper.ExcuteNonQuery(query);

                if (rowAffected != 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    LoadStaffList();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các điều khiển trên giao diện
            int maNV = int.Parse(txbStaffCode.Text);
            string hoTen = txbStaffName.Text;
            string diaChi = txbStaffAddress.Text;
            string tenDangNhap = txbStaffUserName.Text;
            string matKhau = txbStaffPassword.Text;
            string quyenHan = cbbStaffPermission.Text;

            // Khởi tạo các tham số cho thủ tục
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@MatKhau", matKhau),
                new SqlParameter("@QuyenHan", quyenHan)
            };

            // Gọi phương thức StoreNonQuery để thực thi thủ tục
            int rowsAffected = DataHelper.StoreNonQuery("SuaNhanVien", parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadStaffList();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
