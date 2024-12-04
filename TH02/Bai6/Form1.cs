using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        // Dữ liệu mẫu
        private Dictionary<string, List<string>> khoaData = new Dictionary<string, List<string>>()
        {
            {
                "THTH5A", new List<string>()
                {
                    "Nguyen Van Tuan",
                    "Nguyen Thi Lan",
                    "Nguyen Van Luong"
                }
            },
            {
                "THTH5B", new List<string>()
                {
                    "Le Nghiep",
                    "Tran Long",
                    "Ly Hai"
                }
            },
            {
                "THTH5C", new List<string>()
                {
                    "Le Trung",
                    "Ton Thi Mai",
                    "Tran Minh"
                }
            },
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoaTreeView.Nodes.Add("Khoa tin hoc");

            // Thêm các lớp và sinh viên vào cây
            foreach (KeyValuePair<string, List<string>> item in khoaData)
            {
                TreeNode node = new TreeNode(item.Key);

                foreach (string studentName in item.Value)
                {
                    node.Nodes.Add(studentName);
                }
                KhoaTreeView.Nodes[0].Nodes.Add(node);
            }
            KhoaTreeView.ExpandAll();

            KhoaTreeView.NodeMouseClick += TreeView_NodeMouseClick;
        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Kiểm tra nếu là lớp hay sinh viên được click
            if (e.Node.Nodes.Count > 0) // Nếu là lớp (có sinh viên con)
            {
                // Xóa dữ liệu cũ trong ListView
                StudentLV.Items.Clear();

                // Duyệt qua sinh viên của lớp và hiển thị vào ListView
                foreach (TreeNode studentNode in e.Node.Nodes)
                {
                    ListViewItem item = new ListViewItem(studentNode.Text); // Cột 1: tên sinh viên
                    item.SubItems.Add(e.Node.Text); // Cột 2: tên lớp
                    StudentLV.Items.Add(item);
                }
            }
            else // Nếu là sinh viên
            {
                // Xóa dữ liệu cũ trong ListView
                StudentLV.Items.Clear();

                // Thêm sinh viên và tên lớp vào ListView
                ListViewItem item = new ListViewItem(e.Node.Text); // Cột 1: tên sinh viên
                item.SubItems.Add(e.Node.Parent.Text); // Cột 2: tên lớp
                StudentLV.Items.Add(item);
            }
        }

        private void Findbtn_Click(object sender, EventArgs e)
        {
            string searchQuery = Findtxb.Text.ToLower(); // Lấy từ khóa tìm kiếm và chuyển thành chữ thường

            // Xóa dữ liệu cũ trong ListView
            StudentLV.Items.Clear();

            // Duyệt qua tất cả các lớp và sinh viên
            foreach (TreeNode classNode in KhoaTreeView.Nodes[0].Nodes)
            {
                foreach (TreeNode studentNode in classNode.Nodes)
                {
                    // Kiểm tra xem tên sinh viên có khớp với từ khóa tìm kiếm
                    if (studentNode.Text.ToLower().Contains(searchQuery))
                    {
                        ListViewItem item = new ListViewItem(studentNode.Text); // Cột 1: tên sinh viên
                        item.SubItems.Add(classNode.Text); // Cột 2: tên lớp
                        StudentLV.Items.Add(item);
                    }
                }
            }
        }
    }
}
