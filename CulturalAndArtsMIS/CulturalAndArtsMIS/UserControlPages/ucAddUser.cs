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
    public partial class ucAddUser : UserControl
    {
        public ucAddUser()
        {
            InitializeComponent();
        }

        private string tempId_UserList;

        public static ucAddUser _instance;
        public static ucAddUser  Instance
            { get
            {
                if (_instance == null)
                    _instance = new ucAddUser();
                return _instance;
            } 
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {

            string test = cb_Role.SelectedIndex.ToString();

                if (tb_Password.Text == tb_ReTypePassword.Text && !(string.IsNullOrEmpty(tb_Username.Text)))
                {
                    if ((string.IsNullOrEmpty(tempId_UserList)))
                    {
                        using (cAaMISContext ctx = new cAaMISContext())
                        {

                        var userAccount = new UserAccount
                        {
                            UserName = tb_Username.Text,
                            Password = tb_Password.Text,
                            FirstName = tb_FirstName.Text,
                            MiddleName = tb_MiddleName.Text,
                            LastName = tb_LastName.Text,
                            IsActive = true,
                            Role = cb_Role.SelectedIndex.ToString()
                            };
                            ctx.UserAccount.Add(userAccount);
                            ctx.SaveChanges();
                            LoadUserList();
                        MessageBox.Show("User Added Succesfully");
                        ClearText();
                        }
                    }
                else
                {
                    using (cAaMISContext ctx = new cAaMISContext())
                    {
                        int tempId = Convert.ToInt32(tempId_UserList);
                        UserAccount userAccount = ctx.UserAccount.Where(x => x.ua_ID == tempId).FirstOrDefault();
                        userAccount.UserName = tb_Username.Text;
                        userAccount.Password = tb_Password.Text;
                        userAccount.FirstName = tb_FirstName.Text;
                        userAccount.MiddleName = tb_MiddleName.Text;
                        userAccount.LastName = tb_LastName.Text;
                        userAccount.IsActive = Convert.ToBoolean(dataGridView_UserList.SelectedRows[0].Cells[6].Value.ToString());
                        userAccount.Role = cb_Role.SelectedIndex.ToString();
                        ctx.SaveChanges();
                        LoadUserList();
                        MessageBox.Show("Update Successfully");
                        ClearText();
                    }

                }
                 }
            else
            {
                MessageBox.Show("Dont leave blank the fields");
            }
        }

        private void ClearText()
        {
            tempId_UserList = null;
            tb_Username.Clear();
            tb_ReTypePassword.Clear();
            tb_Password.Clear();
            tb_FirstName.Clear();
            tb_MiddleName.Clear();
            tb_LastName.Clear();
            cb_Role.SelectedIndex = -1;
        }

        private void ucAddUser_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }

        private void LoadUserList()
        {
            using (cAaMISContext ctx = new cAaMISContext())
            {
                dataGridView_UserList.DataSource = ctx.UserAccount.Where(x => x.IsActive == true).ToList();
                customDesignDataGrid();
            }
        }

        private void customDesignDataGrid()
        {
            this.dataGridView_UserList.Columns["ua_ID"].Visible = false;
            this.dataGridView_UserList.Columns["UserName"].HeaderText = "Username";
            this.dataGridView_UserList.Columns["UserName"].ReadOnly = true;
            this.dataGridView_UserList.Columns["Password"].Visible = false;
            this.dataGridView_UserList.Columns["FirstName"].Visible = false;
            this.dataGridView_UserList.Columns["MiddleName"].Visible = false;
            this.dataGridView_UserList.Columns["LastName"].Visible = false;
            this.dataGridView_UserList.Columns["Role"].Visible = false;
        }

        private void dataGridView_UserList_DoubleClick(object sender, EventArgs e)
        {
            tempId_UserList = dataGridView_UserList.SelectedRows[0].Cells[0].Value.ToString();
            tb_Username.Text = dataGridView_UserList.SelectedRows[0].Cells[1].Value.ToString();
            tb_ReTypePassword.Text = dataGridView_UserList.SelectedRows[0].Cells[2].Value.ToString();
            tb_Password.Text = dataGridView_UserList.SelectedRows[0].Cells[2].Value.ToString();
            tb_FirstName.Text = dataGridView_UserList.SelectedRows[0].Cells[3].Value.ToString();
            tb_MiddleName.Text = dataGridView_UserList.SelectedRows[0].Cells[4].Value.ToString();
            tb_LastName.Text = dataGridView_UserList.SelectedRows[0].Cells[5].Value.ToString();
           cb_Role.SelectedIndex = Convert.ToInt32(dataGridView_UserList.SelectedRows[0].Cells[7].Value.ToString());
        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
            tb_Password.UseSystemPasswordChar = true;
        }

        private void tb_ReTypePassword_Enter(object sender, EventArgs e)
        {
            tb_ReTypePassword.UseSystemPasswordChar = true;
        }
    }
}
