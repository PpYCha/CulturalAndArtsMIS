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

namespace CulturalAndArtsMIS.UserControlPages
{
    public partial class ucExternalRequest : UserControl
    {
        public ucExternalRequest()
        {
            InitializeComponent();
        }

        private static ucExternalRequest _instance;
        public static ucExternalRequest Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucExternalRequest();
                return _instance;
            }
        }

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

                ctx.ExternalRequest.Add(externalReport);
                ctx.SaveChanges();
            }
        }
    }
}
