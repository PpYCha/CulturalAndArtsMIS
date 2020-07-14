using CulturalAndArtsMIS.UserControlPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulturalAndArtsMIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            customizeDesign();
        }

        private void customizeDesign()
        {
            subPanel_side_Request.Visible = false;
            subPanel_side_Events.Visible = false;
        }

        private void hideSubMenu()
        {
            if (subPanel_side_Request.Visible == true)
                subPanel_side_Request.Visible = false;

            if (subPanel_side_Events.Visible == true)
                subPanel_side_Events.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else

                subMenu.Visible = false;

        }

        private void bt_side_Request_Click(object sender, EventArgs e)
        {
            showSubMenu(subPanel_side_Request);
        }

        private void bt_side_Services_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucServices.Instance))
            {
                panel_Body.Controls.Add(ucServices.Instance);
                ucServices.Instance.Dock = DockStyle.Fill;
            }
            else
            {

            }

            ucServices.Instance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void bt_side_Profile_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucRecruitmentForm.Instance))
            {
                panel_Body.Controls.Add(ucRecruitmentForm.Instance);
                ucRecruitmentForm.Instance.Dock = DockStyle.Fill;
            }
            else
            {

            }

            ucRecruitmentForm.Instance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void bt_side_Events_Click(object sender, EventArgs e)
        {
            showSubMenu(subPanel_side_Events);
        }

        private void bt_side_Add_Events_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucEventAdd.Instance))
            {
                panel_Body.Controls.Add(ucEventAdd.Instance);
                ucEventAdd.Instance.Dock = DockStyle.Fill;
            }
            else
            {

            }

            ucEventAdd.Instance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void bt_side_Year_Events_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucYearListofEvents.Instance))
            {
                panel_Body.Controls.Add(ucYearListofEvents.Instance);
                ucYearListofEvents.Instance.Dock = DockStyle.Fill;
            }
            else
            {

            }

            ucYearListofEvents.Instance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }
    }
}
