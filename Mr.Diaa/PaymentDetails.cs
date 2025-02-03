using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class PaymentDetails : Form
    {
        string adminCode;
        string adminName;
        public PaymentDetails(string adCode , string adName)
        {
            InitializeComponent();
            adminCode = adCode;
            adminName = adName;
        }
        string stdCode = "";
        string payCode = "";
        string method = "name";
        string gbCode = "";
        string gdCode = "";
        bool loaded = false;
        private void PaymentDetails_Load(object sender, EventArgs e)
        {
            try
            {
                Functions.addActivity("فتح نافذة تفاصيل الحسابات", "NULL", "NULL", adminCode, adminName, "NULL");
                cbxGrades.DataSource = Functions.getGrades();
                cbxGrades.ValueMember = "Code";
                cbxGrades.DisplayMember = "Name";
                cbxGrades.SelectedItem = null;
                dgvData.DataSource = Functions.getPayments();
                loaded = true;
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
                    cbxGroups.DataSource = Functions.getGroupsWithGrade(gdCode);
                    cbxGroups.ValueMember = "Code";
                    cbxGroups.DisplayMember = "Name";
                    cbxGroups.SelectedItem = null;
                    gbCode = "";
                    search();
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
                    dgvData.DataSource = Functions.getPyamentsWithSearch(gdCode, gbCode, method, txtSearch.Text, txtYear.Text, txtMonth.Text);
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
                        search();
                    }
                    else
                    {
                        txtFrom.Text = "";
                        txtGroupDays.Text = "";
                        txtTo.Text = "";
                        lblPeriod.Text = "";
                    }
                }
                else
                {
                    txtFrom.Text = "";
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

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = dgvData.CurrentRow.Index;
            payCode = dgvData.Rows[RowIndex].Cells[0].Value.ToString();
            stdCode = dgvData.Rows[RowIndex].Cells[2].Value.ToString();

            string mPrice = dgvData.Rows[RowIndex].Cells[10].Value.ToString();
            string state = dgvData.Rows[RowIndex].Cells[11].Value.ToString();
            string discount = dgvData.Rows[RowIndex].Cells[12].Value.ToString();
            string paid = dgvData.Rows[RowIndex].Cells[13].Value.ToString();
            txtPrice.Text = mPrice;
            if (state == "False")
            {
                txtDiscount.Text = "0";
                txtPaid.Text = mPrice;
            }
            else
            {
                txtDiscount.Text = discount;
                txtPaid.Text = paid;
            }
        }

        private void dgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int allMPrice = 0;
            int allDis = 0;
            int allPaid = 0;
            int expected = 0;
            int delayed = 0;

            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                DataGridViewRow row = dgvData.Rows[i];
                if (row.Cells[11].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.Maroon;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                int mPrice = int.Parse(row.Cells[10].Value.ToString());
                int dis = int.Parse(row.Cells[12].Value.ToString());
                int paid = int.Parse(row.Cells[13].Value.ToString());
                allMPrice += mPrice;
                allDis += dis;
                allPaid += paid;
            }
            expected = allMPrice - allDis;
            delayed = expected - allPaid;
            txtExpected.Text = expected + "";
            txtIncome.Text = allPaid + "";
            txtDelayed.Text= delayed + "";
        }
    }
}
