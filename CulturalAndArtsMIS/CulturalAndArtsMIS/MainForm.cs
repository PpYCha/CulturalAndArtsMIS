using CulturalAndArtsMIS.Forms;
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

        public static string UserAccessLevel;

        private void MainForm_Load(object sender, EventArgs e)
        {
            customizeDesign();



            Opacity = 0;
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            DialogResult = DialogResult.OK;

            Opacity = 100;

            if (UserAccessLevel == "0")
            {
                bt_side_Add_Events.Visible = true;
                bt_Side_Accounts.Visible = true;
            }
            else
            {
                bt_side_Add_Events.Visible = false;
                bt_Side_Accounts.Visible = false;
            }

        }

        private void customizeDesign()
        {
            subPanel_side_Request.Visible = false;
            subPanel_side_Events.Visible = false;
            subPanel_side_Profile.Visible = false;
            subPanel_side_Report.Visible = false;
            panel_Body.Visible = false;
        }

        private void hideSubMenu()
        {
            if (subPanel_side_Request.Visible == true)
                subPanel_side_Request.Visible = false;

            if (subPanel_side_Events.Visible == true)
                subPanel_side_Events.Visible = false;

            if (subPanel_side_Profile.Visible == true)
                subPanel_side_Profile.Visible = false;

            if (subPanel_side_Report.Visible == true)
                subPanel_side_Report.Visible = false;
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
            if (!panel_Body.Controls.Contains(ucServicesMain.Instance))
            {
                panel_Body.Controls.Add(ucServicesMain.Instance);
                ucServicesMain.Instance.Dock = DockStyle.Fill;
            }
            else
            {

            }

            ucServicesMain.Instance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void bt_side_Profile_Click(object sender, EventArgs e)
        {
            showSubMenu(subPanel_side_Profile);
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

        private void bt_side_IPR_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucInternalRequest.Instance))
            {
                panel_Body.Controls.Add(ucInternalRequest.Instance);
                ucInternalRequest.Instance.Dock = DockStyle.Fill;
            }
            else
            {

            }

            ucInternalRequest.Instance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void bt_Side_AddStudentProfile_Click(object sender, EventArgs e)
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

        private void bt_Side_StudentList_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucStudentProfileList.Instance))
            {
                panel_Body.Controls.Add(ucStudentProfileList.Instance);
                ucStudentProfileList.Instance.Dock = DockStyle.Fill;
            }
            else
            {

            }

            ucStudentProfileList.Instance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void bt_side_EPR_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucExternalRequest.Instance))
            {
                panel_Body.Controls.Add(ucExternalRequest.Instance);
                ucExternalRequest.Instance.Dock = DockStyle.Fill;
            }
            else
            {

            }

            ucExternalRequest.Instance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void bt_Side_Accounts_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucAddUser.Instance))
            {
                panel_Body.Controls.Add(ucAddUser.Instance);
                ucAddUser.Instance.Dock = DockStyle.Fill;
            }
            else
            {

            }

            ucAddUser.Instance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void bt_Side_Logout_Click(object sender, EventArgs e)
        {
            customizeDesign();

            Opacity = 0;
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            DialogResult = DialogResult.OK;

            Opacity = 100;

            if (UserAccessLevel == "0")
            {
                bt_side_Add_Events.Visible = true;
                bt_Side_Accounts.Visible = true;
            }
            else
            {
                bt_side_Add_Events.Visible = false;
                bt_Side_Accounts.Visible = false;
            }
        }

        private void bt_side_Reports_Click(object sender, EventArgs e)
        {
            showSubMenu(subPanel_side_Report);
        }

        private void bt_ExternalRPT_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!panel_Body.Controls.Contains(ucExternalListReport.Instance))
            {
                panel_Body.Controls.Add(ucExternalListReport.Instance);
                ucExternalListReport.Instance.Dock = DockStyle.Fill;
            }
            else
            {

            }

            ucExternalListReport.Instance.BringToFront();
            panel_Body.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void bt_Settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}
