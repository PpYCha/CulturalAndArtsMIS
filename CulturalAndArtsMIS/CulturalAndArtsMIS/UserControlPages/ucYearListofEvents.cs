using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;
using CulturalAndArtsMIS.Models;

namespace CulturalAndArtsMIS.UserControlPages
{
    public partial class ucYearListofEvents : UserControl
    {
        public ucYearListofEvents()
        {
            InitializeComponent();
        }

        private static ucYearListofEvents _instance;
        public static ucYearListofEvents Instance 
        {
            get
            {
                if (_instance == null)
                    _instance = new ucYearListofEvents();
                return _instance;
            }
        }

        private void ucYearListofEvents_Load(object sender, EventArgs e)
        {
          
            using (cAaMISContext ctx = new cAaMISContext())
            {
                dataGridView_ListOfEvents.DataSource = ctx.YearListOfEvents.ToList();
            }
            this.dataGridView_ListOfEvents.Columns["yearListOfEvents_ID"].Visible = false;
            this.dataGridView_ListOfEvents.Columns["DescriptionEvent"].HeaderText = "Event Desciption";
            this.dataGridView_ListOfEvents.Columns["DateEvent"].HeaderText = "Date of Event";
        }
    }
}
