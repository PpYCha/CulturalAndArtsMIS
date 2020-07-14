using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
