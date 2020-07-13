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
    public partial class ucServices : UserControl
    {
        public ucServices()
        {
            InitializeComponent();
        }

        private static ucServices _instance;
        public static ucServices Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucServices();
                return _instance;
            }
        }
    }
}
