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
    public partial class ucRecruitmentForm : UserControl
    {
        public ucRecruitmentForm()
        {
            InitializeComponent();
        }


        private static ucRecruitmentForm _instance;
        public static ucRecruitmentForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucRecruitmentForm();
                return _instance;
            }
        }

        private void bt_SaveStudentProfile_Click(object sender, EventArgs e)
        {
            try
            {


            using (cAaMISContext ctx = new cAaMISContext())
            {
                var studentProfile = new StudentProfile
                {
                    //Part 1
                    Name = tb_Name.Text,
                    NickName = tb_NickName.Text,
                    Course = tb_Course.Text,
                    Year = tb_Year.Text,
                    CellphoneNo = tb_CellphoneNo.Text,
                    EmailAddress = tb_EmaillAddress.Text,
                    BirthDate = dateTimePicker_BirthDate.Value.Date,
                    Age = Convert.ToInt32(tb_Age.Text),
                    HomeAddress = tb_HomeAddress.Text,
                    CampusAddress = tb_CampusAddress.Text,

                    //Part 2
                    HavePerformed = cb_HavePerformed.Checked,
                    HaveTrainings = cb_HaveTraining.Checked,
                    HaveExperience = cb_HaveTraining.Checked,
                    CanAttend = cb_CanAttend.Checked,
                    Commuter = cb_Commuter.Checked,
                    Skills = tb_Skills.Text,
                    Finance = tb_Finance.Text,

                    //Part 3
                    FolkDance = cb_FolkDance.Checked,
                    HipHop = cb_HipHop.Checked,
                    Contemporary = cb_Contemporary.Checked,
                    Theater = cb_Theater.Checked,
                    LiteraryArts = cb_LiteraryArts.Checked,
                    RadioTalents = cb_RadioTalents.Checked,
                    ManagementTechnical = cb_ManagementTechnical.Checked,
                    Chorale = cb_Chorale.Checked,
                    LiveBand = cb_LiveBand.Checked,
                    RondallaBand = cb_RondallaBand.Checked,
                    PaintingDrawing = cb_PaintingDrawing.Checked,
                    MakeUp = cb_MakeUp.Checked,
                    Photography = cb_Photography.Checked,
                    Multimedia = cb_Multimedia.Checked,

                };
                ctx.StudentProfile.Add(studentProfile);
                ctx.SaveChanges();
                MessageBox.Show("Student Profile Save Successfully");
                ClearText();
            
        }
            }
            catch (Exception)
            {


            }
        }

        private void ClearText()
        {
            tb_Name.Clear();
            tb_NickName.Clear();
            tb_Course.Clear();
            tb_Year.Clear();
            tb_CellphoneNo.Clear();
            tb_EmaillAddress.Clear();
            tb_Age.Clear();
            tb_HomeAddress.Clear();
            tb_CampusAddress.Clear();
            tb_Skills.Clear();
            tb_Finance.Clear();

            cb_HavePerformed.Checked = false;
            cb_HaveTraining.Checked = false;
            cb_HaveExperience.Checked = false;
            cb_CanAttend.Checked = false;
            cb_Commuter.Checked = false;
            cb_FolkDance.Checked = false;
            cb_HipHop.Checked = false;
            cb_Contemporary.Checked = false;
            cb_Theater.Checked = false;
            cb_LiteraryArts.Checked = false;
            cb_RadioTalents.Checked = false;
            cb_ManagementTechnical.Checked = false;
            cb_Chorale.Checked = false;
            cb_LiveBand.Checked = false;
            cb_RondallaBand.Checked = false;
            cb_PaintingDrawing.Checked = false;
            cb_MakeUp.Checked = false;
            cb_Photography.Checked = false;
            cb_Multimedia.Checked = false;
        }

      
    }
}
