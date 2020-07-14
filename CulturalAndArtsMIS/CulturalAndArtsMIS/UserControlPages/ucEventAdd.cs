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
    }
}
