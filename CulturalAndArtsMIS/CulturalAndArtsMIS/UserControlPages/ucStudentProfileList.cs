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
using CulturalAndArtsMIS.Forms;

namespace CulturalAndArtsMIS.UserControlPages
{
    public partial class ucStudentProfileList : UserControl
    {
        public ucStudentProfileList()
        {
            InitializeComponent();
        }

        private static ucStudentProfileList _instance;
        public static ucStudentProfileList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucStudentProfileList();
                return _instance;
            }
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            using (cAaMISContext ctx = new cAaMISContext())
            {
                dataGridView_ListStudentProfile.DataSource = ctx.StudentProfile.Select
                    (p => new { 
                        //Part 1
                        p.studentProfile_ID, 
                        p.Name,
                        p.NickName,
                        p.Course,
                        p.Year,
                        p.CellphoneNo,
                        p.EmailAddress,
                        p.BirthDate,
                        p.Age,
                        p.HomeAddress,
                        p.CampusAddress,
                        //Part 2
                        p.HavePerformed,
                        p.HaveTrainings,
                        p.HaveExperience,
                        p.CanAttend,
                        p.Commuter,
                        p.Skills,
                        p.Finance,
                        //Part 3
                        p.FolkDance,
                        p.HipHop,
                        p.Contemporary,
                        p.Theater,
                        p.LiteraryArts,
                        p.RadioTalents,
                        p.ManagementTechnical,
                        p.Chorale,
                        p.LiveBand,
                        p.RondallaBand,
                        p.PaintingDrawing,
                        p.MakeUp,
                        p.Photography,
                        p.Multimedia
                    }).ToList();
            }

            this.dataGridView_ListStudentProfile.Columns["studentProfile_ID"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["NickName"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["Course"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["Year"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["CellphoneNo"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["EmailAddress"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["BirthDate"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["Age"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["HomeAddress"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["CampusAddress"].Visible = false;

            this.dataGridView_ListStudentProfile.Columns["HavePerformed"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["HaveTrainings"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["HaveExperience"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["CanAttend"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["Commuter"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["Skills"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["Finance"].Visible = false;

            this.dataGridView_ListStudentProfile.Columns["FolkDance"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["HipHop"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["Contemporary"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["Theater"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["LiteraryArts"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["RadioTalents"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["ManagementTechnical"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["Chorale"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["LiveBand"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["RondallaBand"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["PaintingDrawing"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["MakeUp"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["Photography"].Visible = false;
            this.dataGridView_ListStudentProfile.Columns["Multimedia"].Visible = false;

            this.dataGridView_ListStudentProfile.Columns["Name"].HeaderText = "Name";
       
        }

        private void dataGridView_ListStudentProfile_DoubleClick(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
     
            ProfileForm.dgvr = dataGridView_ListStudentProfile;
            profileForm.ShowDialog();
        }
    }
}
