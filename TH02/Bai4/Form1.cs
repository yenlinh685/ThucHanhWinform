using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai4
{
    public partial class Form1 : Form
    {
        private ListViewItem selectedItem;

        public Form1()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateItemBtn_Click(object sender, EventArgs e)
        {
            List<Control> fieldList = new List<Control>()
            {
                StudentCodetxb,
                StudentFullNametxb,
                StudentAddresstxb,
                Studentdtp,
                StudentClasscbb
            };

            bool isValid = true;
            foreach (Control field in fieldList)
            {
                if (field.Text == "")
                {
                    isValid = false;
                    MessageBox.Show("Vui lòng nhập đầy đủ các trường", "Cảnh báo");
                    break;
                }
            }

            if (isValid)
            {
                ListViewItem item = new ListViewItem(StudentCodetxb.Text);

                item.SubItems.Add(StudentFullNametxb.Text);
                item.SubItems.Add(StudentAddresstxb.Text);
                item.SubItems.Add(Studentdtp.Text);
                item.SubItems.Add(StudentClasscbb.Text);

                item.ImageIndex = 0;

                StudentClasscbb.Items.Add(StudentClasscbb.Text);

                StudentListlv.Items.Add(item);
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {

            List<Control> fieldList = new List<Control>()
            {
                StudentCodetxb,
                StudentFullNametxb,
                StudentAddresstxb,
                Studentdtp,
                StudentClasscbb
            };

            foreach (Control field in fieldList)
            {
                field.Text = "";
            }
        }

        private void StudentListlv_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra có hàng nào được chọn không
            if (StudentListlv.SelectedItems.Count > 0)
            {
                // Lấy hàng được chọn
                ListViewItem selectedItem = StudentListlv.SelectedItems[0];

                this.selectedItem = selectedItem;

                // Binding dữ liệu từ hàng vào các field
                StudentCodetxb.Text = selectedItem.SubItems[0].Text; // Mã sinh viên
                StudentFullNametxb.Text = selectedItem.SubItems[1].Text; // Họ và tên
                StudentAddresstxb.Text = selectedItem.SubItems[2].Text; // Địa chỉ

                // Xử lý DateTime
                if (DateTime.TryParse(selectedItem.SubItems[3].Text, out DateTime selectedDate))
                {
                    Studentdtp.Value = selectedDate; // Ngày tháng
                }

                // Binding Class
                StudentClasscbb.Text = selectedItem.SubItems[4].Text; // Lớp
            }
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (selectedItem != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    // Xóa hàng được chọn khỏi ListView
                    StudentListlv.Items.Remove(selectedItem);
                }
            }
        }
    }
}
