using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieuCheHoaHoc
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();
        }

        private void btnDieuChe_Click(object sender, EventArgs e) {
            if (DataTriThuc.triThucPath != null) {
                DieuCheForm dieuChe = new DieuCheForm();
                this.Hide();
                dieuChe.Show();
            }
            else {
                MessageBox.Show("Cần chọn tệp chứa tri thức trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e) {
            if (DataTriThuc.triThucPath != null) {
                ThemForm them = new ThemForm();
                this.Hide();
                them.Show();
            }
            else {
                MessageBox.Show("Cần chọn tệp chứa tri thức trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e) {
            TroGiupForm help = new TroGiupForm();
            help.Show();
        }

        private void lblCauHinh_Click(object sender, EventArgs e) {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Title = "Open";
            openDlg.InitialDirectory = @"C:\Documents";
            openDlg.Filter = "File văn bản (*.txt) | *.txt";

            if (openDlg.ShowDialog() == DialogResult.OK) {
                DataTriThuc.triThucPath = openDlg.FileName;
            }
        }
    }
}