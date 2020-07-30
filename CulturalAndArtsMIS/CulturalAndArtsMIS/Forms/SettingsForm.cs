using CulturalAndArtsMIS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulturalAndArtsMIS.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            using (cAaMISContext ctx = new cAaMISContext())
            {
                if (!(ctx.Setting.Any()))
                {
                    var namess = new Setting
                    {
                        ApproveBy = tb_ApproveBy.Text,
                        NotedBy = tb_NotedBy.Text
                    };
                    ctx.Setting.Add(namess);
                    ctx.SaveChanges();
                }
                else
                {
                    var namess = ctx.Setting.First<Setting>();
                    namess.setting_ID = 1;
                    namess.ApproveBy = tb_ApproveBy.Text;
                    namess.NotedBy = tb_NotedBy.Text;
                    ctx.SaveChanges();
                }

            }
            MessageBox.Show("Report Settings Save Succesfully");
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

            using (cAaMISContext ctx = new cAaMISContext())
            {
                tb_ApproveBy.Text = ctx.Setting.Select(x => x.ApproveBy).Single();
                tb_NotedBy.Text = ctx.Setting.Select(x => x.NotedBy).Single();
            }

        }
    }
}
