using GYM_DAL;
using GYM_System.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_System
{
    public partial class Home : Form
    {
        private readonly GYMDbContext _dbContext;

        public Home(GYMDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AddUserControl(UserControl userControl)
        {
            pl_Containar.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pl_Containar.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btn_GetProduct_Click(object sender, EventArgs e)
        {
            TraineePage trainee = new TraineePage(_dbContext);
            AddUserControl(trainee);

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login(_dbContext);
            login.Show();
            this.Hide();
        }

    }
}
