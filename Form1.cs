using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Đăngkymonhoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxNienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2020; i <= 2025; i++)
            {
                cbxNienkhoa.Items.Add(i.ToString());
            }
            cbxNienkhoa.SelectedIndex = 5;
            /*cbxLop.Items.Add("Ứng dụng phần mềm 1");
            cbxLop.Items.Add("Ứng dụng phần mềm 2");
            cbxLop.Items.Add("Ứng dụng phần mềm 3");
            cbxLop.Items.Add("Thiết kế đồ họa");
            cbxLop.Items.Add("Quản lý mạng");*/
            string[] lopArray = { "Ứng dụng phần mềm 1", "Ứng dụng phần mềm 2", "Ứng dụng phần mềm 3", "Thiết kế đồ họa", "Quản lý mạng" };
            foreach(var items in lopArray)
            {
                cbxLop.Items.Add(items);
            }
            rad1.Checked = true;
            clbMonhoc.Items.Add("LT WIN",CheckState.Checked);
            clbMonhoc.Items.Add("LT Internet", CheckState.Checked);
            clbMonhoc.Items.Add("Mang máy tính", CheckState.Checked);
            clbMonhoc.Items.Add("UML", CheckState.Checked);
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string thongtin;
            thongtin = "Mã số sinh viên:" + txtMSSV.Text;
            thongtin = "\nhọ và tên:" + txtHovaten.Text;
            thongtin = "\nniên khóa:" + cbxNienkhoa.SelectedIndex;
            thongtin = "\nlớp:" + cbxLop.SelectedIndex;

            string hocky = "";
            if (rad1.Checked)
            {
                hocky = rad1.Text;
            }
            else if (rad2.Checked)
            {
                hocky = rad2.Text;
            }
            else if (rad3.Checked)
            {
                hocky = rad3.Text;
            }
            else if(rad4.Checked)
            {
                hocky = rad4.Text;
            }

            thongtin += "\nĐã đăng ký học kỳ" + hocky+"các môn học sau:";
            int stt = 1;
            for (var item )
        }
    }
}
