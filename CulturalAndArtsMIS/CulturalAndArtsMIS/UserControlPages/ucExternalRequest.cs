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
using System.Xml.Serialization;
using System.Runtime.CompilerServices;

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

        private static string choice;

        public static string Choice
        {
            get { return choice; }
            set
            {
                choice = value;

            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (choice == "internal")
            {

                SaveExternalReport(true);
            }
            if (choice == "external")
            {
                SaveExternalReport(false);
            }
        }

        private void SaveExternalReport(bool value)
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
                    specify = tb_Specify.Text,
                    ExternalInternal = value
                };

                ctx.ExternalRequest.Add(externalReport);
                ctx.SaveChanges();
            }
        }

        private void ucExternalRequest_Load(object sender, EventArgs e)
        {
            labelTextInfo(choice);

        }

        public void labelTextInfo(string value)
        {
            if (value == "internal")
            {
                this.label_ExternalInternal.Text = "Internal";
            }
            if (value == "external")
            {
                this.label_ExternalInternal.Text = "External";
            }

        }
    }
}
