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
    public partial class ucInternalRequest : UserControl
    {
        public ucInternalRequest()
        {
            InitializeComponent();
        }

        private static ucInternalRequest _instance;
        public static ucInternalRequest Instance 
        {
            get
            {
                if (_instance == null)
                    _instance = new ucInternalRequest();
                return _instance;
            }
        }
    }
}
