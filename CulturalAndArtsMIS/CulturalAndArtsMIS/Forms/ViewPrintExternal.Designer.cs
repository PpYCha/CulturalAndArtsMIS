namespace CulturalAndArtsMIS.Forms
{
    partial class ViewPrintExternal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPrintExternal));
            this.crystalReportViewer_External = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_External
            // 
            this.crystalReportViewer_External.ActiveViewIndex = -1;
            this.crystalReportViewer_External.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_External.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_External.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_External.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_External.Name = "crystalReportViewer_External";
            this.crystalReportViewer_External.ShowCloseButton = false;
            this.crystalReportViewer_External.ShowCopyButton = false;
            this.crystalReportViewer_External.ShowGotoPageButton = false;
            this.crystalReportViewer_External.ShowGroupTreeButton = false;
            this.crystalReportViewer_External.ShowLogo = false;
            this.crystalReportViewer_External.ShowParameterPanelButton = false;
            this.crystalReportViewer_External.ShowRefreshButton = false;
            this.crystalReportViewer_External.ShowTextSearchButton = false;
            this.crystalReportViewer_External.Size = new System.Drawing.Size(933, 497);
            this.crystalReportViewer_External.TabIndex = 0;
            this.crystalReportViewer_External.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ViewPrintExternal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 497);
            this.Controls.Add(this.crystalReportViewer_External);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewPrintExternal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print External Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewPrintExternal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_External;
    }
}