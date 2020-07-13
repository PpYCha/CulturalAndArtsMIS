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
    public partial class ucEventAdd : UserControl
    {
        public ucEventAdd()
        {
            InitializeComponent();
        }

        private static ucEventAdd _instance;
        public static ucEventAdd Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEventAdd();
                return _instance;
            }
        }

        private void bt_AddEvent_Click(object sender, EventArgs e)
        {
            using (cAaMISContext ctx = new cAaMISContext())
            {
                var events = new YearListOfEvents
                {
                    DescriptionEvent = tb_DescriptionEvent.Text,
                    DateEvent = dateTimePicker_DateEvent.Value.Date
                };

                ctx.YearListOfEvents.Add(events);
                ctx.SaveChanges();
                MessageBox.Show("Event Added Succesfully");
                ClearText();
            }
        }

        private void ClearText()
        {
            tb_DescriptionEvent.Clear();
        }
    }
}
