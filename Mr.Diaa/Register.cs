using System;
using System.Drawing;
using Funs;
using System.Windows.Forms;

namespace Mr.Diaa
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == "" || txtPW.Text == "")
                {
                    MessageBox.Show("املئ البيانات");
                }
                else if (txtPW.Text != txtConfPW.Text)
                {
                    MessageBox.Show("تحقق من كلمة السر");
                }
                else if (Functions.hasSpecialChar(txtName.Text) || Functions.hasSpecialChar(txtPW.Text))
                {
                    MessageBox.Show("لا يجب استخدام الرموز");
                }
                else if (Functions.isAdminNameExist(txtName.Text.TrimEnd().TrimStart()))
                {
                    MessageBox.Show("اسم المسؤول موجود من قبل");
                }
                else
                {
                    if (Functions.createAcc(txtName.Text.TrimEnd().TrimStart(), txtPW.Text))
                    {
                        string adCode = Functions.getAdminCode(txtName.Text);
                        Functions.addActivity("اضافة ادمن جديد", "الادمن", adCode, "1", "", "اضافة ادمن: " + txtName.Text.TrimEnd().TrimStart() + "\nبكود: " + adCode);
                        MessageBox.Show("تم إنشاء الحساب بنجاح");
                    }
                    else MessageBox.Show("هناك خطأ في إنشاء الحساب");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }
        private bool Mouse__Down = false;
        private Point lastLocation;
        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse__Down = true;
            //Cursor = Cursors.Hand;
            lastLocation = e.Location;
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse__Down)
            {
                int NewX = (Location.X - lastLocation.X) + e.X;
                int NewY = (Location.Y - lastLocation.Y) + e.Y;
                Location = new Point(NewX, NewY);
            }
        }

        private void Register_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse__Down = false;
           // Cursor = Cursors.Default;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                signUp.PerformClick();
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                signUp.PerformClick();
            }
        }

        private void txtConfPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                signUp.PerformClick();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            Icon = Icon.ExtractAssociatedIcon("Mr.Diaa.exe");
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
