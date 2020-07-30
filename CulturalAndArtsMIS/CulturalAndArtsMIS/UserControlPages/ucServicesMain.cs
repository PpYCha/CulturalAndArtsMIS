using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CulturalAndArtsMIS.ServicesForms;

namespace CulturalAndArtsMIS.UserControlPages
{
    public partial class ucServicesMain : UserControl
    {
        public ucServicesMain()
        {
            InitializeComponent();
        }

        private static ucServicesMain _instance;
        public static ucServicesMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucServicesMain();
                return _instance;
            }
        }

        private void bt_ChoraleMusic_Click(object sender, EventArgs e)
        {
            ServicesInfoForm choraleMusicForm = new ServicesInfoForm();
            ServicesInfoForm.Choice = "Chorale";
            choraleMusicForm.ShowDialog();

        }

        private void bt_LiveMusic_Click(object sender, EventArgs e)
        {
            ServicesInfoForm choraleMusicForm = new ServicesInfoForm();
            ServicesInfoForm.Choice = "Live";
            choraleMusicForm.ShowDialog();
        }

        private void bt_Rondalla_Click(object sender, EventArgs e)
        {
            ServicesInfoForm choraleMusicForm = new ServicesInfoForm();
            ServicesInfoForm.Choice = "Rondalla";
            choraleMusicForm.ShowDialog();
        }

        private void bt_FolkHipHop_Click(object sender, EventArgs e)
        {
            ServicesInfoForm choraleMusicForm = new ServicesInfoForm();
            ServicesInfoForm.Choice = "Dance";
            choraleMusicForm.ShowDialog();
        }

        private void bt_Theatre_Click(object sender, EventArgs e)
        {
            ServicesInfoForm choraleMusicForm = new ServicesInfoForm();
            ServicesInfoForm.Choice = "Theatre";
            choraleMusicForm.ShowDialog();
        }

        private void bt_VisualArts_Click(object sender, EventArgs e)
        {
            ServicesInfoForm choraleMusicForm = new ServicesInfoForm();
            ServicesInfoForm.Choice = "Visual";
            choraleMusicForm.ShowDialog();
        }
    }
}
