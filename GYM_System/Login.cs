using GYM_BLL;
using GYM_DAL;
using GYM_DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GYM_System
{
    public partial class Login : Form
    {
        private readonly AdminRepository _adminRepository;
        private readonly GYMDbContext _dbContext = new GYMDbContext();
        public Login()
        {
            InitializeComponent();
            _dbContext = new GYMDbContext();
            _adminRepository = new AdminRepository(_dbContext);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;
            string password = txt_Pass.Text;

            if (email != "" && password != "" && _adminRepository.GetAdminByEmail(email, password) != null)
            {
                _adminRepository.Dispose();
                Home home = new Home();
                home.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password !!");
            }
        }
    }
}
