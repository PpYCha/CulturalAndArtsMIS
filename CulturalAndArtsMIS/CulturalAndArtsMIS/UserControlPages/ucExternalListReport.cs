using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CulturalAndArtsMIS.Models;
using System.Data.SqlClient;
using ServiceRequestInformationSystem;
using CulturalAndArtsMIS.Forms;

namespace CulturalAndArtsMIS.UserControlPages
{
    public partial class ucExternalListReport : UserControl
    {
        public ucExternalListReport()
        {
            InitializeComponent();
        }

        private static ucExternalListReport _instance;
        public static ucExternalListReport Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucExternalListReport();
                return _instance;
            }
        }

        private void ucReport_Load(object sender, EventArgs e)
        {
            LoadListRequest();
        }

        private void LoadListRequest()
        {
            SQLCon.DbCon();
            SQLCon.sqlDataApater = new SqlDataAdapter(
         @"SELECT
                   er_ID,
                  partyOrganization AS [Organization],
                    contactPerson,
                    contactNo,
                   titleOfEvent AS [Title of Event],
                    dateOfEvent AS [Date of Event],
                    timeOfEvent AS [Time of Event],
                    venueOfEvent AS [Venue of Event],
                    granted AS [Granted],
                    denied AS [Denied],
                    pd_Solo,
                    pd_Duet,
                    pd_Chorale,
                    pd_RondallaBand,
                    pd_FolkDance,
                    pd_HipHop,
                    pd_Contemporary,
                    pd_DanceSports,
                    noOfPerformance,
                    noOfPerformer,
                    bitaw,
                    specify,
                    denied_Reason,
                    notedBy,
                    ApprovedBy

                FROM
                    ExternalRequests", SQLCon.sqlConnection);

            SQLCon.dataTable = new DataTable();
            SQLCon.sqlDataApater.Fill(SQLCon.dataTable);
            dataGridView_ListOfRequest.DataSource = SQLCon.dataTable;
            dataGridView_ListOfRequest.Columns["er_ID"].Visible = false;
            dataGridView_ListOfRequest.Columns["contactNo"].Visible = false;
            dataGridView_ListOfRequest.Columns["contactPerson"].Visible = false;
            dataGridView_ListOfRequest.Columns["pd_Solo"].Visible = false;
            dataGridView_ListOfRequest.Columns["pd_Duet"].Visible = false;
            dataGridView_ListOfRequest.Columns["pd_Chorale"].Visible = false;
            dataGridView_ListOfRequest.Columns["pd_RondallaBand"].Visible = false;
            dataGridView_ListOfRequest.Columns["pd_FolkDance"].Visible = false;
            dataGridView_ListOfRequest.Columns["pd_HipHop"].Visible = false;
            dataGridView_ListOfRequest.Columns["pd_Contemporary"].Visible = false;
            dataGridView_ListOfRequest.Columns["pd_DanceSports"].Visible = false;
            dataGridView_ListOfRequest.Columns["noOfPerformance"].Visible = false;
            dataGridView_ListOfRequest.Columns["noOfPerformer"].Visible = false;
            dataGridView_ListOfRequest.Columns["bitaw"].Visible = false;
            dataGridView_ListOfRequest.Columns["specify"].Visible = false;
            dataGridView_ListOfRequest.Columns["denied_Reason"].Visible = false;
            dataGridView_ListOfRequest.Columns["notedBy"].Visible = false;
            dataGridView_ListOfRequest.Columns["ApprovedBy"].Visible = false;


            label_Count.Text = dataGridView_ListOfRequest.RowCount.ToString();

        }

        private void bt_Granted_Click(object sender, EventArgs e)
        {
            using (cAaMISContext ctx = new cAaMISContext())
            {

                var granted = ctx.ExternalRequest.First<ExternalRequest>();

                granted.er_ID = Convert.ToInt32(dataGridView_ListOfRequest.SelectedRows[0].Cells[0].Value.ToString());
                granted.ApprovedBy = ctx.Setting.Select(x => x.ApproveBy).Single();
                granted.notedBy = ctx.Setting.Select(x => x.NotedBy).Single();
                granted.granted = true;
                granted.denied = false;

                ctx.SaveChanges();
            }
            LoadListRequest();
            MessageBoxNotify("Granted");
        }

        private void tb_Deny_Click(object sender, EventArgs e)
        {
            using (cAaMISContext ctx = new cAaMISContext())
            {
                var denied = ctx.ExternalRequest.First<ExternalRequest>();

                denied.er_ID = Convert.ToInt32(dataGridView_ListOfRequest.SelectedRows[0].Cells[0].Value.ToString());
                denied.denied_Reason = tb_DeniedReason.Text;
                denied.denied = true;
                denied.granted = false;

                ctx.SaveChanges();
            }
            LoadListRequest();
            MessageBoxNotify("Denied");
        }

        private void MessageBoxNotify(string message)
        {
            MessageBox.Show(message + "Succesfully");
        }

        private void tb_ViewInfo_Click(object sender, EventArgs e)
        {
            ViewExternalReportForm viewExternalReportForm = new ViewExternalReportForm();
            ViewExternalReportForm.dgvr_ExternalRpt = dataGridView_ListOfRequest.SelectedRows[0];
            viewExternalReportForm.ShowDialog();
            LoadListRequest();
        }

        private void bt_Print_Click(object sender, EventArgs e)
        {
            ViewPrintExternal viewPrintExternal = new ViewPrintExternal();
            ViewPrintExternal.tempRptId = dataGridView_ListOfRequest.SelectedRows[0].Cells[0].Value.ToString();
            viewPrintExternal.ShowDialog();
        }
    }
}
