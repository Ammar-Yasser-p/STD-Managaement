namespace Mr.Diaa
{
    partial class Students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbStdData = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnDelStd = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditStd = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdPrtPhone = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdStdName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdStdPhone = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdCode = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGroupDays = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGroupCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGradeCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxGroups = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxGrades = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbStdData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStdData
            // 
            this.gbStdData.Controls.Add(this.dgvData);
            this.gbStdData.Controls.Add(this.btnDelStd);
            this.gbStdData.Controls.Add(this.btnEditStd);
            this.gbStdData.Controls.Add(this.groupBox1);
            this.gbStdData.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.gbStdData.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStdData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbStdData.Location = new System.Drawing.Point(12, 12);
            this.gbStdData.Name = "gbStdData";
            this.gbStdData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbStdData.ShadowDecoration.Parent = this.gbStdData;
            this.gbStdData.Size = new System.Drawing.Size(1151, 747);
            this.gbStdData.TabIndex = 6;
            this.gbStdData.Text = "تفاصيل الطلاب";
            this.gbStdData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDelStd
            // 
            this.btnDelStd.AutoRoundedCorners = true;
            this.btnDelStd.BorderRadius = 21;
            this.btnDelStd.CheckedState.Parent = this.btnDelStd;
            this.btnDelStd.CustomImages.Parent = this.btnDelStd;
            this.btnDelStd.Enabled = false;
            this.btnDelStd.FillColor = System.Drawing.Color.Brown;
            this.btnDelStd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStd.ForeColor = System.Drawing.Color.White;
            this.btnDelStd.HoverState.Parent = this.btnDelStd;
            this.btnDelStd.Image = global::Mr.Diaa.Properties.Resources.garbage;
            this.btnDelStd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelStd.Location = new System.Drawing.Point(857, 699);
            this.btnDelStd.Name = "btnDelStd";
            this.btnDelStd.ShadowDecoration.Parent = this.btnDelStd;
            this.btnDelStd.Size = new System.Drawing.Size(122, 45);
            this.btnDelStd.TabIndex = 44;
            this.btnDelStd.Text = "حذف";
            this.btnDelStd.Click += new System.EventHandler(this.btnDelStd_Click);
            // 
            // btnEditStd
            // 
            this.btnEditStd.AutoRoundedCorners = true;
            this.btnEditStd.BorderRadius = 21;
            this.btnEditStd.CheckedState.Parent = this.btnEditStd;
            this.btnEditStd.CustomImages.Parent = this.btnEditStd;
            this.btnEditStd.Enabled = false;
            this.btnEditStd.FillColor = System.Drawing.Color.PaleTurquoise;
            this.btnEditStd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStd.ForeColor = System.Drawing.Color.Black;
            this.btnEditStd.HoverState.Parent = this.btnEditStd;
            this.btnEditStd.Image = global::Mr.Diaa.Properties.Resources.pencil;
            this.btnEditStd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditStd.Location = new System.Drawing.Point(1015, 699);
            this.btnEditStd.Name = "btnEditStd";
            this.btnEditStd.ShadowDecoration.Parent = this.btnEditStd;
            this.btnEditStd.Size = new System.Drawing.Size(122, 45);
            this.btnEditStd.TabIndex = 43;
            this.btnEditStd.Text = "تعديل";
            this.btnEditStd.Click += new System.EventHandler(this.btnEditStd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdPrtPhone);
            this.groupBox1.Controls.Add(this.rdStdName);
            this.groupBox1.Controls.Add(this.rdStdPhone);
            this.groupBox1.Controls.Add(this.rdCode);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.lblPeriod);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtGroupDays);
            this.groupBox1.Controls.Add(this.txtGroupCount);
            this.groupBox1.Controls.Add(this.txtGradeCount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFrom);
            this.groupBox1.Controls.Add(this.cbxGroups);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxGrades);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1145, 176);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // rdPrtPhone
            // 
            this.rdPrtPhone.AutoSize = true;
            this.rdPrtPhone.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdPrtPhone.CheckedState.BorderThickness = 0;
            this.rdPrtPhone.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdPrtPhone.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdPrtPhone.CheckedState.InnerOffset = -4;
            this.rdPrtPhone.Location = new System.Drawing.Point(142, 128);
            this.rdPrtPhone.Name = "rdPrtPhone";
            this.rdPrtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdPrtPhone.Size = new System.Drawing.Size(150, 29);
            this.rdPrtPhone.TabIndex = 41;
            this.rdPrtPhone.Text = "هاتف ولي الامر";
            this.rdPrtPhone.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdPrtPhone.UncheckedState.BorderThickness = 2;
            this.rdPrtPhone.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdPrtPhone.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdPrtPhone.UseVisualStyleBackColor = true;
            this.rdPrtPhone.CheckedChanged += new System.EventHandler(this.rdPrtPhone_CheckedChanged);
            // 
            // rdStdName
            // 
            this.rdStdName.AutoSize = true;
            this.rdStdName.Checked = true;
            this.rdStdName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdStdName.CheckedState.BorderThickness = 0;
            this.rdStdName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdStdName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdStdName.CheckedState.InnerOffset = -4;
            this.rdStdName.Location = new System.Drawing.Point(437, 128);
            this.rdStdName.Name = "rdStdName";
            this.rdStdName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdStdName.Size = new System.Drawing.Size(122, 29);
            this.rdStdName.TabIndex = 40;
            this.rdStdName.TabStop = true;
            this.rdStdName.Text = "اسم الطالب";
            this.rdStdName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdStdName.UncheckedState.BorderThickness = 2;
            this.rdStdName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdStdName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdStdName.UseVisualStyleBackColor = true;
            this.rdStdName.CheckedChanged += new System.EventHandler(this.rdStdName_CheckedChanged);
            // 
            // rdStdPhone
            // 
            this.rdStdPhone.AutoSize = true;
            this.rdStdPhone.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdStdPhone.CheckedState.BorderThickness = 0;
            this.rdStdPhone.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdStdPhone.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdStdPhone.CheckedState.InnerOffset = -4;
            this.rdStdPhone.Location = new System.Drawing.Point(298, 128);
            this.rdStdPhone.Name = "rdStdPhone";
            this.rdStdPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdStdPhone.Size = new System.Drawing.Size(133, 29);
            this.rdStdPhone.TabIndex = 39;
            this.rdStdPhone.Text = "هاتف الطالب";
            this.rdStdPhone.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdStdPhone.UncheckedState.BorderThickness = 2;
            this.rdStdPhone.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdStdPhone.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdStdPhone.UseVisualStyleBackColor = true;
            this.rdStdPhone.CheckedChanged += new System.EventHandler(this.rdStdPhone_CheckedChanged);
            // 
            // rdCode
            // 
            this.rdCode.AutoSize = true;
            this.rdCode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdCode.CheckedState.BorderThickness = 0;
            this.rdCode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdCode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdCode.CheckedState.InnerOffset = -4;
            this.rdCode.Location = new System.Drawing.Point(565, 128);
            this.rdCode.Name = "rdCode";
            this.rdCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdCode.Size = new System.Drawing.Size(120, 29);
            this.rdCode.TabIndex = 38;
            this.rdCode.Text = "كود الطالب";
            this.rdCode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdCode.UncheckedState.BorderThickness = 2;
            this.rdCode.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdCode.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdCode.UseVisualStyleBackColor = true;
            this.rdCode.CheckedChanged += new System.EventHandler(this.rdCode_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderRadius = 17;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Red;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = global::Mr.Diaa.Properties.Resources.magnifying_glass;
            this.txtSearch.Location = new System.Drawing.Point(696, 128);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(438, 36);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(32, 45);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(0, 25);
            this.lblPeriod.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(571, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "ايام المجموعة";
            // 
            // txtGroupDays
            // 
            this.txtGroupDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupDays.DefaultText = "";
            this.txtGroupDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGroupDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGroupDays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupDays.DisabledState.Parent = this.txtGroupDays;
            this.txtGroupDays.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupDays.FocusedState.Parent = this.txtGroupDays;
            this.txtGroupDays.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupDays.ForeColor = System.Drawing.Color.Red;
            this.txtGroupDays.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupDays.HoverState.Parent = this.txtGroupDays;
            this.txtGroupDays.Location = new System.Drawing.Point(254, 31);
            this.txtGroupDays.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.txtGroupDays.Name = "txtGroupDays";
            this.txtGroupDays.PasswordChar = '\0';
            this.txtGroupDays.PlaceholderText = "";
            this.txtGroupDays.ReadOnly = true;
            this.txtGroupDays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGroupDays.SelectedText = "";
            this.txtGroupDays.ShadowDecoration.Parent = this.txtGroupDays;
            this.txtGroupDays.Size = new System.Drawing.Size(317, 36);
            this.txtGroupDays.TabIndex = 34;
            this.txtGroupDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupCount
            // 
            this.txtGroupCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupCount.DefaultText = "";
            this.txtGroupCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGroupCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGroupCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupCount.DisabledState.Parent = this.txtGroupCount;
            this.txtGroupCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupCount.FocusedState.Parent = this.txtGroupCount;
            this.txtGroupCount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupCount.ForeColor = System.Drawing.Color.Red;
            this.txtGroupCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupCount.HoverState.Parent = this.txtGroupCount;
            this.txtGroupCount.Location = new System.Drawing.Point(696, 73);
            this.txtGroupCount.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.txtGroupCount.Name = "txtGroupCount";
            this.txtGroupCount.PasswordChar = '\0';
            this.txtGroupCount.PlaceholderText = "";
            this.txtGroupCount.ReadOnly = true;
            this.txtGroupCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGroupCount.SelectedText = "";
            this.txtGroupCount.ShadowDecoration.Parent = this.txtGroupCount;
            this.txtGroupCount.Size = new System.Drawing.Size(47, 36);
            this.txtGroupCount.TabIndex = 33;
            this.txtGroupCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGradeCount
            // 
            this.txtGradeCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGradeCount.DefaultText = "";
            this.txtGradeCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGradeCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGradeCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGradeCount.DisabledState.Parent = this.txtGradeCount;
            this.txtGradeCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGradeCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGradeCount.FocusedState.Parent = this.txtGradeCount;
            this.txtGradeCount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeCount.ForeColor = System.Drawing.Color.Red;
            this.txtGradeCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGradeCount.HoverState.Parent = this.txtGradeCount;
            this.txtGradeCount.Location = new System.Drawing.Point(929, 73);
            this.txtGradeCount.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.txtGradeCount.Name = "txtGradeCount";
            this.txtGradeCount.PasswordChar = '\0';
            this.txtGradeCount.PlaceholderText = "";
            this.txtGradeCount.ReadOnly = true;
            this.txtGradeCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGradeCount.SelectedText = "";
            this.txtGradeCount.ShadowDecoration.Parent = this.txtGradeCount;
            this.txtGradeCount.Size = new System.Drawing.Size(47, 36);
            this.txtGradeCount.TabIndex = 31;
            this.txtGradeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(741, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "عدد طلاب المجموعة:-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(980, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "عدد طلاب الصف:-";
            // 
            // txtTo
            // 
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.DefaultText = "";
            this.txtTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.DisabledState.Parent = this.txtTo;
            this.txtTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTo.FocusedState.Parent = this.txtTo;
            this.txtTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.ForeColor = System.Drawing.Color.Red;
            this.txtTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTo.HoverState.Parent = this.txtTo;
            this.txtTo.Location = new System.Drawing.Point(58, 34);
            this.txtTo.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.PlaceholderText = "";
            this.txtTo.ReadOnly = true;
            this.txtTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTo.SelectedText = "";
            this.txtTo.ShadowDecoration.Parent = this.txtTo;
            this.txtTo.Size = new System.Drawing.Size(53, 36);
            this.txtTo.TabIndex = 26;
            this.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "الى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "من";
            // 
            // txtFrom
            // 
            this.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.DefaultText = "";
            this.txtFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrom.DisabledState.Parent = this.txtFrom;
            this.txtFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrom.FocusedState.Parent = this.txtFrom;
            this.txtFrom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.ForeColor = System.Drawing.Color.Red;
            this.txtFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrom.HoverState.Parent = this.txtFrom;
            this.txtFrom.Location = new System.Drawing.Point(151, 33);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PasswordChar = '\0';
            this.txtFrom.PlaceholderText = "";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFrom.SelectedText = "";
            this.txtFrom.ShadowDecoration.Parent = this.txtFrom;
            this.txtFrom.Size = new System.Drawing.Size(53, 36);
            this.txtFrom.TabIndex = 20;
            this.txtFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxGroups
            // 
            this.cbxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGroups.BackColor = System.Drawing.Color.Transparent;
            this.cbxGroups.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGroups.FocusedColor = System.Drawing.Color.Empty;
            this.cbxGroups.FocusedState.Parent = this.cbxGroups;
            this.cbxGroups.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxGroups.FormattingEnabled = true;
            this.cbxGroups.HoverState.Parent = this.cbxGroups;
            this.cbxGroups.ItemHeight = 30;
            this.cbxGroups.ItemsAppearance.Parent = this.cbxGroups;
            this.cbxGroups.Location = new System.Drawing.Point(696, 31);
            this.cbxGroups.Name = "cbxGroups";
            this.cbxGroups.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxGroups.ShadowDecoration.Parent = this.cbxGroups;
            this.cbxGroups.Size = new System.Drawing.Size(132, 36);
            this.cbxGroups.TabIndex = 18;
            this.cbxGroups.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxGroups.SelectedIndexChanged += new System.EventHandler(this.cbxGroups_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(834, 34);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "المجموعة";
            // 
            // cbxGrades
            // 
            this.cbxGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGrades.BackColor = System.Drawing.Color.Transparent;
            this.cbxGrades.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxGrades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrades.FocusedColor = System.Drawing.Color.Empty;
            this.cbxGrades.FocusedState.Parent = this.cbxGrades;
            this.cbxGrades.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxGrades.FormattingEnabled = true;
            this.cbxGrades.HoverState.Parent = this.cbxGrades;
            this.cbxGrades.ItemHeight = 30;
            this.cbxGrades.ItemsAppearance.Parent = this.cbxGrades;
            this.cbxGrades.Location = new System.Drawing.Point(940, 31);
            this.cbxGrades.Name = "cbxGrades";
            this.cbxGrades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxGrades.ShadowDecoration.Parent = this.cbxGrades;
            this.cbxGrades.Size = new System.Drawing.Size(132, 36);
            this.cbxGrades.TabIndex = 16;
            this.cbxGrades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxGrades.SelectedIndexChanged += new System.EventHandler(this.cbxGrades_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1078, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "الصف";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.ColumnHeadersHeight = 27;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvData.Location = new System.Drawing.Point(3, 228);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1145, 465);
            this.dgvData.TabIndex = 62;
            this.dgvData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvData.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvData.ThemeStyle.ReadOnly = true;
            this.dgvData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvData.ThemeStyle.RowsStyle.Height = 22;
            this.dgvData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Code";
            this.Column1.HeaderText = "الكود";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 76;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "الاسم";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 78;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GradeCode";
            this.Column3.HeaderText = "كود الصف";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 119;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GradeName";
            this.Column4.HeaderText = "الصف";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 84;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GroupCode";
            this.Column5.HeaderText = "كود الجروب";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GroupName";
            this.Column6.HeaderText = "الجروب";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 90;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Phone";
            this.Column7.HeaderText = "هاتف الطالب";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 138;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "PrtPhone";
            this.Column8.HeaderText = "هاتف ولي الامر";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 155;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "RegDate";
            this.Column9.HeaderText = "تاريخ التسجيل";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 141;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 771);
            this.ControlBox = false;
            this.Controls.Add(this.gbStdData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Students";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.gbStdData.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbStdData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtGroupDays;
        private Guna.UI2.WinForms.Guna2TextBox txtGroupCount;
        private Guna.UI2.WinForms.Guna2TextBox txtGradeCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtFrom;
        private Guna.UI2.WinForms.Guna2ComboBox cbxGroups;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbxGrades;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2RadioButton rdPrtPhone;
        private Guna.UI2.WinForms.Guna2RadioButton rdStdName;
        private Guna.UI2.WinForms.Guna2RadioButton rdStdPhone;
        private Guna.UI2.WinForms.Guna2RadioButton rdCode;
        private Guna.UI2.WinForms.Guna2Button btnEditStd;
        private Guna.UI2.WinForms.Guna2Button btnDelStd;
        private Guna.UI2.WinForms.Guna2DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}