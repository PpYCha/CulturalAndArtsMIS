using CulturalAndArtsMIS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulturalAndArtsMIS.ServicesForms
{
    public partial class ServicesInfoForm : Form
    {
        public ServicesInfoForm()
        {
            InitializeComponent();
        }

        public static string Choice;

        private void ServicesInfoForm_Load(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void LoadMemberList()
        {
            if (Choice == "Chorale")
            {

                label_Title.Text = "Chorale Music";
                label_History.Text = "Chorale is the name of several related musical forms originating in the music genre of the Lutheran chorale: ... Such a tune presented in a homophonic or homorhythmic harmonisation, usually four-part harmony (e.g. Bach's four-part chorales, or the chorale included in the second movement of Mahler's Fifth Symphony)";
                using (cAaMISContext ctx = new cAaMISContext())
                {
                    dataGridView_ListOfMembers.DataSource = ctx.StudentProfile.Where(x => x.Chorale == true).Select(p => new { p.Name }).ToList();
                }
            }
            else if (Choice == "Live")
            {
                label_Title.Text = "Liveband Music";
                label_History.Text = "Original lead singer Ed Kowalczyk is sued for $2 million for continuing to use the band name after leaving the group in 2009. ... Each member of Live has an equal share of the company, according to a lawsuit filed in New York federal court. Kowalczyk left the band in 2009 as a new vocalist (Chris Shinn) came in.";
                using (cAaMISContext ctx = new cAaMISContext())
                {
                    dataGridView_ListOfMembers.DataSource = ctx.StudentProfile.Where(x => x.LiveBand == true).Select(p => new { p.Name }).ToList();
                }
            }
            else if (Choice == "Rondalla")
            {
                label_Title.Text = "Rondalla Music";
                label_History.Text = "The rondallah has its origins in the folk playing bands from Spain that were forerunners of the present-day rondallah and included four types: groups of young men who played and sang regularly in front of homes, bands of musicians known as murza or murga who begged for alms, a group of musicians known as comparza who played on stage, and groups of university musicians known as estudiantina, dubbed “tuna”. The usual musical instruments used by estudiantina members were mandolins, violins, guitars, flutes, cellos, basses, tambourines, castanets, and triangles. Estudiantina musicians in Spain and Mexico, before and during the age of musical romanticism, wore 16th century attire such as " + "short velvet breeches, ornate shirts and a short cape with multicolored ribbons.";
                using (cAaMISContext ctx = new cAaMISContext())
                {
                    dataGridView_ListOfMembers.DataSource = ctx.StudentProfile.Where(x => x.RondallaBand == true).Select(p => new { p.Name }).ToList();
                }
            }
            else if (Choice == "Dance")
            {
                label_Title.Text = "Folkdance/Hip Hop";
                label_History.Text = "First archeological proof of dance comes from the 9 thousand year old cave paintings in India.One of the earliest uses of structured dance was introduced in religious ceremonies that told the stories of ancient myths and gods. ... Modern dance history in Europe started with Renaissance, when many new dances were invented.";
                using (cAaMISContext ctx = new cAaMISContext())
                {
                    dataGridView_ListOfMembers.DataSource = ctx.StudentProfile.Where(x => x.FolkDance == true || x.HipHop == true).Select(p => new { p.Name }).ToList();
                }
            }
            else if (Choice == "Theatre")
            {
                label_Title.Text = "Theatre Arts";
                label_History.Text = "In fact, the history of theater can be traced back to 6th Century B.C. where the Ancient Greeks were the first to present dramatic presentations. One of the most popular forms of entertainment for people is a visit to the theater. For centuries people have enjoyed drama, comedy, music, and other forms of entertainment.";
                using (cAaMISContext ctx = new cAaMISContext())
                {
                    dataGridView_ListOfMembers.DataSource = ctx.StudentProfile.Where(x => x.Theater == true).Select(p => new { p.Name }).ToList();
                }
            }
            else if (Choice == "Visual")
            {
                label_Title.Text = "Visual Arts";
                label_History.Text = "The Baroque started after the Renaissance, from the late 16th century to the late 17th century. Main artists of the Baroque included Caravaggio, who made heavy use of tenebrism.";
                using (cAaMISContext ctx = new cAaMISContext())
                {
                    dataGridView_ListOfMembers.DataSource = ctx.StudentProfile.Where(x => x.PaintingDrawing == true || x.MakeUp == true || x.Photography == true || x.Multimedia == true).Select(p => new { p.Name }).ToList();
                }
            }
        }
    }
}
