using System;
using System.Data;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class Students : Form
    {
        string code = "";
        string stdName = "";
        string method = "name";
        string gbCode = "";
        string gdCode = "";
        bool loaded = false;
        string adminCode;
        string adminName;
        public Students(string adCode, string adName)
        {
            InitializeComponent();
            adminCode = adCode;
            adminName = adName;
        }
        private void Students_Load(object sender, EventArgs e)
        {
            try
            {
                Functions.addActivity("فتح نافذة تفاصيل الطلاب", "NULL", "NULL", adminCode, adminName, "NULL");
                cbxGrades.DataSource = Functions.getGrades();
                cbxGrades.ValueMember = "Code";
                cbxGrades.DisplayMember = "Name";
                cbxGrades.SelectedItem = null;

                dgvData.DataSource = Functions.getStudents();
                loaded = true;
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

        private void rdStdPhone_CheckedChanged(object sender, EventArgs e)
        {
            method = "phone";
            search();
        }

        private void rdPrtPhone_CheckedChanged(object sender, EventArgs e)
        {
            method = "prtPhone";
            search();
        }

        private void cbxGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (loaded && cbxGrades.SelectedItem != null)
                {
                    gdCode = cbxGrades.SelectedValue.ToString();
                    cbxGroups.DataSource = Functions.getGroupsWithGrade(gdCode);
                    cbxGroups.ValueMember = "Code";
                    cbxGroups.DisplayMember = "Name";
                    cbxGroups.SelectedItem = null;
                    txtGradeCount.Text = Functions.getGradeSTDCount(gdCode).ToString();
                    gbCode = "";
                    search();
                }
                else
                {
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
                        txtFrom.Text = "";
                        txtGroupCount.Text = "";
                        txtGroupDays.Text = "";
                        txtTo.Text = "";
                        lblPeriod.Text = "";
                    }
                }
                else
                {
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
                    dgvData.DataSource = Functions.searcherForStd(method, txtSearch.Text, gdCode, gbCode);
                }
                else
                {
                    MessageBox.Show("لا يجب استخدام الرموز");
                    txtSearch.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:- " + ex.Message);
            }
            
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = dgvData.CurrentRow.Index;
            code = dgvData.Rows[RowIndex].Cells[0].Value.ToString();
            stdName = dgvData.Rows[RowIndex].Cells[1].Value.ToString();
            btnEditStd.Enabled = true;
            btnDelStd.Enabled = true;
        }

        private void btnEditStd_Click(object sender, EventArgs e)
        {
            if (code != "")
            {
                EditStudent edt = new EditStudent(adminCode , adminName , code);
                edt.FormClosed += edt_FormClosed;
                edt.ShowDialog();
                
            }
            else MessageBox.Show("اختر طالب من الجدول اولا");
        }

        private void edt_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                cbxGrades.DataSource = Functions.getGrades();
                cbxGrades.ValueMember = "Code";
                cbxGrades.DisplayMember = "Name";
                cbxGrades.SelectedItem = null;

                cbxGroups.SelectedItem = null;

                gbCode = "";
                gdCode = "";
                code = "";

                btnDelStd.Enabled = false;
                btnEditStd.Enabled = false;

                dgvData.DataSource = Functions.getStudents();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:- " + ex.Message);
            }
           
        }

        private void btnDelStd_Click(object sender, EventArgs e)
        {
            RemoveStudent rStd = new RemoveStudent(adminCode, adminName, code);
            rStd.FormClosed += rStd_FormClosed;
            rStd.ShowDialog();
        }

        private void rStd_FormClosed(object sender , FormClosedEventArgs e)
        {
            try
            {
                cbxGrades.DataSource = Functions.getGrades();
                cbxGrades.ValueMember = "Code";
                cbxGrades.DisplayMember = "Name";
                cbxGrades.SelectedItem = null;

                cbxGroups.SelectedItem = null;

                gbCode = "";
                gdCode = "";
                code = "";

                btnDelStd.Enabled = false;
                btnEditStd.Enabled = false;

                dgvData.DataSource = Functions.getStudents();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:- " + ex.Message);
            }
            
        }
    }
}

