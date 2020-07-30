namespace CulturalAndArtsMIS.UserControlPages
{
    partial class ucStudentProfileList
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
            this.dataGridView_ListStudentProfile = new System.Windows.Forms.DataGridView();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListStudentProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ListStudentProfile
            // 
            this.dataGridView_ListStudentProfile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListStudentProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListStudentProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_ListStudentProfile.Location = new System.Drawing.Point(0, 72);
            this.dataGridView_ListStudentProfile.Name = "dataGridView_ListStudentProfile";
            this.dataGridView_ListStudentProfile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ListStudentProfile.Size = new System.Drawing.Size(931, 430);
            this.dataGridView_ListStudentProfile.TabIndex = 0;
            this.dataGridView_ListStudentProfile.DoubleClick += new System.EventHandler(this.dataGridView_ListStudentProfile_DoubleClick);
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Location = new System.Drawing.Point(657, 20);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(126, 23);
            this.tb_Search.TabIndex = 1;
            // 
            // bt_Search
            // 
            this.bt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Search.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_Search.FlatAppearance.BorderSize = 0;
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.ForeColor = System.Drawing.Color.White;
            this.bt_Search.Location = new System.Drawing.Point(805, 19);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(80, 24);
            this.bt_Search.TabIndex = 2;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // ucStudentProfileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dataGridView_ListStudentProfile);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucStudentProfileList";
            this.Size = new System.Drawing.Size(931, 502);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListStudentProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ListStudentProfile;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button bt_Search;
    }
}
