using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class PayMonth : Form
    {
        string adminCode;
        string adminName;
        public PayMonth(string adCode, string adName)
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
        private void PayMonth_Load(object sender, EventArgs e)
        {
            try
            {
                Functions.addActivity("فتح نافذة دفع الشهر", "NULL", "NULL", adminCode, adminName, "NULL");
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
                txtDiscount.ReadOnly = false;
                btnPay.Enabled = true;
                btnCancelPay.Enabled = false;
                txtDiscount.Text = "0";
                txtPaid.Text = mPrice;
            }
            else
            {
                txtDiscount.ReadOnly = true;
                txtDiscount.Text = discount;
                txtPaid.Text = paid;
                btnPay.Enabled = false;
                btnCancelPay.Enabled = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (Functions.isStdAlreadyPaid(payCode))
                {
                    MessageBox.Show("هذا الطالب دفع بالفعل الشهر");
                }
                else
                {
                    int RowIndex = dgvData.CurrentRow.Index;
                    string stdName = dgvData.Rows[RowIndex].Cells[3].Value.ToString();
                    string yearAct = dgvData.Rows[RowIndex].Cells[4].Value.ToString();
                    string monAct= dgvData.Rows[RowIndex].Cells[5].Value.ToString();
                    string message = "هل تريد دفع شهر للطالب: " + stdName;
                    string title = "تأكيد الدفع";
                    MessageBoxButtons butns = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, butns);
                    if (result == DialogResult.Yes)
                    {
                        Functions.payMonth(payCode, txtDiscount.Text, txtPaid.Text);
                        Functions.addActivity("دفع شهر", "المدفوعات", payCode, adminCode, adminName, "محاولة ناجحة دفع شهر: " + yearAct + "\\" + monAct + "\n للطالب: "+ stdName +"\n في صف: " + cbxGrades.Text);
                        MessageBox.Show("تم الدفع بنجاح");
                        search();
                        dgvData.Rows[RowIndex].Selected = true;
                        dgvData.CurrentCell = dgvData.Rows[RowIndex].Cells[0];
                        btnPay.Enabled = false;
                        btnCancelPay.Enabled = true;
                        txtDiscount.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if(!Functions.isDigit(txtDiscount.Text) && txtDiscount.Text !="")
            {
                MessageBox.Show("غير مسموح بالارقام");
                txtDiscount.Text = "0";
            }
            else if(txtDiscount.Text == "")
            {
                txtPaid.Text = "";

            }
            else
            {
                int price = int.Parse(txtPrice.Text);
                int discount = int.Parse(txtDiscount.Text);
                txtPaid.Text = price - discount + "";
            }
        }

        private void btnCancelPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (Functions.isStdAlreadyPaid(payCode))
                {
                    int RowIndex = dgvData.CurrentRow.Index;
                    string stdName = dgvData.Rows[RowIndex].Cells[3].Value.ToString();
                    string yearAct = dgvData.Rows[RowIndex].Cells[4].Value.ToString();
                    string monAct = dgvData.Rows[RowIndex].Cells[5].Value.ToString();
                    string message = "هل تريد إلغاء دفع شهر الطالب: " + stdName;
                    string title = "إلغاء الدفع";
                    MessageBoxButtons butns = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, butns);
                    if (result == DialogResult.Yes)
                    {
                        Functions.cancelPayMonth(payCode);
                        Functions.addActivity("إلغاء دفع شهر", "المدفوعات", payCode, adminCode, adminName, "محاولة ناجحة إلغاء دفع شهر: " + yearAct + "\\" + monAct + "\n للطالب: " + stdName + "\n في صف: " + cbxGrades.Text);
                        MessageBox.Show("تم إالغاء الدفع بنجاح");
                        search();
                        dgvData.Rows[RowIndex].Selected = true;
                        dgvData.CurrentCell = dgvData.Rows[RowIndex].Cells[0];
                        btnPay.Enabled = true;
                        btnCancelPay.Enabled = false;
                        txtDiscount.ReadOnly = false;
                    }
                }
                else
                {
                    MessageBox.Show("هذا الشهر غير مدفوع بالفعل");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private void dgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                DataGridViewRow row = dgvData.Rows[i];
                if (row.Cells[11].Value.ToString() == "False")
                {
                    row.DefaultCellStyle.BackColor = Color.Maroon;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}
