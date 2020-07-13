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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subPanel_side_Request = new System.Windows.Forms.Panel();
            this.bt_side_EPR = new System.Windows.Forms.Button();
            this.bt_side_IPR = new System.Windows.Forms.Button();
            this.bt_side_Request = new System.Windows.Forms.Button();
            this.bt_side_Reports = new System.Windows.Forms.Button();
            this.bt_side_Services = new System.Windows.Forms.Button();
            this.subPanel_side_Events = new System.Windows.Forms.Panel();
            this.bt_side_Add_Events = new System.Windows.Forms.Button();
            this.bt_side_Year_Events = new System.Windows.Forms.Button();
            this.bt_side_Events = new System.Windows.Forms.Button();
            this.bt_side_Profile = new System.Windows.Forms.Button();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.subPanel_side_Request.SuspendLayout();
            this.subPanel_side_Events.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.subPanel_side_Request);
            this.panel2.Controls.Add(this.bt_side_Request);
            this.panel2.Controls.Add(this.bt_side_Reports);
            this.panel2.Controls.Add(this.bt_side_Services);
            this.panel2.Controls.Add(this.subPanel_side_Events);
            this.panel2.Controls.Add(this.bt_side_Events);
            this.panel2.Controls.Add(this.bt_side_Profile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 484);
            this.panel2.TabIndex = 1;
            // 
            // subPanel_side_Request
            // 
            this.subPanel_side_Request.Controls.Add(this.bt_side_EPR);
            this.subPanel_side_Request.Controls.Add(this.bt_side_IPR);
            this.subPanel_side_Request.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel_side_Request.Location = new System.Drawing.Point(0, 272);
            this.subPanel_side_Request.Name = "subPanel_side_Request";
            this.subPanel_side_Request.Size = new System.Drawing.Size(211, 83);
            this.subPanel_side_Request.TabIndex = 6;
            // 
            // bt_side_EPR
            // 
            this.bt_side_EPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_EPR.Location = new System.Drawing.Point(0, 39);
            this.bt_side_EPR.Name = "bt_side_EPR";
            this.bt_side_EPR.Size = new System.Drawing.Size(211, 39);
            this.bt_side_EPR.TabIndex = 7;
            this.bt_side_EPR.Text = "External Performance Request";
            this.bt_side_EPR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_side_EPR.UseVisualStyleBackColor = true;
            // 
            // bt_side_IPR
            // 
            this.bt_side_IPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_IPR.Location = new System.Drawing.Point(0, 0);
            this.bt_side_IPR.Name = "bt_side_IPR";
            this.bt_side_IPR.Size = new System.Drawing.Size(211, 39);
            this.bt_side_IPR.TabIndex = 6;
            this.bt_side_IPR.Text = "Internal Performance Request";
            this.bt_side_IPR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_side_IPR.UseVisualStyleBackColor = true;
            // 
            // bt_side_Request
            // 
            this.bt_side_Request.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Request.Location = new System.Drawing.Point(0, 233);
            this.bt_side_Request.Name = "bt_side_Request";
            this.bt_side_Request.Size = new System.Drawing.Size(211, 39);
            this.bt_side_Request.TabIndex = 5;
            this.bt_side_Request.Text = "Request";
            this.bt_side_Request.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Request.UseVisualStyleBackColor = true;
            this.bt_side_Request.Click += new System.EventHandler(this.bt_side_Request_Click);
            // 
            // bt_side_Reports
            // 
            this.bt_side_Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Reports.Location = new System.Drawing.Point(0, 194);
            this.bt_side_Reports.Name = "bt_side_Reports";
            this.bt_side_Reports.Size = new System.Drawing.Size(211, 39);
            this.bt_side_Reports.TabIndex = 4;
            this.bt_side_Reports.Text = "Reports";
            this.bt_side_Reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Reports.UseVisualStyleBackColor = true;
            // 
            // bt_side_Services
            // 
            this.bt_side_Services.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Services.Location = new System.Drawing.Point(0, 155);
            this.bt_side_Services.Name = "bt_side_Services";
            this.bt_side_Services.Size = new System.Drawing.Size(211, 39);
            this.bt_side_Services.TabIndex = 3;
            this.bt_side_Services.Text = "Services";
            this.bt_side_Services.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Services.UseVisualStyleBackColor = true;
            this.bt_side_Services.Click += new System.EventHandler(this.bt_side_Services_Click);
            // 
            // subPanel_side_Events
            // 
            this.subPanel_side_Events.Controls.Add(this.bt_side_Add_Events);
            this.subPanel_side_Events.Controls.Add(this.bt_side_Year_Events);
            this.subPanel_side_Events.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel_side_Events.Location = new System.Drawing.Point(0, 78);
            this.subPanel_side_Events.Name = "subPanel_side_Events";
            this.subPanel_side_Events.Size = new System.Drawing.Size(211, 77);
            this.subPanel_side_Events.TabIndex = 8;
            // 
            // bt_side_Add_Events
            // 
            this.bt_side_Add_Events.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Add_Events.Location = new System.Drawing.Point(0, 39);
            this.bt_side_Add_Events.Name = "bt_side_Add_Events";
            this.bt_side_Add_Events.Size = new System.Drawing.Size(211, 39);
            this.bt_side_Add_Events.TabIndex = 7;
            this.bt_side_Add_Events.Text = "Add Events";
            this.bt_side_Add_Events.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_side_Add_Events.UseVisualStyleBackColor = true;
            this.bt_side_Add_Events.Click += new System.EventHandler(this.bt_side_Add_Events_Click);
            // 
            // bt_side_Year_Events
            // 
            this.bt_side_Year_Events.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Year_Events.Location = new System.Drawing.Point(0, 0);
            this.bt_side_Year_Events.Name = "bt_side_Year_Events";
            this.bt_side_Year_Events.Size = new System.Drawing.Size(211, 39);
            this.bt_side_Year_Events.TabIndex = 6;
            this.bt_side_Year_Events.Text = "Year List of Events";
            this.bt_side_Year_Events.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_side_Year_Events.UseVisualStyleBackColor = true;
            this.bt_side_Year_Events.Click += new System.EventHandler(this.bt_side_Year_Events_Click);
            // 
            // bt_side_Events
            // 
            this.bt_side_Events.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Events.Location = new System.Drawing.Point(0, 39);
            this.bt_side_Events.Name = "bt_side_Events";
            this.bt_side_Events.Size = new System.Drawing.Size(211, 39);
            this.bt_side_Events.TabIndex = 2;
            this.bt_side_Events.Text = "Events";
            this.bt_side_Events.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Events.UseVisualStyleBackColor = true;
            this.bt_side_Events.Click += new System.EventHandler(this.bt_side_Events_Click);
            // 
            // bt_side_Profile
            // 
            this.bt_side_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_side_Profile.Location = new System.Drawing.Point(0, 0);
            this.bt_side_Profile.Name = "bt_side_Profile";
            this.bt_side_Profile.Size = new System.Drawing.Size(211, 39);
            this.bt_side_Profile.TabIndex = 1;
            this.bt_side_Profile.Text = "Profile";
            this.bt_side_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_side_Profile.UseVisualStyleBackColor = true;
            this.bt_side_Profile.Click += new System.EventHandler(this.bt_side_Profile_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(211, 10);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(817, 484);
            this.panel_Body.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Request";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 494);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.subPanel_side_Request.ResumeLayout(false);
            this.subPanel_side_Events.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Button button1;
    }
}

