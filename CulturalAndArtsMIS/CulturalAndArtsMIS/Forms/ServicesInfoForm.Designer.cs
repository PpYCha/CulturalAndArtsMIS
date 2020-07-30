namespace CulturalAndArtsMIS.ServicesForms
{
    partial class ServicesInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesInfoForm));
            this.dataGridView_ListOfMembers = new System.Windows.Forms.DataGridView();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_History = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ListOfMembers
            // 
            this.dataGridView_ListOfMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListOfMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListOfMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListOfMembers.Location = new System.Drawing.Point(24, 200);
            this.dataGridView_ListOfMembers.Name = "dataGridView_ListOfMembers";
            this.dataGridView_ListOfMembers.RowHeadersVisible = false;
            this.dataGridView_ListOfMembers.Size = new System.Drawing.Size(433, 235);
            this.dataGridView_ListOfMembers.TabIndex = 5;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(19, 30);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(142, 25);
            this.label_Title.TabIndex = 4;
            this.label_Title.Text = "Chorale Music";
            // 
            // label_History
            // 
            this.label_History.Location = new System.Drawing.Point(21, 68);
            this.label_History.Name = "label_History";
            this.label_History.Size = new System.Drawing.Size(436, 114);
            this.label_History.TabIndex = 3;
            this.label_History.Text = resources.GetString("label_History.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Services:";
            // 
            // ServicesInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_ListOfMembers);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_History);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ServicesInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chorale Music";
            this.Load += new System.EventHandler(this.ServicesInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ListOfMembers;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_History;
        private System.Windows.Forms.Label label3;
    }
}