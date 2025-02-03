using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Funs;
using System.Globalization;

namespace Mr.Diaa
{
    public partial class StudentPresence : Form
    {
        string code = "";
        string method = "name";
        string gbCode = "";
        string gdCode = "";
        bool loaded = false;
        string adminCode;
        string adminName;
        public StudentPresence(string adCode, string adName)
        {
            InitializeComponent();
            adminCode = adCode;
            adminName = adName;
        }
        private void StudentPresence_Load(object sender, EventArgs e)
        {
            try
            {
                Functions.addActivity("فتح نافذة حضور الطلاب", "NULL", "NULL", adminCode, adminName, "NULL");
                dtFrom.Value = DateTime.Today;
                dtTo.Value = DateTime.Today;
                cbxGrades.DataSource = Functions.getGrades();
                cbxGrades.ValueMember = "Code";
                cbxGrades.DisplayMember = "Name";
                search();
                loaded = true;
                if (loaded && cbxGrades.SelectedItem != null)
                {
                    gdCode = cbxGrades.SelectedValue.ToString();
                    cbxGroups.DataSource = Functions.getGroupsWithGrade(gdCode);
                    cbxGroups.ValueMember = "Code";
                    cbxGroups.DisplayMember = "Name";
                    txtGradeCount.Text = Functions.getGradeSTDCount(gdCode).ToString();
                }
                else
                {
                    gdCode = "";
                    txtGradeCount.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void cbxGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (loaded && cbxGrades.SelectedItem != null)
                {
                    gdCode = cbxGrades.SelectedValue.ToString();
                    int rowsCount = dgvData.Rows.Count;
                    for (int i = 0; i < rowsCount; i++)
                    {
                        dgvData.Rows.RemoveAt(0);
                    }
                    cbxGroups.DataSource = Functions.getGroupsWithGrade(gdCode);
                    cbxGroups.ValueMember = "Code";
                    cbxGroups.DisplayMember = "Name";
                    txtGradeCount.Text = Functions.getGradeSTDCount(gdCode).ToString();
                    if (cbxGroups.Items.Count == 0)
                    {
                        code = "";
                        gbCode = "";
                        txtGradeCount.Text = "0";
                        gbCode = "";
                        txtFrom.Text = "";
                        txtGroupCount.Text = "";
                        txtGroupDays.Text = "";
                        txtTo.Text = "";
                        lblPeriod.Text = "";
                    }
                }
                else
                {
                    gdCode = "";
                    txtGradeCount.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void cbxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxGroups.SelectedItem != null)
                {
                    if (Functions.isDigit(cbxGroups.SelectedValue.ToString()))
                    {
                        gbCode = cbxGroups.SelectedValue.ToString();
                        DataTable groupRow = Functions.getGroupData(cbxGroups.SelectedValue.ToString());
                        string days = groupRow.Rows[0][4].ToString();
                        string replaced = groupRow.Rows[0][5].ToString().Replace(" ", "");
                        string[] time = replaced.Split('-');
                        if (time[2] == "PM") lblPeriod.Text = "م";
                        else lblPeriod.Text = "ص";
                        txtGroupDays.Text = days;
                        txtFrom.Text = time[0];
                        txtTo.Text = time[1];
                        txtGroupCount.Text = Functions.getGroupSTDCount(gbCode).ToString();
                        search();
                    }
                    else
                    {
                        gbCode = "";
                        txtFrom.Text = "";
                        txtGroupCount.Text = "";
                        txtGroupDays.Text = "";
                        txtTo.Text = "";
                        lblPeriod.Text = "";
                    }
                }
                else
                {
                    gbCode = "";
                    txtFrom.Text = "";
                    txtGroupCount.Text = "";
                    txtGroupDays.Text = "";
                    txtTo.Text = "";
                    lblPeriod.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }
        private void search()
        {
            try
            {
                if (!Functions.hasSpecialChar(txtSearch.Text))
                {
                    if (gbCode != "" && method != "")
                    {
                        dgvData.DataSource = Functions.getOpenedDayWithSearch(dtFrom.Value.ToString("MM/dd/yyyy"), dtTo.Value.ToString("MM/dd/yyyy"), gbCode, method, txtSearch.Text);
                    }
                }
                else
                {
                    MessageBox.Show("لا يجب استخدام الرموز");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void rdCode_CheckedChanged(object sender, EventArgs e)
        {
            method = "code";
            search();
        }

        private void rdStdName_CheckedChanged(object sender, EventArgs e)
        {
            method = "name";
            search();
        }

        

        private void btnDayOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdCode != "" && gbCode != "")
                {
                    CultureInfo culture = new CultureInfo("ar-SA");
                    DateTime currentDate = DateTime.Today;
                    string date = currentDate.ToShortDateString();
                    string dayName = currentDate.ToString("dddd", culture);
                    if (Functions.isDayRight(dayName, gbCode))
                    {
                        /*if (!Functions.isDayOpened(date, gbCode, "اساسية"))
                        {*/
                            DataTable stds = Functions.getGroupStd(gbCode);
                            string[] details = new string[7];
                            details[0] = gdCode;
                            details[1] = cbxGrades.Text;
                            details[2] = gbCode;
                            details[3] = cbxGroups.Text;
                            details[4] = date;
                            details[5] = dayName;
                            details[6] = "اساسية";
                            Functions.openPresDay(stds, details);
                            MessageBox.Show("تم فتح اليوم بنجاح");
                            search();
                        /*}
                        else
                        {

                            MessageBox.Show("تم فتح اليوم بالفعل من قبل");
                        }*/
                    }
                    else
                    {
                        MessageBox.Show("اليوم ليس يوم المجموعة");
                    }
                }
                else
                {
                    MessageBox.Show("اختر الصف والمجموعة");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:- " + ex.Message);
            }
            
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            try
            {
                if (code != "")
                {
                    int RowIndex = dgvData.CurrentRow.Index;
                    Functions.attendStd(dgvData.Rows[RowIndex]);
                    string id = Functions.getPresID(dgvData.Rows[RowIndex]);
                    string stdName = dgvData.Rows[RowIndex].Cells[1].Value.ToString();
                    Functions.addActivity("محاولة ناجحة في تحضير طالب", "الغياب والحضور والدرجات", code, adminCode, adminName, "تحضير الطالب: " + stdName);
                    search();
                    dgvData.Rows[RowIndex].Selected = true;
                    dgvData.CurrentCell = dgvData.Rows[RowIndex].Cells[1];
                }
                else MessageBox.Show("اختر طالب من الجدول اولا");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:- " + ex.Message);
            }
           
        }

        private void btnAbsent_Click(object sender, EventArgs e)
        {
            try
            {
                if (code != "")
                {
                    int RowIndex = dgvData.CurrentRow.Index;
                    Functions.absentStd(dgvData.Rows[RowIndex]);
                    string id = Functions.getPresID(dgvData.Rows[RowIndex]);
                    string stdName = dgvData.Rows[RowIndex].Cells[1].Value.ToString();
                    Functions.addActivity("محاولة ناجحة في تغييب طالب", "الغياب والحضور والدرجات", id, adminCode, adminName, "تغييب الطالب: " + stdName);
                    search();
                    dgvData.Rows[RowIndex].Selected = true;
                    dgvData.CurrentCell = dgvData.Rows[RowIndex].Cells[1];
                }
                else MessageBox.Show("اختر طالب من الجدول اولا");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            search();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            try
            {
                if (code != "" && txtStdMark.Text != "")
                {
                    int RowIndex = dgvData.CurrentRow.Index;
                    if (dgvData.Rows[RowIndex].Cells[9].Value.ToString() == "False")
                    {
                        MessageBox.Show("قم بتحضير الطالب اولا");
                    }
                    else
                    {
                        Functions.addStdMark(dgvData.Rows[RowIndex], txtStdMark.Text.TrimEnd().TrimStart());
                        string id = Functions.getPresID(dgvData.Rows[RowIndex]);
                        string stdName = dgvData.Rows[RowIndex].Cells[1].Value.ToString();
                        Functions.addActivity("محاولة ناجحة في اعطاء الدرجة لطالب", "الغياب والحضور والدرجات", id, adminCode, adminName, "تقييم الطالب: " + stdName);
                        txtStdMark.Text = "";
                        search();
                        dgvData.CurrentCell = dgvData.Rows[RowIndex].Cells[1];
                    }
                }
                else MessageBox.Show("اختر طالب من الجدول اولا او ادخل الدرجة بشكل صحيح");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            
        }

        private void txtStdMark_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Functions.hasSpecialChar(txtStdMark.Text))
                {
                    MessageBox.Show("لا يجب استخدام الرموز");
                    txtStdMark.Text = "";
                }
                else if (txtStdMark.Text == "")
                {

                }
                else if (!Functions.isDigit(txtStdMark.Text))
                {
                    MessageBox.Show("غير مسموح الا بالأرقام");
                    txtStdMark.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void txtStdMark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                btnAddMark.PerformClick();
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = dgvData.CurrentRow.Index;
            code = dgvData.Rows[RowIndex].Cells[0].Value.ToString();
            btnAttend.Enabled = true;
            btnAbsent.Enabled = true;
            btnAddMark.Enabled = true;
        }

        private void dgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                DataGridViewRow row = dgvData.Rows[i];
                if (row.Cells[9].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.Maroon;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}
