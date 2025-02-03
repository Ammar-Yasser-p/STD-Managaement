using System;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class UsersData : Form
    {
        string adminCode;
        string adminName;
        public UsersData(string adCode, string adName)
        {
            InitializeComponent();
            adminCode = adCode;
            adminName = adName;
        }

        private void UsersData_Load(object sender, EventArgs e)
        {
            try
            {
                dgvData.DataSource = Functions.getUsers();
                Functions.addActivity("فتح نافذة ادارة الادمن", "NULL", "NULL", adminCode, adminName, "NULL");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        int SelectedID = 0;
        string pass = "";
        string adName = "";
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = dgvData.CurrentRow.Index;
            SelectedID = int.Parse(dgvData.Rows[RowIndex].Cells[0].Value.ToString());
            adName = dgvData.Rows[RowIndex].Cells[1].Value.ToString();
            pass = dgvData.Rows[RowIndex].Cells[2].Value.ToString();
            txtUserName.Text = adName;
            txtPass.Text = pass;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (pass != txtPass.Text && SelectedID != 0)
                {
                    string message = "هل تريد تغيير كلمة السر";
                    string title = "تغيير كلمة السر";
                    MessageBoxButtons butns = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, butns);
                    if (result == DialogResult.Yes)
                    {
                        if (txtPass.Text == "") MessageBox.Show("ادخل كلمة السر بشكل صحيح");
                        else if (Functions.hasSpecialChar(txtPass.Text)) MessageBox.Show("لا يجب استخدام الرموز");
                        else
                        {
                            if (Functions.changeAdminPass(SelectedID.ToString(), txtPass.Text))
                            {
                                Functions.addActivity("محاولة ناجحة في تغيير كلمة السر", "NULL", "NULL", adminCode, adminName, "قام بتغيير كلمة سر الادمن: " + adName + "\n بكود: " + SelectedID);
                                SelectedID = 0;
                                pass = "";
                                adName = "";
                                MessageBox.Show("تم التعديل بنجاح");
                                dgvData.DataSource = Functions.getUsers();
                                txtUserName.Text = "";
                                txtPass.Text = "";
                            }
                        }
                    }
                }
                else if (SelectedID == 0) MessageBox.Show("اختر المستخدم اولا من الجدول");
                else if (pass == txtPass.Text) MessageBox.Show("ادخل كلمة سر جديدة");
                else MessageBox.Show("حدث خطأ غير معروف");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            
        }

        private void btnUploadData_Click(object sender, EventArgs e)
        {
            string del = Functions.delData();
            if (del == "Success")
            {
                string add = Functions.sendData();
                MessageBox.Show(add);
            }
        }
    }
}
