namespace CulturalAndArtsMIS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_Side_Body = new System.Windows.Forms.Panel();
            this.subPanel_side_Request = new System.Windows.Forms.Panel();
            this.bt_side_EPR = new System.Windows.Forms.Button();
            this.bt_side_IPR = new System.Windows.Forms.Button();
            this.subPanel_side_Report = new System.Windows.Forms.Panel();
            this.bt_ExternalRPT = new System.Windows.Forms.Button();
            this.bt_InternalRPT = new System.Windows.Forms.Button();
            this.subPanel_side_Events = new System.Windows.Forms.Panel();
            this.bt_side_Year_Events = new System.Windows.Forms.Button();
            this.bt_side_Add_Events = new System.Windows.Forms.Button();
            this.subPanel_side_Profile = new System.Windows.Forms.Panel();
            this.bt_Side_StudentList = new System.Windows.Forms.Button();
            this.bt_Side_AddStudentProfile = new System.Windows.Forms.Button();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.bt_Side_Logout = new System.Windows.Forms.Button();
            this.bt_Side_Accounts = new System.Windows.Forms.Button();
            this.bt_Settings = new System.Windows.Forms.Button();
            this.bt_side_Request = new System.Windows.Forms.Button();
            this.bt_side_Reports = new System.Windows.Forms.Button();
            this.bt_side_Services = new System.Windows.Forms.Button();
            this.bt_side_Events = new System.Windows.Forms.Button();
            this.bt_side_Profile = new System.Windows.Forms.Button();
            this.panel_Side_Body.SuspendLayout();
            this.subPanel_side_Request.SuspendLayout();
            this.subPanel_side_Report.SuspendLayout();
            this.subPanel_side_Events.SuspendLayout();
            this.subPanel_side_Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1028, 10);
            this.panel_Top.TabIndex = 0;
            // 
            // panel_Side_Body
            // 
            this.panel_Side_Body.AutoScroll = true;
            this.panel_Side_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel_Side_Body.Controls.Add(this.bt_Side_Logout);
            this.panel_Side_Body.Controls.Add(this.bt_Side_Accounts);
            this.panel_Side_Body.Controls.Add(this.bt_Settings);
            this.panel_Side_Body.Controls.Add(this.subPanel_side_Request);
            this.panel_Side_Body.Controls.Add(this.bt_side_Request);
            this.panel_Side_Body.Controls.Add(this.subPanel_side_Report);
            this.panel_Side_Body.Controls.Add(this.bt_side_Reports);
            this.panel_Side_Body.Controls.Add(this.bt_side_Services);
            this.panel_Side_Body.Controls.Add(this.subPanel_side_Events);
            this.panel_Side_Body.Controls.Add(this.bt_side_Events);
            this.panel_Side_Body.Controls.Add(this.subPanel_side_Profile);
            this.panel_Side_Body.Controls.Add(this.bt_side_Profile);
            this.panel_Side_Body.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Side_Body.Location = new System.Drawing.Point(0, 10);
            this.panel_Side_Body.Name = "panel_Side_Body";
            this.panel_Side_Body.Size = new System.Drawing.Size(165, 562);
            this.panel_Side_Body.TabIndex = 1;
            // 
            // subPanel_side_Request
            // 
            this.subPanel_side_Request.Controls.Add(this.bt_side_EPR);
            this.subPanel_side_Request.Controls.Add(this.bt_side_IPR);
            this.subPanel_side_Request.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel_side_Request.Location = new System.Drawing.Point(0, 436);
            this.subPanel_side_Request.Name = "subPanel_side_Request";
            this.subPanel_side_Request.Size = new System.Drawing.Size(148, 93);
            this.subPanel_side_Request.TabIndex = 6;
            // 
            // bt_side_EPR
            // 
            this.bt_side_EPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_EPR.FlatAppearance.BorderSize = 0;
            this.bt_side_EPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_side_EPR.ForeColor = System.Drawing.Color.White;
            this.bt_side_EPR.Location = new System.Drawing.Point(0, 50);
            this.bt_side_EPR.Margin = new System.Windows.Forms.Padding(0);
            this.bt_side_EPR.Name = "bt_side_EPR";
            this.bt_side_EPR.Size = new System.Drawing.Size(148, 41);
            this.bt_side_EPR.TabIndex = 7;
            this.bt_side_EPR.Text = "External Performance Request";
            this.bt_side_EPR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_side_EPR.UseVisualStyleBackColor = true;
            this.bt_side_EPR.Click += new System.EventHandler(this.bt_side_EPR_Click);
            // 
            // bt_side_IPR
            // 
            this.bt_side_IPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_IPR.FlatAppearance.BorderSize = 0;
            this.bt_side_IPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_side_IPR.ForeColor = System.Drawing.Color.White;
            this.bt_side_IPR.Location = new System.Drawing.Point(0, 0);
            this.bt_side_IPR.Margin = new System.Windows.Forms.Padding(0);
            this.bt_side_IPR.Name = "bt_side_IPR";
            this.bt_side_IPR.Size = new System.Drawing.Size(148, 50);
            this.bt_side_IPR.TabIndex = 6;
            this.bt_side_IPR.Text = "Internal Performance Request";
            this.bt_side_IPR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_side_IPR.UseVisualStyleBackColor = true;
            this.bt_side_IPR.Click += new System.EventHandler(this.bt_side_IPR_Click);
            // 
            // subPanel_side_Report
            // 
            this.subPanel_side_Report.Controls.Add(this.bt_ExternalRPT);
            this.subPanel_side_Report.Controls.Add(this.bt_InternalRPT);
            this.subPanel_side_Report.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel_side_Report.Location = new System.Drawing.Point(0, 310);
            this.subPanel_side_Report.Name = "subPanel_side_Report";
            this.subPanel_side_Report.Size = new System.Drawing.Size(148, 87);
            this.subPanel_side_Report.TabIndex = 11;
            // 
            // bt_ExternalRPT
            // 
            this.bt_ExternalRPT.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_ExternalRPT.FlatAppearance.BorderSize = 0;
            this.bt_ExternalRPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ExternalRPT.ForeColor = System.Drawing.Color.White;
            this.bt_ExternalRPT.Location = new System.Drawing.Point(0, 48);
            this.bt_ExternalRPT.Margin = new System.Windows.Forms.Padding(0);
            this.bt_ExternalRPT.Name = "bt_ExternalRPT";
            this.bt_ExternalRPT.Size = new System.Drawing.Size(148, 41);
            this.bt_ExternalRPT.TabIndex = 7;
            this.bt_ExternalRPT.Text = "External Performance Report";
            this.bt_ExternalRPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ExternalRPT.UseVisualStyleBackColor = true;
            this.bt_ExternalRPT.Click += new System.EventHandler(this.bt_ExternalRPT_Click);
            // 
            // bt_InternalRPT
            // 
            this.bt_InternalRPT.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_InternalRPT.FlatAppearance.BorderSize = 0;
            this.bt_InternalRPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_InternalRPT.ForeColor = System.Drawing.Color.White;
            this.bt_InternalRPT.Location = new System.Drawing.Point(0, 0);
            this.bt_InternalRPT.Margin = new System.Windows.Forms.Padding(0);
            this.bt_InternalRPT.Name = "bt_InternalRPT";
            this.bt_InternalRPT.Size = new System.Drawing.Size(148, 48);
            this.bt_InternalRPT.TabIndex = 6;
            this.bt_InternalRPT.Text = "Internal Performance Report";
            this.bt_InternalRPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_InternalRPT.UseVisualStyleBackColor = true;
            // 
            // subPanel_side_Events
            // 
            this.subPanel_side_Events.Controls.Add(this.bt_side_Year_Events);
            this.subPanel_side_Events.Controls.Add(this.bt_side_Add_Events);
            this.subPanel_side_Events.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel_side_Events.Location = new System.Drawing.Point(0, 155);
            this.subPanel_side_Events.Name = "subPanel_side_Events";
            this.subPanel_side_Events.Size = new System.Drawing.Size(148, 77);
            this.subPanel_side_Events.TabIndex = 8;
            // 
            // bt_side_Year_Events
            // 
            this.bt_side_Year_Events.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Year_Events.FlatAppearance.BorderSize = 0;
            this.bt_side_Year_Events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_side_Year_Events.ForeColor = System.Drawing.Color.White;
            this.bt_side_Year_Events.Location = new System.Drawing.Point(0, 39);
            this.bt_side_Year_Events.Margin = new System.Windows.Forms.Padding(0);
            this.bt_side_Year_Events.Name = "bt_side_Year_Events";
            this.bt_side_Year_Events.Size = new System.Drawing.Size(148, 39);
            this.bt_side_Year_Events.TabIndex = 6;
            this.bt_side_Year_Events.Text = "Year List of Events";
            this.bt_side_Year_Events.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_side_Year_Events.UseVisualStyleBackColor = true;
            this.bt_side_Year_Events.Click += new System.EventHandler(this.bt_side_Year_Events_Click);
            // 
            // bt_side_Add_Events
            // 
            this.bt_side_Add_Events.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Add_Events.FlatAppearance.BorderSize = 0;
            this.bt_side_Add_Events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_side_Add_Events.ForeColor = System.Drawing.Color.White;
            this.bt_side_Add_Events.Location = new System.Drawing.Point(0, 0);
            this.bt_side_Add_Events.Margin = new System.Windows.Forms.Padding(0);
            this.bt_side_Add_Events.Name = "bt_side_Add_Events";
            this.bt_side_Add_Events.Size = new System.Drawing.Size(148, 39);
            this.bt_side_Add_Events.TabIndex = 7;
            this.bt_side_Add_Events.Text = "Add Events";
            this.bt_side_Add_Events.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_side_Add_Events.UseVisualStyleBackColor = true;
            this.bt_side_Add_Events.Click += new System.EventHandler(this.bt_side_Add_Events_Click);
            // 
            // subPanel_side_Profile
            // 
            this.subPanel_side_Profile.Controls.Add(this.bt_Side_StudentList);
            this.subPanel_side_Profile.Controls.Add(this.bt_Side_AddStudentProfile);
            this.subPanel_side_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel_side_Profile.Location = new System.Drawing.Point(0, 39);
            this.subPanel_side_Profile.Name = "subPanel_side_Profile";
            this.subPanel_side_Profile.Size = new System.Drawing.Size(148, 77);
            this.subPanel_side_Profile.TabIndex = 9;
            // 
            // bt_Side_StudentList
            // 
            this.bt_Side_StudentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Side_StudentList.FlatAppearance.BorderSize = 0;
            this.bt_Side_StudentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Side_StudentList.ForeColor = System.Drawing.Color.White;
            this.bt_Side_StudentList.Location = new System.Drawing.Point(0, 39);
            this.bt_Side_StudentList.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Side_StudentList.Name = "bt_Side_StudentList";
            this.bt_Side_StudentList.Size = new System.Drawing.Size(148, 39);
            this.bt_Side_StudentList.TabIndex = 7;
            this.bt_Side_StudentList.Text = "Student List";
            this.bt_Side_StudentList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Side_StudentList.UseVisualStyleBackColor = true;
            this.bt_Side_StudentList.Click += new System.EventHandler(this.bt_Side_StudentList_Click);
            // 
            // bt_Side_AddStudentProfile
            // 
            this.bt_Side_AddStudentProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Side_AddStudentProfile.FlatAppearance.BorderSize = 0;
            this.bt_Side_AddStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Side_AddStudentProfile.ForeColor = System.Drawing.Color.White;
            this.bt_Side_AddStudentProfile.Location = new System.Drawing.Point(0, 0);
            this.bt_Side_AddStudentProfile.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Side_AddStudentProfile.Name = "bt_Side_AddStudentProfile";
            this.bt_Side_AddStudentProfile.Size = new System.Drawing.Size(148, 39);
            this.bt_Side_AddStudentProfile.TabIndex = 6;
            this.bt_Side_AddStudentProfile.Text = "Add Student Profile";
            this.bt_Side_AddStudentProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Side_AddStudentProfile.UseVisualStyleBackColor = true;
            this.bt_Side_AddStudentProfile.Click += new System.EventHandler(this.bt_Side_AddStudentProfile_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(165, 10);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(863, 562);
            this.panel_Body.TabIndex = 2;
            // 
            // bt_Side_Logout
            // 
            this.bt_Side_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Side_Logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Side_Logout.FlatAppearance.BorderSize = 0;
            this.bt_Side_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Side_Logout.ForeColor = System.Drawing.Color.White;
            this.bt_Side_Logout.Image = global::CulturalAndArtsMIS.Properties.Resources.icons8_shutdown_25px;
            this.bt_Side_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Side_Logout.Location = new System.Drawing.Point(0, 607);
            this.bt_Side_Logout.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Side_Logout.Name = "bt_Side_Logout";
            this.bt_Side_Logout.Size = new System.Drawing.Size(148, 39);
            this.bt_Side_Logout.TabIndex = 10;
            this.bt_Side_Logout.Text = "      Logout";
            this.bt_Side_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Side_Logout.UseVisualStyleBackColor = true;
            this.bt_Side_Logout.Click += new System.EventHandler(this.bt_Side_Logout_Click);
            // 
            // bt_Side_Accounts
            // 
            this.bt_Side_Accounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Side_Accounts.FlatAppearance.BorderSize = 0;
            this.bt_Side_Accounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Side_Accounts.ForeColor = System.Drawing.Color.White;
            this.bt_Side_Accounts.Image = global::CulturalAndArtsMIS.Properties.Resources.icons8_user_25px;
            this.bt_Side_Accounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Side_Accounts.Location = new System.Drawing.Point(0, 568);
            this.bt_Side_Accounts.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Side_Accounts.Name = "bt_Side_Accounts";
            this.bt_Side_Accounts.Size = new System.Drawing.Size(148, 39);
            this.bt_Side_Accounts.TabIndex = 9;
            this.bt_Side_Accounts.Text = "      Accounts";
            this.bt_Side_Accounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Side_Accounts.UseVisualStyleBackColor = true;
            this.bt_Side_Accounts.Click += new System.EventHandler(this.bt_Side_Accounts_Click);
            // 
            // bt_Settings
            // 
            this.bt_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Settings.FlatAppearance.BorderSize = 0;
            this.bt_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Settings.ForeColor = System.Drawing.Color.White;
            this.bt_Settings.Image = global::CulturalAndArtsMIS.Properties.Resources.icons8_settings_25px;
            this.bt_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Settings.Location = new System.Drawing.Point(0, 529);
            this.bt_Settings.Margin = new System.Windows.Forms.Padding(0);
            this.bt_Settings.Name = "bt_Settings";
            this.bt_Settings.Size = new System.Drawing.Size(148, 39);
            this.bt_Settings.TabIndex = 12;
            this.bt_Settings.Text = "      Settings";
            this.bt_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Settings.UseVisualStyleBackColor = true;
            this.bt_Settings.Click += new System.EventHandler(this.bt_Settings_Click);
            // 
            // bt_side_Request
            // 
            this.bt_side_Request.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Request.FlatAppearance.BorderSize = 0;
            this.bt_side_Request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_side_Request.ForeColor = System.Drawing.Color.White;
            this.bt_side_Request.Image = global::CulturalAndArtsMIS.Properties.Resources.icons8_petition_25px;
            this.bt_side_Request.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Request.Location = new System.Drawing.Point(0, 397);
            this.bt_side_Request.Margin = new System.Windows.Forms.Padding(0);
            this.bt_side_Request.Name = "bt_side_Request";
            this.bt_side_Request.Size = new System.Drawing.Size(148, 39);
            this.bt_side_Request.TabIndex = 5;
            this.bt_side_Request.Text = "      Request";
            this.bt_side_Request.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Request.UseVisualStyleBackColor = true;
            this.bt_side_Request.Click += new System.EventHandler(this.bt_side_Request_Click);
            // 
            // bt_side_Reports
            // 
            this.bt_side_Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Reports.FlatAppearance.BorderSize = 0;
            this.bt_side_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_side_Reports.ForeColor = System.Drawing.Color.White;
            this.bt_side_Reports.Image = global::CulturalAndArtsMIS.Properties.Resources.icons8_combo_chart_25px;
            this.bt_side_Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Reports.Location = new System.Drawing.Point(0, 271);
            this.bt_side_Reports.Margin = new System.Windows.Forms.Padding(0);
            this.bt_side_Reports.Name = "bt_side_Reports";
            this.bt_side_Reports.Size = new System.Drawing.Size(148, 39);
            this.bt_side_Reports.TabIndex = 4;
            this.bt_side_Reports.Text = "      Reports";
            this.bt_side_Reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Reports.UseVisualStyleBackColor = true;
            this.bt_side_Reports.Click += new System.EventHandler(this.bt_side_Reports_Click);
            // 
            // bt_side_Services
            // 
            this.bt_side_Services.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Services.FlatAppearance.BorderSize = 0;
            this.bt_side_Services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_side_Services.ForeColor = System.Drawing.Color.White;
            this.bt_side_Services.Image = global::CulturalAndArtsMIS.Properties.Resources.icons8_services_25px;
            this.bt_side_Services.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Services.Location = new System.Drawing.Point(0, 232);
            this.bt_side_Services.Margin = new System.Windows.Forms.Padding(0);
            this.bt_side_Services.Name = "bt_side_Services";
            this.bt_side_Services.Size = new System.Drawing.Size(148, 39);
            this.bt_side_Services.TabIndex = 3;
            this.bt_side_Services.Text = "      Services";
            this.bt_side_Services.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Services.UseVisualStyleBackColor = true;
            this.bt_side_Services.Click += new System.EventHandler(this.bt_side_Services_Click);
            // 
            // bt_side_Events
            // 
            this.bt_side_Events.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Events.FlatAppearance.BorderSize = 0;
            this.bt_side_Events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_side_Events.ForeColor = System.Drawing.Color.White;
            this.bt_side_Events.Image = global::CulturalAndArtsMIS.Properties.Resources.icons8_schedule_25px;
            this.bt_side_Events.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Events.Location = new System.Drawing.Point(0, 116);
            this.bt_side_Events.Margin = new System.Windows.Forms.Padding(0);
            this.bt_side_Events.Name = "bt_side_Events";
            this.bt_side_Events.Size = new System.Drawing.Size(148, 39);
            this.bt_side_Events.TabIndex = 2;
            this.bt_side_Events.Text = "      Events";
            this.bt_side_Events.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Events.UseVisualStyleBackColor = true;
            this.bt_side_Events.Click += new System.EventHandler(this.bt_side_Events_Click);
            // 
            // bt_side_Profile
            // 
            this.bt_side_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_side_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Profile.FlatAppearance.BorderSize = 0;
            this.bt_side_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_side_Profile.ForeColor = System.Drawing.Color.White;
            this.bt_side_Profile.Image = global::CulturalAndArtsMIS.Properties.Resources.icons8_profile_25px;
            this.bt_side_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Profile.Location = new System.Drawing.Point(0, 0);
            this.bt_side_Profile.Margin = new System.Windows.Forms.Padding(0);
            this.bt_side_Profile.Name = "bt_side_Profile";
            this.bt_side_Profile.Size = new System.Drawing.Size(148, 39);
            this.bt_side_Profile.TabIndex = 1;
            this.bt_side_Profile.Text = "      Profile";
            this.bt_side_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Profile.UseVisualStyleBackColor = true;
            this.bt_side_Profile.Click += new System.EventHandler(this.bt_side_Profile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1028, 572);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Side_Body);
            this.Controls.Add(this.panel_Top);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cultural and Arts - MIS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_Side_Body.ResumeLayout(false);
            this.subPanel_side_Request.ResumeLayout(false);
            this.subPanel_side_Report.ResumeLayout(false);
            this.subPanel_side_Events.ResumeLayout(false);
            this.subPanel_side_Profile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Side_Body;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel subPanel_side_Request;
        private System.Windows.Forms.Button bt_side_EPR;
        private System.Windows.Forms.Button bt_side_IPR;
        private System.Windows.Forms.Button bt_side_Request;
        private System.Windows.Forms.Button bt_side_Reports;
        private System.Windows.Forms.Button bt_side_Services;
        private System.Windows.Forms.Button bt_side_Events;
        private System.Windows.Forms.Button bt_side_Profile;
        private System.Windows.Forms.Panel subPanel_side_Events;
        private System.Windows.Forms.Button bt_side_Add_Events;
        private System.Windows.Forms.Button bt_side_Year_Events;
        private System.Windows.Forms.Button bt_Side_Accounts;
        private System.Windows.Forms.Panel subPanel_side_Profile;
        private System.Windows.Forms.Button bt_Side_StudentList;
        private System.Windows.Forms.Button bt_Side_AddStudentProfile;
        private System.Windows.Forms.Button bt_Side_Logout;
        private System.Windows.Forms.Panel subPanel_side_Report;
        private System.Windows.Forms.Button bt_ExternalRPT;
        private System.Windows.Forms.Button bt_InternalRPT;
        private System.Windows.Forms.Button bt_Settings;
    }
}

