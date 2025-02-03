using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class EditStudent : Form
    {
        string code;
        string stdName;
        string phone;
        string prtPhone;
        string gdCode;
        string gbCode;
        bool loaded = false;
        string adminCode;
        string adminName;
        public EditStudent(string adCode, string adName, string stdCode)
        {
            InitializeComponent();
            code = stdCode;
            adminCode = adCode;
            adminName = adName;
        }
        private void EditStudent_Load(object sender, EventArgs e)
        {
            try
            {
                Icon = Icon.ExtractAssociatedIcon("Mr.Diaa.exe");
                Functions.addActivity("فتح نافذة تعديل الطالب", "NULL", "NULL", adminCode, adminName, "NULL");
                cbxGrades.DataSource = Functions.getGrades();
                cbxGrades.DisplayMember = "Name";
                cbxGrades.ValueMember = "Code";

                cbxGroups.DataSource = Functions.getGroups();
                cbxGroups.DisplayMember = "Name";
                cbxGroups.ValueMember = "Code";

                DataTable dt = Functions.getSpecificStd(code);

                txtStdCode.Text = code;
                //oldData
                stdName = dt.Rows[0][1].ToString();
                phone = dt.Rows[0][6].ToString();
                prtPhone = dt.Rows[0][7].ToString();
                gdCode = dt.Rows[0][2].ToString();
                gbCode = dt.Rows[0][4].ToString();


                txtStdName.Text = stdName;
                txtStdPhone.Text = phone;
                txtPrtPhone.Text = prtPhone;
                cbxGrades.SelectedValue = gdCode;
                cbxGroups.SelectedValue = gbCode;
                txtRegDate.Text = dt.Rows[0][8].ToString();

                loaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void checkUpdate()
        {
            try
            {
                if (loaded && cbxGrades.SelectedValue != null && cbxGroups.SelectedValue != null)
                {
                    if (txtStdName.Text != stdName || txtStdPhone.Text != phone || txtPrtPhone.Text != prtPhone || cbxGrades.SelectedValue.ToString() != gdCode || cbxGroups.SelectedValue.ToString() != gbCode)
                    {
                        btnSaveEdit.Enabled = true;
                    }
                    else
                    {
                        btnSaveEdit.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            
        }

        private void txtStdName_TextChanged(object sender, EventArgs e)
        {
            checkUpdate();
        }

        private void cbxGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (loaded && cbxGrades.SelectedItem != null)
                {
                    cbxGroups.DataSource = Functions.getGroupsWithGrade(cbxGrades.SelectedValue.ToString());
                    cbxGroups.ValueMember = "Code";
                    cbxGroups.DisplayMember = "Name";
                    cbxGroups.SelectedItem = null;
                }
                checkUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void cbxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkUpdate();
        }

        private void txtStdPhone_TextChanged(object sender, EventArgs e)
        {
            checkUpdate();
        }

        private void txtPrtPhone_TextChanged(object sender, EventArgs e)
        {
            checkUpdate();
        }

        private void btnUndoEdit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int zero = 0;
                if (txtStdName.Text.Trim() == "" || txtStdPhone.Text.Trim() == "") MessageBox.Show("املئ البيانات");
                else if (Functions.hasSpecialChar(txtStdName.Text) || Functions.hasSpecialChar(txtStdPhone.Text) || Functions.hasSpecialChar(txtPrtPhone.Text)) MessageBox.Show("لا يجب استخدام الرموز");
                else if (txtStdPhone.Text == txtPrtPhone.Text) MessageBox.Show("هاتف الطالب لا يجب ان يكون هاتف ولي الامر");
                else if (txtStdPhone.Text.Length != 11) MessageBox.Show("ادخل هاتف الطالب بشكل صحيح");
                else if (txtPrtPhone.Text.Length != 11) MessageBox.Show("ادخل هاتف ولي امر الطالب بشكل صحيح");
                else if (Functions.isStdNameExistExcept(txtStdName.Text, txtStdCode.Text)) MessageBox.Show("اسم الطالب مكرر من قبل");
                else if (Functions.isStdPhoneExistExcept(txtStdPhone.Text, txtStdCode.Text)) MessageBox.Show("رقم هاتف الطالب مكرر");
                else if (Functions.isPrtPhoneExistExcept(txtPrtPhone.Text, txtStdCode.Text)) MessageBox.Show("رقم هاتف ولي امر الطالب مكرر");
                else if (cbxGrades.SelectedItem == null || cbxGroups.SelectedItem == null) MessageBox.Show("اختر الصف والمجموعة بشكل صحيح");
                else
                {
                    if (int.TryParse(txtStdPhone.Text, out zero) && int.TryParse(txtPrtPhone.Text, out zero))
                    {
                        string[] newData = new string[8];
                        newData[0] = code;
                        newData[1] = txtStdName.Text.TrimEnd().TrimStart();
                        newData[2] = cbxGrades.SelectedValue.ToString();
                        newData[3] = cbxGrades.Text;
                        newData[4] = cbxGroups.SelectedValue.ToString();
                        newData[5] = cbxGroups.Text;
                        newData[6] = txtStdPhone.Text.TrimEnd().TrimStart();
                        newData[7] = txtPrtPhone.Text.TrimEnd().TrimStart();

                        if (Functions.editStudent(newData))
                        {
                            Functions.addActivity("تعديل طالب", "الطلاب", txtStdCode.Text , adminCode, adminName, "محاولة ناجحة في تعديل بيانات الطالب: " + txtStdName.Text);
                            MessageBox.Show("تم التعديل بنجاح");
                            Close();
                        }
                        else MessageBox.Show("حدث خطأ اثناء التعديل");
                    }
                    else MessageBox.Show("تحقق من الهاتف");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }
    }
}
