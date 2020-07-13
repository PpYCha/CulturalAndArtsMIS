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
    }
}
