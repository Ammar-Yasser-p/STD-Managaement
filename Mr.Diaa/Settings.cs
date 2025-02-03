using System;
using System.Drawing;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class Settings : Form
    {
        string adminCode;
        string adminName;
        public Settings(string adCode , string adName)
        {
            InitializeComponent();
            adminCode = adCode;
            adminName = adName;
            txtUserCode.Text = adminCode;
            txtUserName.Text = adminName;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtConfPass.Text == "") MessageBox.Show("املئ البيانات");
                else if (Functions.hasSpecialChar(txtOldPass.Text) || Functions.hasSpecialChar(txtNewPass.Text) || Functions.hasSpecialChar(txtConfPass.Text)) MessageBox.Show("لا يجب استخدام الرموز");
                else if (txtOldPass.Text != Functions.getAdminPass(adminCode))
                {
                    Functions.addActivity("محاولة فاشلة في تغيير كلمة السر", "NULL", "NULL", adminCode, adminName, "ادخل كلمة السر الحالية خطأ");
                    MessageBox.Show("كلمة السر غير صحيحة");
                    
                }
                else if (txtNewPass.Text != txtConfPass.Text) MessageBox.Show("كلمة السر الجديدة غير متطابقة");
                else
                {
                    Functions.changeAdminPass(adminCode, txtNewPass.Text);
                    Functions.addActivity("محاولة ناجحة في تغيير كلمة السر", "NULL", "NULL", adminCode, adminName, "قام بتغيير كلمة سره");
                    MessageBox.Show("تم تغيير كلمة السر بنجاح");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void btnUndoEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtConfPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                btnSaveEdit.PerformClick();
            }
        }

        private void txtNewPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                btnSaveEdit.PerformClick();
            }
        }

        private void txtOldPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                btnSaveEdit.PerformClick();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Icon = Icon.ExtractAssociatedIcon("Mr.Diaa.exe");
            Functions.addActivity("فتح نافذة الاعدادات", "NULL", "NULL", adminCode, adminName, "NULL");
            //DB.EditData("INSERT INTO ActivityLog(ActivityType , TableName , RecordID , UserName , UserCode , AdditionalInfo)
        }
    }
}
