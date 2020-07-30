namespace CulturalAndArtsMIS.UserControlPages
{
    partial class ucExternalListReport
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
            this.dataGridView_ListOfRequest = new System.Windows.Forms.DataGridView();
            this.bt_Granted = new System.Windows.Forms.Button();
            this.bt_Deny = new System.Windows.Forms.Button();
            this.tb_ViewInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_DeniedReason = new System.Windows.Forms.TextBox();
            this.bt_Print = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfRequest)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_ListOfRequest
            // 
            this.dataGridView_ListOfRequest.AllowUserToAddRows = false;
            this.dataGridView_ListOfRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListOfRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListOfRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListOfRequest.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ListOfRequest.Name = "dataGridView_ListOfRequest";
            this.dataGridView_ListOfRequest.ReadOnly = true;
            this.dataGridView_ListOfRequest.RowHeadersVisible = false;
            this.dataGridView_ListOfRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ListOfRequest.Size = new System.Drawing.Size(990, 361);
            this.dataGridView_ListOfRequest.TabIndex = 0;
            // 
            // bt_Granted
            // 
            this.bt_Granted.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_Granted.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Granted.FlatAppearance.BorderSize = 0;
            this.bt_Granted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Granted.Location = new System.Drawing.Point(0, 0);
            this.bt_Granted.Name = "bt_Granted";
            this.bt_Granted.Size = new System.Drawing.Size(223, 74);
            this.bt_Granted.TabIndex = 35;
            this.bt_Granted.Text = "Granted";
            this.bt_Granted.UseVisualStyleBackColor = false;
            this.bt_Granted.Click += new System.EventHandler(this.bt_Granted_Click);
            // 
            // bt_Deny
            // 
            this.bt_Deny.BackColor = System.Drawing.Color.DarkRed;
            this.bt_Deny.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Deny.FlatAppearance.BorderSize = 0;
            this.bt_Deny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Deny.Location = new System.Drawing.Point(0, 74);
            this.bt_Deny.Name = "bt_Deny";
            this.bt_Deny.Size = new System.Drawing.Size(223, 74);
            this.bt_Deny.TabIndex = 36;
            this.bt_Deny.Text = "Deny";
            this.bt_Deny.UseVisualStyleBackColor = false;
            this.bt_Deny.Click += new System.EventHandler(this.tb_Deny_Click);
            // 
            // tb_ViewInfo
            // 
            this.tb_ViewInfo.BackColor = System.Drawing.Color.DimGray;
            this.tb_ViewInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_ViewInfo.FlatAppearance.BorderSize = 0;
            this.tb_ViewInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tb_ViewInfo.Location = new System.Drawing.Point(0, 0);
            this.tb_ViewInfo.Name = "tb_ViewInfo";
            this.tb_ViewInfo.Size = new System.Drawing.Size(223, 74);
            this.tb_ViewInfo.TabIndex = 37;
            this.tb_ViewInfo.Text = "View Info";
            this.tb_ViewInfo.UseVisualStyleBackColor = false;
            this.tb_ViewInfo.Click += new System.EventHandler(this.tb_ViewInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(544, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 148);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_Count);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tb_Search);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tb_DeniedReason);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 148);
            this.panel2.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Denied due to";
            // 
            // tb_DeniedReason
            // 
            this.tb_DeniedReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_DeniedReason.Location = new System.Drawing.Point(96, 119);
            this.tb_DeniedReason.Name = "tb_DeniedReason";
            this.tb_DeniedReason.Size = new System.Drawing.Size(442, 23);
            this.tb_DeniedReason.TabIndex = 39;
            // 
            // bt_Print
            // 
            this.bt_Print.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_Print.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Print.FlatAppearance.BorderSize = 0;
            this.bt_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Print.Location = new System.Drawing.Point(0, 74);
            this.bt_Print.Name = "bt_Print";
            this.bt_Print.Size = new System.Drawing.Size(223, 74);
            this.bt_Print.TabIndex = 38;
            this.bt_Print.Text = "Print";
            this.bt_Print.UseVisualStyleBackColor = false;
            this.bt_Print.Click += new System.EventHandler(this.bt_Print_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_Print);
            this.panel3.Controls.Add(this.tb_ViewInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 148);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bt_Deny);
            this.panel4.Controls.Add(this.bt_Granted);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(223, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 148);
            this.panel4.TabIndex = 1;
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Location = new System.Drawing.Point(96, 74);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(442, 23);
            this.tb_Search.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CulturalAndArtsMIS.Properties.Resources.icons8_search_25px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(65, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "External List:";
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Count.Location = new System.Drawing.Point(123, 14);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(59, 23);
            this.label_Count.TabIndex = 46;
            this.label_Count.Text = "Count";
            // 
            // ucExternalListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_ListOfRequest);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucExternalListReport";
            this.Size = new System.Drawing.Size(990, 515);
            this.Load += new System.EventHandler(this.ucReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfRequest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ListOfRequest;
        private System.Windows.Forms.Button bt_Granted;
        private System.Windows.Forms.Button bt_Deny;
        private System.Windows.Forms.Button tb_ViewInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_DeniedReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Print;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Count;
        private System.Windows.Forms.Label label2;
    }
}
