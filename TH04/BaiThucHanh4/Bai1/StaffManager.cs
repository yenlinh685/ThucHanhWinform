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
            
            DataTable dataTable = DataHelper.FillDataTable(query);

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
                SELECT manhanvien
                FROM nhanvien
                WHERE manhanvien = '{staffCode}'
            ";

            SqlDataReader reader = DataHelper.ExcuteReader(existsQuery);
            if (reader.HasRows)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
                return;
            }

            string query = $@"
                INSERT INTO nhanvien
                VALUES('{staffCode}', N'{staffName}', N'{staffAddress}', N'{staffUserName}', N'{staffPassword}', '{staffPermission}')
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
                new SqlParameter("@manhanvien", maNV),
                new SqlParameter("@hoten", hoTen),
                new SqlParameter("@diachi", diaChi),
                new SqlParameter("@tendangnhap", tenDangNhap),
                new SqlParameter("@matkhau", matKhau),
                new SqlParameter("@quyenhan", quyenHan)
            };

            // Gọi phương thức StoreNonQuery để thực thi thủ tục
            int rowsAffected = DataHelper.StoreNonQuery("UpdateNhanVien", parameters);

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

        private void btnFind_Click(object sender, EventArgs e)
        {
            string findValue = txbFind.Text;

            // Lấy giá trị cần tìm từ TextBox
            string searchValue = txbFind.Text;

            // Duyệt qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                // Bỏ qua dòng cuối nếu AllowUserToAddRows = true
                if (row.IsNewRow) continue;

                // Kiểm tra nếu ô đầu tiên chứa giá trị cần tìm
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Contains(searchValue))
                {
                    // Đưa con trỏ đến ô đầu tiên của dòng tìm thấy
                    dgvStaff.CurrentCell = row.Cells[0];

                    // Scroll để hiển thị dòng được tìm thấy
                    dgvStaff.FirstDisplayedScrollingRowIndex = row.Index;

                    return;
                }
            }

            // Hiển thị thông báo nếu không tìm thấy
            MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo");
        }
    }
}
