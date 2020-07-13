namespace CulturalAndArtsMIS.UserControlPages
{
    partial class ucYearListofEvents
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
            this.dataGridView_ListOfEvents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ListOfEvents
            // 
            this.dataGridView_ListOfEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListOfEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListOfEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ListOfEvents.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ListOfEvents.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView_ListOfEvents.Name = "dataGridView_ListOfEvents";
            this.dataGridView_ListOfEvents.Size = new System.Drawing.Size(773, 436);
            this.dataGridView_ListOfEvents.TabIndex = 2;
            // 
            // ucYearListofEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_ListOfEvents);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucYearListofEvents";
            this.Size = new System.Drawing.Size(773, 436);
            this.Load += new System.EventHandler(this.ucYearListofEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ListOfEvents;
    }
}
