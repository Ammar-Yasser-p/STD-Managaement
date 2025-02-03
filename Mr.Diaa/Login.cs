using System;
using System.Drawing;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                Icon = Icon.ExtractAssociatedIcon("Mr.Diaa.exe");
                BaseFunc.licenseCheck();
                if (Functions.isFirstTimeUsingProg())
                {
                    Register rg = new Register();
                    rg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtUN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                signIn.PerformClick();
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "13")
            {
                signIn.PerformClick();
            }
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtUN.Text.Trim() == "" || txtUN.Text.Trim() == "")
                {
                    MessageBox.Show("املئ البيانات");
                }
                else if (Functions.hasSpecialChar(txtUN.Text) || Functions.hasSpecialChar(txtPW.Text))
                {
                    MessageBox.Show("لا يجب استخدام الرموز");
                }
                else if (Functions.login(txtUN.Text, txtPW.Text))
                {
                    Functions.addActivity("محاولة ناجحة في تسجيل الدخول", "NULL", "NULL", Functions.getAdminCode(txtUN.Text), txtUN.Text, "NULL");
                    Hide();
                    string adCode = Functions.getAdminCode(txtUN.Text);
                    Main m = new Main(adCode, txtUN.Text);
                    m.Show();
                }
                else
                {
                    MessageBox.Show("البيانات غير صحيحة");
                    Functions.addActivity("محاولة فاشلة في تسجيل الدخول", "NULL", "NULL", "NULL", "NULL", "بإسم " + txtUN.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }
        }

        private bool Mouse__Down = false;
        private Point lastLocation;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse__Down = true;
            //Cursor = Cursors.Hand;
            lastLocation = e.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse__Down)
            {
                int NewX = (Location.X - lastLocation.X) + e.X;
                int NewY = (Location.Y - lastLocation.Y) + e.Y;
                Location = new Point(NewX, NewY);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse__Down = false;
            //Cursor = Cursors.Default;
        }
    }
}
