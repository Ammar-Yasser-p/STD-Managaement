namespace Mr.Diaa
{
    partial class AddStudent
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
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAddStd = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGroupDays = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGroupCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGradeCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdPM = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdAM = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxGroups = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxGrades = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStdPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkRptPhone = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2GroupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.chkRptPhone);
            this.guna2GroupBox2.Controls.Add(this.btnAddStd);
            this.guna2GroupBox2.Controls.Add(this.groupBox1);
            this.guna2GroupBox2.Controls.Add(this.txtPrtPhone);
            this.guna2GroupBox2.Controls.Add(this.txtStdPhone);
            this.guna2GroupBox2.Controls.Add(this.txtStdName);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(1151, 747);
            this.guna2GroupBox2.TabIndex = 6;
            this.guna2GroupBox2.Text = "البيانات";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddStd
            // 
            this.btnAddStd.AutoRoundedCorners = true;
            this.btnAddStd.BorderRadius = 21;
            this.btnAddStd.CheckedState.Parent = this.btnAddStd;
            this.btnAddStd.CustomImages.Parent = this.btnAddStd;
            this.btnAddStd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddStd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStd.ForeColor = System.Drawing.Color.Black;
            this.btnAddStd.HoverState.Parent = this.btnAddStd;
            this.btnAddStd.Image = global::Mr.Diaa.Properties.Resources.plus;
            this.btnAddStd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddStd.Location = new System.Drawing.Point(497, 434);
            this.btnAddStd.Name = "btnAddStd";
            this.btnAddStd.ShadowDecoration.Parent = this.btnAddStd;
            this.btnAddStd.Size = new System.Drawing.Size(180, 45);
            this.btnAddStd.TabIndex = 17;
            this.btnAddStd.Text = "إضافة";
            this.btnAddStd.Click += new System.EventHandler(this.btnAddStd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtGroupDays);
            this.groupBox1.Controls.Add(this.txtGroupCount);
            this.groupBox1.Controls.Add(this.txtGradeCount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rdPM);
            this.groupBox1.Controls.Add(this.rdAM);
            this.groupBox1.Controls.Add(this.txtTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFrom);
            this.groupBox1.Controls.Add(this.cbxGroups);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxGrades);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1123, 185);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المجموعة والصف";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(901, 130);
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
            this.txtGroupDays.Location = new System.Drawing.Point(563, 128);
            this.txtGroupDays.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.txtGroupDays.Name = "txtGroupDays";
            this.txtGroupDays.PasswordChar = '\0';
            this.txtGroupDays.PlaceholderText = "";
            this.txtGroupDays.ReadOnly = true;
            this.txtGroupDays.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGroupDays.SelectedText = "";
            this.txtGroupDays.ShadowDecoration.Parent = this.txtGroupDays;
            this.txtGroupDays.Size = new System.Drawing.Size(331, 36);
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
            this.txtGroupCount.Location = new System.Drawing.Point(16, 31);
            this.txtGroupCount.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.txtGroupCount.Name = "txtGroupCount";
            this.txtGroupCount.PasswordChar = '\0';
            this.txtGroupCount.PlaceholderText = "";
            this.txtGroupCount.ReadOnly = true;
            this.txtGroupCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGroupCount.SelectedText = "";
            this.txtGroupCount.ShadowDecoration.Parent = this.txtGroupCount;
            this.txtGroupCount.Size = new System.Drawing.Size(89, 36);
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
            this.txtGradeCount.Location = new System.Drawing.Point(305, 31);
            this.txtGradeCount.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.txtGradeCount.Name = "txtGradeCount";
            this.txtGradeCount.PasswordChar = '\0';
            this.txtGradeCount.PlaceholderText = "";
            this.txtGradeCount.ReadOnly = true;
            this.txtGradeCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGradeCount.SelectedText = "";
            this.txtGradeCount.ShadowDecoration.Parent = this.txtGradeCount;
            this.txtGradeCount.Size = new System.Drawing.Size(89, 36);
            this.txtGradeCount.TabIndex = 31;
            this.txtGradeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "عدد طلاب المجموعة:-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "عدد طلاب الصف:-";
            // 
            // rdPM
            // 
            this.rdPM.AutoSize = true;
            this.rdPM.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdPM.CheckedState.BorderThickness = 0;
            this.rdPM.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdPM.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdPM.CheckedState.InnerOffset = -4;
            this.rdPM.Enabled = false;
            this.rdPM.Location = new System.Drawing.Point(221, 78);
            this.rdPM.Name = "rdPM";
            this.rdPM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdPM.Size = new System.Drawing.Size(41, 29);
            this.rdPM.TabIndex = 29;
            this.rdPM.TabStop = true;
            this.rdPM.Text = "م";
            this.rdPM.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdPM.UncheckedState.BorderThickness = 2;
            this.rdPM.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdPM.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdPM.UseVisualStyleBackColor = true;
            // 
            // rdAM
            // 
            this.rdAM.AutoSize = true;
            this.rdAM.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdAM.CheckedState.BorderThickness = 0;
            this.rdAM.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdAM.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdAM.CheckedState.InnerOffset = -4;
            this.rdAM.Enabled = false;
            this.rdAM.Location = new System.Drawing.Point(160, 78);
            this.rdAM.Name = "rdAM";
            this.rdAM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdAM.Size = new System.Drawing.Size(55, 29);
            this.rdAM.TabIndex = 28;
            this.rdAM.TabStop = true;
            this.rdAM.Text = "ص";
            this.rdAM.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdAM.UncheckedState.BorderThickness = 2;
            this.rdAM.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdAM.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdAM.UseVisualStyleBackColor = true;
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
            this.txtTo.Location = new System.Drawing.Point(272, 75);
            this.txtTo.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.PlaceholderText = "";
            this.txtTo.ReadOnly = true;
            this.txtTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTo.SelectedText = "";
            this.txtTo.ShadowDecoration.Parent = this.txtTo;
            this.txtTo.Size = new System.Drawing.Size(91, 36);
            this.txtTo.TabIndex = 26;
            this.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "الى";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "من";
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
            this.txtFrom.Location = new System.Drawing.Point(423, 75);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PasswordChar = '\0';
            this.txtFrom.PlaceholderText = "";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFrom.SelectedText = "";
            this.txtFrom.ShadowDecoration.Parent = this.txtFrom;
            this.txtFrom.Size = new System.Drawing.Size(91, 36);
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
            this.cbxGroups.Location = new System.Drawing.Point(563, 73);
            this.cbxGroups.Name = "cbxGroups";
            this.cbxGroups.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxGroups.ShadowDecoration.Parent = this.cbxGroups;
            this.cbxGroups.Size = new System.Drawing.Size(452, 36);
            this.cbxGroups.TabIndex = 18;
            this.cbxGroups.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxGroups.SelectedIndexChanged += new System.EventHandler(this.cbxGroups_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1030, 76);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "المجموعة";
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
            this.cbxGrades.Location = new System.Drawing.Point(563, 31);
            this.cbxGrades.Name = "cbxGrades";
            this.cbxGrades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxGrades.ShadowDecoration.Parent = this.cbxGrades;
            this.cbxGrades.Size = new System.Drawing.Size(452, 36);
            this.cbxGrades.TabIndex = 16;
            this.cbxGrades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxGrades.SelectedIndexChanged += new System.EventHandler(this.cbxGrades_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1056, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "الصف";
            // 
            // txtPrtPhone
            // 
            this.txtPrtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrtPhone.AutoRoundedCorners = true;
            this.txtPrtPhone.BorderRadius = 19;
            this.txtPrtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrtPhone.DefaultText = "";
            this.txtPrtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrtPhone.DisabledState.Parent = this.txtPrtPhone;
            this.txtPrtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrtPhone.FocusedState.Parent = this.txtPrtPhone;
            this.txtPrtPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPrtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrtPhone.HoverState.Parent = this.txtPrtPhone;
            this.txtPrtPhone.Location = new System.Drawing.Point(588, 178);
            this.txtPrtPhone.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txtPrtPhone.Name = "txtPrtPhone";
            this.txtPrtPhone.PasswordChar = '\0';
            this.txtPrtPhone.PlaceholderText = "رقم هاتف ولي الامر";
            this.txtPrtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrtPhone.SelectedText = "";
            this.txtPrtPhone.ShadowDecoration.Parent = this.txtPrtPhone;
            this.txtPrtPhone.Size = new System.Drawing.Size(552, 40);
            this.txtPrtPhone.TabIndex = 9;
            // 
            // txtStdPhone
            // 
            this.txtStdPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStdPhone.AutoRoundedCorners = true;
            this.txtStdPhone.BorderRadius = 19;
            this.txtStdPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStdPhone.DefaultText = "";
            this.txtStdPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStdPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStdPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStdPhone.DisabledState.Parent = this.txtStdPhone;
            this.txtStdPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStdPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStdPhone.FocusedState.Parent = this.txtStdPhone;
            this.txtStdPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdPhone.ForeColor = System.Drawing.Color.Black;
            this.txtStdPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStdPhone.HoverState.Parent = this.txtStdPhone;
            this.txtStdPhone.Location = new System.Drawing.Point(588, 114);
            this.txtStdPhone.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txtStdPhone.Name = "txtStdPhone";
            this.txtStdPhone.PasswordChar = '\0';
            this.txtStdPhone.PlaceholderText = "رقم الطالب";
            this.txtStdPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStdPhone.SelectedText = "";
            this.txtStdPhone.ShadowDecoration.Parent = this.txtStdPhone;
            this.txtStdPhone.Size = new System.Drawing.Size(552, 40);
            this.txtStdPhone.TabIndex = 8;
            // 
            // txtStdName
            // 
            this.txtStdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStdName.AutoRoundedCorners = true;
            this.txtStdName.BorderRadius = 19;
            this.txtStdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStdName.DefaultText = "";
            this.txtStdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStdName.DisabledState.Parent = this.txtStdName;
            this.txtStdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStdName.FocusedState.Parent = this.txtStdName;
            this.txtStdName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdName.ForeColor = System.Drawing.Color.Black;
            this.txtStdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStdName.HoverState.Parent = this.txtStdName;
            this.txtStdName.Location = new System.Drawing.Point(588, 50);
            this.txtStdName.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txtStdName.Name = "txtStdName";
            this.txtStdName.PasswordChar = '\0';
            this.txtStdName.PlaceholderText = "اسم الطالب";
            this.txtStdName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStdName.SelectedText = "";
            this.txtStdName.ShadowDecoration.Parent = this.txtStdName;
            this.txtStdName.Size = new System.Drawing.Size(552, 40);
            this.txtStdName.TabIndex = 7;
            // 
            // chkRptPhone
            // 
            this.chkRptPhone.AutoSize = true;
            this.chkRptPhone.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkRptPhone.CheckedState.BorderRadius = 2;
            this.chkRptPhone.CheckedState.BorderThickness = 0;
            this.chkRptPhone.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.chkRptPhone.ForeColor = System.Drawing.Color.Black;
            this.chkRptPhone.Location = new System.Drawing.Point(452, 150);
            this.chkRptPhone.Name = "chkRptPhone";
            this.chkRptPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRptPhone.Size = new System.Drawing.Size(122, 29);
            this.chkRptPhone.TabIndex = 18;
            this.chkRptPhone.Text = "تكرار الهاتف";
            this.chkRptPhone.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkRptPhone.UncheckedState.BorderRadius = 2;
            this.chkRptPhone.UncheckedState.BorderThickness = 0;
            this.chkRptPhone.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkRptPhone.UseVisualStyleBackColor = true;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 771);
            this.ControlBox = false;
            this.Controls.Add(this.guna2GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtPrtPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxGroups;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbxGrades;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddStd;
        private Guna.UI2.WinForms.Guna2TextBox txtGroupCount;
        private Guna.UI2.WinForms.Guna2TextBox txtGradeCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2RadioButton rdPM;
        private Guna.UI2.WinForms.Guna2RadioButton rdAM;
        private Guna.UI2.WinForms.Guna2TextBox txtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtFrom;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtGroupDays;
        private Guna.UI2.WinForms.Guna2TextBox txtStdPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtStdName;
        private Guna.UI2.WinForms.Guna2CheckBox chkRptPhone;
    }
}