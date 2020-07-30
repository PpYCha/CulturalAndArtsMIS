using CulturalAndArtsMIS.Models;
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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        public static string studentProfile_ID;
        public static DataGridView dgvr;

        private void ProfileForm_Load(object sender, EventArgs e)
        {

            tb_Name.Text = dgvr.SelectedRows[0].Cells[1].Value.ToString();
            tb_NickName.Text = dgvr.SelectedRows[0].Cells[2].Value.ToString();
            tb_Course.Text = dgvr.SelectedRows[0].Cells[3].Value.ToString();
            tb_Year.Text = dgvr.SelectedRows[0].Cells[4].Value.ToString();
            tb_CellphoneNo.Text = dgvr.SelectedRows[0].Cells[5].Value.ToString();
            tb_EmaillAddress.Text = dgvr.SelectedRows[0].Cells[6].Value.ToString();
           // dateTimePicker_BirthDate.Value = dgvr.SelectedRows[0].Cells[7].Value;
           tb_Age.Text = dgvr.SelectedRows[0].Cells[8].Value.ToString();
            tb_HomeAddress.Text = dgvr.SelectedRows[0].Cells[9].Value.ToString();
            tb_CampusAddress.Text = dgvr.SelectedRows[0].Cells[10].Value.ToString();

            cb_HavePerformed.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[11].Value);
            cb_HaveTraining.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[12].Value);
            cb_HaveExperience.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[13].Value);
            cb_CanAttend.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[14].Value);
            cb_Commuter.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[15].Value);
            tb_Skills.Text = dgvr.SelectedRows[0].Cells[16].Value.ToString();
            tb_Finance.Text = dgvr.SelectedRows[0].Cells[17].Value.ToString();

            cb_FolkDance.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[18].Value);
            cb_HipHop.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[18].Value);
            cb_Contemporary.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[19].Value);
            cb_Theater.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[20].Value);
            cb_LiteraryArts.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[21].Value);
            cb_RadioTalents.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[22].Value);
            cb_ManagementTechnical.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[23].Value);
            cb_Chorale.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[24].Value);
            cb_LiveBand.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[25].Value);
            cb_RondallaBand.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[26].Value);
            cb_PaintingDrawing.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[27].Value);
            cb_MakeUp.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[28].Value);
            cb_Photography.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[29].Value);
            cb_Multimedia.Checked = Convert.ToBoolean(dgvr.SelectedRows[0].Cells[30].Value);
        }
    }
}
