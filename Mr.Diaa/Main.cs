using System;
using System.Drawing;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class Main : Form
    {
        string adminCode;
        string adminName;
        bool logout = false;
        public Main(string adCode , string adName)
        {
            InitializeComponent();
            customizeDesign();
            adminCode = adCode;
            adminName = adName;
            btnMe.Text = adName;
        }

        private void customizeDesign()
        {
            pnlSubUsers.Visible = false;
            pnlSubSTD.Visible = false;
            pnlSubCourse.Visible = false;
            pnlSubPayments.Visible = false;

        }

        private void hideSubmenu()
        {
            if (pnlSubUsers.Visible == true)
                pnlSubUsers.Visible = false;
            if (pnlSubSTD.Visible == true)
                pnlSubSTD.Visible = false;
            if (pnlSubCourse.Visible == true)
                pnlSubCourse.Visible = false;
            if (pnlSubPayments.Visible == true)
                pnlSubPayments.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Icon = Icon.ExtractAssociatedIcon("Mr.Diaa.exe");
            guna2ShadowForm1.SetShadowForm(this);
            Functions.addActivity("فتح النافذة الرئيسية", "NULL", "NULL", adminCode, adminName, "NULL");
            //DB.EditData("INSERT INTO ActivityLog(ActivityType , TableName , RecordID , UserName , UserCode, AdditionalInfo)
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubUsers);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            fromViewer.Controls.Add(childForm);
            fromViewer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnUsersManagement_Click(object sender, EventArgs e)
        {
            if (adminCode == "1") openChildForm(new UsersData(adminCode, adminName));
            else
            {
                Functions.addActivity("محاولة فاشلة في فتح نافذة ادارة الادمن", "NULL", "NULL", adminCode, adminName, "الحساب ليس لديه الصلاحية");
                MessageBox.Show("ليس لديك الصلاحية للدخول");
            }
        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            openChildForm(new AddStudent(adminCode,adminName));
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            fromViewer.Size = new Size(Size.Width - 160, Size.Height);
        }

        private void btnStd_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubSTD);
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubCourse);
        }

        private void btnCourseAdd_Click(object sender, EventArgs e)
        {
            openChildForm(new AddGradesGroup(adminCode,adminName));
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (adminCode == "1")
            {
                Functions.addActivity("محاولة ناجحة في فتح نافذة اضافة الادمن", "NULL", "NULL", adminCode, adminName, "");
                Register rg = new Register();
                rg.ShowDialog();
            }
            else
            {
                Functions.addActivity("محاولة فاشلة في فتح نافذة اضافة الادمن", "NULL", "NULL", adminCode, adminName, "الحساب ليس لديه الصلاحية");
                MessageBox.Show("ليس لديك الصلاحية للدخول");
            }
            
        }

        private void btnStdDetails_Click(object sender, EventArgs e)
        {
            openChildForm(new Students(adminCode,adminName));
        }

        private void btnStdPresences_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentPresence(adminCode,adminName));
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubPayments);
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            if (adminCode == "1")
            {
                openChildForm(new ActivityLog());
            }
            else
            {
                MessageBox.Show("ليس لديك الصلاحية للدخول");
                Functions.addActivity("محاولة فاشلة في فتح نافذة الانشطة", "NULL", "NULL", adminCode, adminName, "الحساب ليس لديه الصلاحية");
            }
        }

        private void btnAddMonthPrice_Click(object sender, EventArgs e)
        {
            if (!(activeForm == null))
                activeForm.Close();
            AddRemoveMonth am = new AddRemoveMonth(adminCode,adminName);
            am.ShowDialog();
        }

        private void btnPayMonth_Click(object sender, EventArgs e)
        {
            openChildForm(new PayMonth(adminCode,adminName));
        }

        private void btnPayDetails_Click(object sender, EventArgs e)
        {
            if (adminCode == "1")
            {
                openChildForm(new PaymentDetails(adminCode, adminName));
            }
            else
            {
                MessageBox.Show("ليس لديك الصلاحية للدخول");
                Functions.addActivity("محاولة فاشلة في فتح نافذة تفاصيل الحسابات", "NULL", "NULL", adminCode, adminName, "الحساب ليس لديه الصلاحية");
            }
            
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!logout) Application.Exit();
            else
            {

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Functions.addActivity("تسجيل الخروج", "NULL", "NULL", adminCode, adminName, "قام بتسجيل الخروج من البرنامج");
            logout = true;
            Close();
            Login log = new Login();
            log.Show();
            logout = false;
        }

        private void btnMe_Click(object sender, EventArgs e)
        {
            if (panel3.Size.Height == 168) panel3.Height = 59;
            else panel3.Height = 168;
        }

        private void btnMeSet_Click(object sender, EventArgs e)
        {
            Settings set = new Settings(adminCode, adminName);
            set.ShowDialog();
        }
    }
}
