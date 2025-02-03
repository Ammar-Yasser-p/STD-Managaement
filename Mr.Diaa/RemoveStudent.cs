using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class RemoveStudent : Form
    {
        string code;
        bool pres = false;
        bool pay = false;
        string adminCode;
        string adminName;
        public RemoveStudent(string adCode, string adName,string stdCode)
        {
            InitializeComponent();
            adminCode = adCode;
            adminName = adName;
            code = stdCode;
        }

        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            try
            {
                Icon = Icon.ExtractAssociatedIcon("Mr.Diaa.exe");
                Functions.addActivity("فتح نافذة حذف الطالب", "NULL", "NULL", adminCode, adminName, "NULL");
                DataTable stdRow = Functions.getSpecificStd(code);
                txtStdCode.Text = code;
                txtStdName.Text = stdRow.Rows[0][1].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void chkPresencesMarks_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPresencesMarks.Checked) pres = true;
            else pres = false;
        }

        private void chkPayments_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPayments.Checked) pay = true;
            else pay = false;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (Functions.delStd(code, pay, pres))
                {
                    if (chkPayments.Checked && chkPresencesMarks.Checked) Functions.addActivity("محاولة ناجحة في حذف طالب", "الطلاب", code, adminCode, adminName, "حذف الطالب: " + txtStdName.Text + " مع الحضور والغياب والدرجات والدفع");
                    else if (chkPayments.Checked) Functions.addActivity("محاولة ناجحة في حذف طالب", "الطلاب", code, adminCode, adminName, "حذف الطالب: " + txtStdName.Text + " مع الدفع");
                    else if (chkPresencesMarks.Checked) Functions.addActivity("محاولة ناجحة في حذف طالب", "الطلاب", code, adminCode, adminName, "حذف الطالب: " + txtStdName.Text + " مع الحضور والغياب والدرجات");
                    else Functions.addActivity("محاولة ناجحة في حذف طالب", "الطلاب", code, adminCode, adminName, "حذف الطالب: " + txtStdName.Text);
                    MessageBox.Show("تم الحذف بنجاح");
                    Close();
                }
                else
                {
                    Functions.addActivity("محاولة فاشلة في حذف طالب", "الطلاب", code, adminCode, adminName, "حذف الطالب: " + txtStdName.Text);
                    MessageBox.Show("حدث خطأ اثناء الحذف");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
