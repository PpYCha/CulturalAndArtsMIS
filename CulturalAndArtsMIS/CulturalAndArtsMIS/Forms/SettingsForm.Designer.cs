namespace CulturalAndArtsMIS.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tb_ApproveBy = new System.Windows.Forms.TextBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NotedBy = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ApproveBy
            // 
            this.tb_ApproveBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ApproveBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ApproveBy.Location = new System.Drawing.Point(90, 10);
            this.tb_ApproveBy.Name = "tb_ApproveBy";
            this.tb_ApproveBy.Size = new System.Drawing.Size(274, 23);
            this.tb_ApproveBy.TabIndex = 0;
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.OliveDrab;
            this.bt_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_Save.FlatAppearance.BorderSize = 0;
            this.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Save.Location = new System.Drawing.Point(0, 71);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(367, 46);
            this.bt_Save.TabIndex = 36;
            this.bt_Save.Text = "SAVE";
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Approve By:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.9782F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.0218F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_NotedBy, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_ApproveBy, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.84507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.29578F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 71);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Noted By:";
            // 
            // tb_NotedBy
            // 
            this.tb_NotedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_NotedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_NotedBy.Location = new System.Drawing.Point(90, 38);
            this.tb_NotedBy.Name = "tb_NotedBy";
            this.tb_NotedBy.Size = new System.Drawing.Size(274, 23);
            this.tb_NotedBy.TabIndex = 39;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(367, 117);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bt_Save);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ApproveBy;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_NotedBy;
        private System.Windows.Forms.Label label1;
    }
}