using System;
using System.Data;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class AddStudent : Form
    {
        string adminCode;
        string adminName;
        public AddStudent(string adCode, string adName)
        {
            InitializeComponent();
            adminCode = adCode;
            adminName = adName;
        }
        bool loaded = false;

        private void AddStudent_Load(object sender, EventArgs e)
        {
            try
            {
                Functions.addActivity("فتح نافذة اضافة الطلاب", "NULL", "NULL", adminCode, adminName, "NULL");
                cbxGrades.DataSource = Functions.getGrades();
                cbxGrades.ValueMember = "Code";
                cbxGrades.DisplayMember = "Name";
                cbxGrades.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            loaded = true;
        }

        private void cbxGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                try
                {
                    cbxGroups.DataSource = Functions.getGroupsWithGrade(cbxGrades.SelectedValue.ToString());
                    cbxGroups.ValueMember = "Code";
                    cbxGroups.DisplayMember = "Name";
                    cbxGroups.SelectedItem = null;
                    txtGradeCount.Text = Functions.getGradeSTDCount(cbxGrades.SelectedValue.ToString()).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
        }

        private void cbxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int zero = 0;
                if (cbxGroups.SelectedItem != null)
                {
                    if (int.TryParse(cbxGroups.SelectedValue.ToString(), out zero))
                    {
                        DataTable groupRow = Functions.getGroupData(cbxGroups.SelectedValue.ToString());
                        //txtGroupDays.Text = groupRow.Rows[0][4].ToString();
                        string days = groupRow.Rows[0][4].ToString();
                        string replaced = groupRow.Rows[0][5].ToString().Replace(" ", "");
                        string[] time = replaced.Split('-');
                        /*txtFrom.Text = time[0];
                        txtTo.Text = time[1];*/
                        if (time[2] == "PM") rdPM.Checked = true;
                        else rdAM.Checked = true;
                        txtGroupDays.Text = days;
                        txtFrom.Text = time[0];
                        txtTo.Text = time[1];
                        txtGroupCount.Text = Functions.getGroupSTDCount(cbxGroups.SelectedValue.ToString()).ToString();
                    }
                    else
                    {
                        txtFrom.Text = "";
                        txtGroupCount.Text = "";
                        txtGroupDays.Text = "";
                        txtTo.Text = "";
                        rdAM.Checked = false;
                        rdPM.Checked = false;
                    }
                }
                else
                {
                    txtFrom.Text = "";
                    txtGroupCount.Text = "";
                    txtGroupDays.Text = "";
                    txtTo.Text = "";
                    rdAM.Checked = false;
                    rdPM.Checked = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }
        

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStdName.Text.Trim() == "") MessageBox.Show("ادخل اسم الطالب");
                else if (txtStdPhone.Text == "") MessageBox.Show("ادخل رقم هاتف الطالب");
                else if (txtPrtPhone.Text == "") MessageBox.Show("ادخل رقم هاتف ولي امر الطالب");
                else if (txtStdPhone.Text == txtPrtPhone.Text) MessageBox.Show("هاتف الطالب لا يجب ان يكون هاتف ولي الامر");
                else if (cbxGrades.SelectedItem == null) MessageBox.Show("اختر الصف");
                else if (cbxGroups.SelectedItem == null) MessageBox.Show("اختر المجموعة");
                else if (Functions.hasSpecialChar(txtStdName.Text) || Functions.hasSpecialChar(txtStdPhone.Text) || Functions.hasSpecialChar(txtPrtPhone.Text)) MessageBox.Show("لا يجب استخدام الرموز");
                else if (txtStdPhone.Text.Length != 11) MessageBox.Show("ادخل هاتف الطالب بشكل صحيح");
                else if (txtPrtPhone.Text.Length != 11) MessageBox.Show("ادخل هاتف ولي امر الطالب بشكل صحيح");
                else
                {
                    if (Functions.isDigit(txtStdPhone.Text) && Functions.isDigit(txtPrtPhone.Text))
                    {
                        if (Functions.isStdNameExist(txtStdName.Text)) MessageBox.Show("اسم الطالب مكرر من قبل");
                        else if (Functions.isStdPhoneExist(txtStdPhone.Text) && !chkRptPhone.Checked) MessageBox.Show("رقم هاتف الطالب مكرر");
                        else if (Functions.isPrtPhoneExist(txtPrtPhone.Text) && !chkRptPhone.Checked) MessageBox.Show("رقم هاتف ولي امر الطالب مكرر");
                        else
                        {
                            if (Functions.addStd(txtStdName.Text, cbxGrades.SelectedValue.ToString(), cbxGrades.Text, cbxGroups.SelectedValue.ToString(), cbxGroups.Text, txtStdPhone.Text, txtPrtPhone.Text))
                            {
                                Functions.addActivity("إضافة طالب", "الطلاب", "NULL", adminCode, adminName, "محاولة إضافة طالب: " + txtStdName.Text + "\n في صف: " + cbxGrades.Text + "\n في مجموعة: " + cbxGroups.Text);
                                MessageBox.Show("تمت اضافة الطالب بنجاح");
                            }
                            else MessageBox.Show("حدث خطأ غير معروف");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ادخل الهاتف بشكل صحيح");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            
        }
    }
}
