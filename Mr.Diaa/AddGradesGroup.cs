using System;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class AddGradesGroup : Form
    {
        string adminCode;
        string adminName;
        public AddGradesGroup(string adCode, string adName)
        {
            InitializeComponent();
            adminCode = adCode;
            adminName = adName;
        }
        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtGradeName.Text.Trim() == "") MessageBox.Show("ادخل اسم الصف");
                else if (Functions.hasSpecialChar(txtGradeName.Text)) MessageBox.Show("لا يجب استخدام الرموز");
                else if (Functions.isGradeNameExist(txtGradeName.Text.TrimEnd().TrimStart())) MessageBox.Show("الصف موجود من قبل");
                else
                {
                    if (Functions.addGrade(txtGradeName.Text.TrimEnd().TrimStart()))
                    {
                        string gdCode = Functions.getGradeCode(txtGradeName.Text.TrimEnd().TrimStart());
                        Functions.addActivity("إضافة صف جديد", "الصفوف", gdCode, adminCode, adminName, "محاولة ناجحة إضافة صف: " +txtGradeName.Text.TrimEnd().TrimStart());
                        cbxGrades.DataSource = Functions.getGrades();
                        cbxGrades.ValueMember = "Code";
                        cbxGrades.DisplayMember = "Name";
                        MessageBox.Show("تمت إضافة الصف بنجاح");
                    }
                    else MessageBox.Show("حدث خطأ عند إضافة الصف");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            string days = "";
            if (chkFri.Checked)
            {
                if(days != "") days += " - الجمعة";
                else days += "الجمعة";
            }
            if (chkSat.Checked)
            {
                if (days != "") days += " - السبت";
                else days += "السبت";

            }
            if (chkSun.Checked)
            {
                
                if (days != "") days += " - الأحد";
                else days += "الأحد";
            }
            if (chkMon.Checked)
            {
                
                if (days != "") days += " - الإثنين";
                else days += "الإثنين";
            }
            if (chkTues.Checked)
            {
                
                if (days != "") days += " - الثلاثاء";
                else days += "الثلاثاء";
            }
            if (chkWed.Checked)
            {
                
                if (days != "") days += " - الأربعاء";
                else days += "الأربعاء";
            }
            if (chkThurs.Checked)
            {
                
                if (days != "") days += " - الخميس";
                else days += "الخميس";
            }
            string period = "";
            if (rdAM.Checked) period = "AM";
            else if (rdPM.Checked) period = "PM";

            string time = txtFromHour.Text + ":" + txtFromMin.Text + " - " + txtToHour.Text + ":" + txtToMin.Text + " - " + period;
            if (txtGroupName.Text.Trim() == "") MessageBox.Show("ادخل اسم المجموعة");
            else if (cbxGrades.SelectedItem == null) MessageBox.Show("اختر صف");
            else if (Functions.hasSpecialChar(txtGroupName.Text)) MessageBox.Show("لا يجب استخدام الرموز");
            else if (!chkFri.Checked && !chkSat.Checked && !chkSun.Checked && !chkMon.Checked && !chkTues.Checked && !chkWed.Checked && !chkThurs.Checked) MessageBox.Show("اختر ايام المجوعة");
            else if (txtFromHour.Text.Trim() == "" || txtFromMin.Text.Trim() == "" || txtToHour.Text.Trim() == "" || txtToMin.Text.Trim() == "" || (!rdPM.Checked && !rdAM.Checked)) MessageBox.Show("ادخل الوقت بشكل صحيح");
            else if (txtFromHour.Text.Trim().Length != 2 || txtFromMin.Text.Trim().Length != 2 || txtToHour.Text.Trim().Length != 2 || txtToMin.Text.Trim().Length != 2) MessageBox.Show("يجب ادخال الوقت كالمثال التالي\n01:00\n12:05\n03:01\nان يتم ادخال الساعة والدقيقة على رقمين");
            else if (Functions.isGroupNameExist(txtGroupName.Text)) MessageBox.Show("اسم المجموعة موجود من قبل");
            else
            {
                if (!Functions.isDigit(txtFromHour.Text) || !Functions.isDigit(txtFromMin.Text) || !Functions.isDigit(txtToHour.Text) || !Functions.isDigit(txtToMin.Text)) MessageBox.Show("الوقت لا يحمل غير الارقام");
                else
                {
                    Functions.addGroup(txtGroupName.Text.TrimEnd().TrimStart(), cbxGrades.SelectedValue.ToString(), cbxGrades.Text, days, time);

                    string gbCode = Functions.getGroupCode(txtGroupName.Text.TrimEnd().TrimStart());
                    Functions.addActivity("إضافة مجموعة جديدة", "المجاميع", gbCode, adminCode, adminName, "محاولة ناجحة إضافة مجموعة: " + txtGroupName.Text.TrimEnd().TrimStart() + "\n في صف: " + cbxGrades.Text);

                    MessageBox.Show("تمت اضافة المجموعة بنجاح");

                }
            }
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            
        }

        private void AddGradesGroup_Load(object sender, EventArgs e)
        {
            try
            {
                Functions.addActivity("فتح نافذة اضافة التعليم", "NULL", "NULL", adminCode, adminName, "NULL");
                cbxGrades.DataSource = Functions.getGrades();
                cbxGrades.ValueMember = "Code";
                cbxGrades.DisplayMember = "Name";
                cbxGrades.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
           
        }
    }
}
