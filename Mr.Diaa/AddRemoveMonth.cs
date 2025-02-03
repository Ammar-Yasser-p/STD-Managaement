using System;
using System.Drawing;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class AddRemoveMonth : Form
    {
        string adminCode;
        string adminName;
        public AddRemoveMonth(string adCode , string adName)
        {
            InitializeComponent();
            adminCode = adCode;
            adminName = adName;
        }

        private void btnAddMonth_Click(object sender, EventArgs e)
        {
            string[] date = dtMonth.Value.ToShortDateString().Split('/');
            //date[0] month
            //date[2] year
            try
            {
                if (cbxGrades.SelectedItem == null) MessageBox.Show("اختر الصف");
                else if (txtMonthPrice.Text == "") MessageBox.Show("ادخل السعر اولا");
                else if (Functions.isMonthPriceExist(date[2], date[0], cbxGrades.SelectedValue.ToString())) MessageBox.Show("هذا الشهر موجود من قبل");
                else
                {
                    if (Functions.addNewMonthPrice(date[2], date[0], cbxGrades.SelectedValue.ToString(), cbxGrades.Text, txtMonthPrice.Text.TrimEnd().TrimStart()))
                    {
                        string monCode = Functions.getMonthCode(date[2], date[0], cbxGrades.SelectedValue.ToString());
                        Functions.addActivity("إضافة شهر جديد", "إعداد الشهور", monCode , adminCode, adminName, "محاولة ناجحة إضافة شهر جديد: " + date[2]+ "\\" + date[0] + "\n في صف: " + cbxGrades.Text);
                        MessageBox.Show("تم اضافة الشهر بنجاح");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void AddMonth_Load(object sender, EventArgs e)
        {
            try
            {
                Icon = Icon.ExtractAssociatedIcon("Mr.Diaa.exe");
                Functions.addActivity("فتح نافذة إعداد الشهور", "NULL", "NULL", adminCode, adminName, "NULL");
                dtMonth.Value = DateTime.Today;
                cbxGrades.DataSource = Functions.getGrades();
                cbxGrades.ValueMember = "Code";
                cbxGrades.DisplayMember = "Name";
                cbxGrades.SelectedItem = null;

                dtDelMonth.Value = DateTime.Today;
                cbxGradesDel.DataSource = Functions.getGrades();
                cbxGradesDel.ValueMember = "Code";
                cbxGradesDel.DisplayMember = "Name";
                cbxGradesDel.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void txtMonthPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Functions.hasSpecialChar(txtMonthPrice.Text))
                {
                    MessageBox.Show("غير مسموح إلا بالأرقام");
                    txtMonthPrice.Text = "";
                }
                else if (!Functions.isDigit(txtMonthPrice.Text))
                {
                    MessageBox.Show("غير مسموح إلا بالأرقام");
                    txtMonthPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMonthDel_Click(object sender, EventArgs e)
        {
            string[] date = dtDelMonth.Value.ToShortDateString().Split('/');
            if (cbxGradesDel.SelectedItem == null) MessageBox.Show("اختر الصف");
            else
            { 
                try
                {
                    string monthCode = Functions.getMonthCode(date[2], date[0], cbxGradesDel.SelectedValue.ToString());
                    if (monthCode == null) MessageBox.Show("الشهر غير موجود بالفعل\nاختر الشهر بشكل صحيح");
                    else if (Functions.ifMonthUsed(monthCode)) MessageBox.Show("هذا الشهر به مدفوعات ، ولا يمكنك حذفه");
                    else
                    {

                        if (Functions.delMonthPrice(monthCode))
                        {
                            Functions.addActivity("حذف شهر", "إعداد الشهور", monthCode, adminCode, adminName, "محاولة ناجحة حذف شهر: " + date[2] + "\\" + date[0] + "\n في صف: " + cbxGradesDel.Text);
                            MessageBox.Show("تم حذف الشهر بنجاح");
                        }
                        else MessageBox.Show("حدث خطأ غير معروف عند حذف الشهر");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
                
            }
        }
    }
}
