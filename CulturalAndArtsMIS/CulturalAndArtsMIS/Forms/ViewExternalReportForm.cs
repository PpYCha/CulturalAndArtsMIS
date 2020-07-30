using CulturalAndArtsMIS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulturalAndArtsMIS.Forms
{
    public partial class ViewExternalReportForm : Form
    {
        public ViewExternalReportForm()
        {
            InitializeComponent();
        }

        public static DataGridViewRow dgvr_ExternalRpt;
        private static int tempId;

        private void bt_Save_Click(object sender, EventArgs e)
        {
            SaveExternalReport();
        }

        private void SaveExternalReport()
        {
            using (cAaMISContext ctx = new cAaMISContext())
            {
                var externalReport = new ExternalRequest
                {
                    er_ID = Convert.ToInt32(dgvr_ExternalRpt.Cells[0].Value.ToString()),
                    partyOrganization = tb_PartyOrganization.Text,
                    contactPerson = tb_ContactPerson.Text,
                    contactNo = tb_ContactNo.Text,
                    titleOfEvent = tb_TitleOfEvent.Text,
                    dateOfEvent = dtp_Date.Value,
                    timeOfEvent = tb_Time.Text,
                    venueOfEvent = tb_Venue.Text,
                    pd_Solo = checkBox_Solo.Checked,
                    pd_Duet = checkBox_Duet.Checked,
                    pd_Chorale = checkBox_Chorale.Checked,
                    pd_RondallaBand = checkBox_RondallaBand.Checked,
                    pd_FolkDance = checkBox_FolkDance.Checked,
                    pd_HipHop = checkBox_HipHop.Checked,
                    pd_Contemporary = checkBox_Contemporary.Checked,
                    pd_DanceSports = checkBox_DanceSports.Checked,
                    noOfPerformance = tb_NoOfPerformance.Text,
                    noOfPerformer = tb_NoOfPerformers.Text,
                    bitaw = checkBox_BITAW.Checked,
                    specify = tb_Specify.Text
                };

                // ctx.ExternalRequest.Attach(externalReport);
                ctx.Entry(externalReport).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        private void ViewExternalReportForm_Load(object sender, EventArgs e)
        {


            tempId = Convert.ToInt32(dgvr_ExternalRpt.Cells[0].Value.ToString());
            tb_PartyOrganization.Text = dgvr_ExternalRpt.Cells[1].Value.ToString();
            tb_ContactPerson.Text = dgvr_ExternalRpt.Cells[2].Value.ToString();
            tb_ContactNo.Text = dgvr_ExternalRpt.Cells[3].Value.ToString();
            tb_TitleOfEvent.Text = dgvr_ExternalRpt.Cells[4].Value.ToString();
            dtp_Date.Value = Convert.ToDateTime(dgvr_ExternalRpt.Cells[5].Value.ToString());
            tb_Time.Text = dgvr_ExternalRpt.Cells[6].Value.ToString();
            tb_Venue.Text = dgvr_ExternalRpt.Cells[7].Value.ToString();
            checkBox_Solo.Checked = Convert.ToBoolean(dgvr_ExternalRpt.Cells[10].Value.ToString());
            checkBox_Duet.Checked = Convert.ToBoolean(dgvr_ExternalRpt.Cells[11].Value.ToString());
            checkBox_Chorale.Checked = Convert.ToBoolean(dgvr_ExternalRpt.Cells[12].Value.ToString());
            checkBox_RondallaBand.Checked = Convert.ToBoolean(dgvr_ExternalRpt.Cells[13].Value.ToString());
            checkBox_FolkDance.Checked = Convert.ToBoolean(dgvr_ExternalRpt.Cells[14].Value.ToString());
            checkBox_HipHop.Checked = Convert.ToBoolean(dgvr_ExternalRpt.Cells[15].Value.ToString());
            checkBox_Contemporary.Checked = Convert.ToBoolean(dgvr_ExternalRpt.Cells[16].Value.ToString());
            checkBox_DanceSports.Checked = Convert.ToBoolean(dgvr_ExternalRpt.Cells[17].Value.ToString());
            tb_NoOfPerformance.Text = dgvr_ExternalRpt.Cells[18].Value.ToString();
            tb_NoOfPerformers.Text = dgvr_ExternalRpt.Cells[19].Value.ToString();
            checkBox_BITAW.Checked = Convert.ToBoolean(dgvr_ExternalRpt.Cells[20].Value.ToString());
            tb_Specify.Text = dgvr_ExternalRpt.Cells[21].Value.ToString();
        }
    }
}
