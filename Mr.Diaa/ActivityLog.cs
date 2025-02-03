using System;
using System.Windows.Forms;
using Funs;

namespace Mr.Diaa
{
    public partial class ActivityLog : Form
    {
        public ActivityLog()
        {
            InitializeComponent();
        }

        private void ActivityLog_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = Functions.getActivity();
        }
    }
}
