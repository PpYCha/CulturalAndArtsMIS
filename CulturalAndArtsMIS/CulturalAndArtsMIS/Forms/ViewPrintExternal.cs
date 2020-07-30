using CulturalAndArtsMIS.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulturalAndArtsMIS.Forms
{
    public partial class ViewPrintExternal : Form
    {
        public ViewPrintExternal()
        {
            InitializeComponent();
        }

        public static string tempRptId;

        private void ViewPrintExternal_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;


            rpt_ExternalRequest rpt_ExternalRequest = new rpt_ExternalRequest();

            rpt_ExternalRequest.SetParameterValue("externalReportID", Convert.ToInt32(tempRptId));


            crystalReportViewer_External.ReportSource = rpt_ExternalRequest;
            Cursor.Current = Cursors.Default;
        }
    }
}
