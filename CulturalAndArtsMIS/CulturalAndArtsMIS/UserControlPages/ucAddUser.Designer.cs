namespace CulturalAndArtsMIS.UserControlPages
{
    partial class ucAddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Body = new System.Windows.Forms.Panel();
            this.dataGridView_UserList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_ReTypePassword = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_MiddleName = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.AutoScroll = true;
            this.panel_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.panel_Body.Controls.Add(this.dataGridView_UserList);
            this.panel_Body.Controls.Add(this.tableLayoutPanel1);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(861, 465);
            this.panel_Body.TabIndex = 0;
            // 
            // dataGridView_UserList
            // 
            this.dataGridView_UserList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_UserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UserList.Location = new System.Drawing.Point(388, 7);
            this.dataGridView_UserList.MultiSelect = false;
            this.dataGridView_UserList.Name = "dataGridView_UserList";
            this.dataGridView_UserList.RowHeadersWidth = 10;
            this.dataGridView_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_UserList.Size = new System.Drawing.Size(466, 448);
            this.dataGridView_UserList.TabIndex = 1;
            this.dataGridView_UserList.DoubleClick += new System.EventHandler(this.dataGridView_UserList_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.97849F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.02151F));
            this.tableLayoutPanel1.Controls.Add(this.tb_FirstName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_ReTypePassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Username, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_MiddleName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_LastName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.bt_Save, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.bt_Update, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cb_Role, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(147, 177);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(222, 23);
            this.tb_FirstName.TabIndex = 9;
            // 
            // tb_ReTypePassword
            // 
            this.tb_ReTypePassword.Location = new System.Drawing.Point(147, 119);
            this.tb_ReTypePassword.Name = "tb_ReTypePassword";
            this.tb_ReTypePassword.Size = new System.Drawing.Size(222, 23);
            this.tb_ReTypePassword.TabIndex = 8;
            this.tb_ReTypePassword.UseSystemPasswordChar = true;
            this.tb_ReTypePassword.Enter += new System.EventHandler(this.tb_ReTypePassword_Enter);
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(147, 61);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(222, 23);
            this.tb_Password.TabIndex = 7;
            this.tb_Password.UseSystemPasswordChar = true;
            this.tb_Password.Enter += new System.EventHandler(this.tb_Password_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Re-Type Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(147, 3);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(222, 23);
            this.tb_Username.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Middle Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Last Name";
            // 
            // tb_MiddleName
            // 
            this.tb_MiddleName.Location = new System.Drawing.Point(147, 235);
            this.tb_MiddleName.Name = "tb_MiddleName";
            this.tb_MiddleName.Size = new System.Drawing.Size(222, 23);
            this.tb_MiddleName.TabIndex = 12;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(147, 293);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(222, 23);
            this.tb_LastName.TabIndex = 13;
            // 
            // bt_Save
            // 
            this.bt_Save.FlatAppearance.BorderSize = 0;
            this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Save.Location = new System.Drawing.Point(3, 409);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(134, 50);
            this.bt_Save.TabIndex = 4;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Update
            // 
            this.bt_Update.FlatAppearance.BorderSize = 0;
            this.bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Update.Location = new System.Drawing.Point(147, 409);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(134, 50);
            this.bt_Update.TabIndex = 5;
            this.bt_Update.Text = "Delete";
            this.bt_Update.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Role";
            // 
            // cb_Role
            // 
            this.cb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Items.AddRange(new object[] {
            "Admin",
            "Clerk"});
            this.cb_Role.Location = new System.Drawing.Point(147, 351);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(222, 24);
            this.cb_Role.TabIndex = 15;
            // 
            // ucAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Body);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucAddUser";
            this.Size = new System.Drawing.Size(861, 465);
            this.Load += new System.EventHandler(this.ucAddUser_Load);
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_ReTypePassword;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_MiddleName;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.DataGridView dataGridView_UserList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Role;
    }
}
