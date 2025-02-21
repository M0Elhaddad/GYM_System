using GYM_BLL;
using GYM_DAL;
using GYM_DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GYM_System
{
    public partial class Login : Form
    {
        private readonly AdminRepository _adminRepository;
        private readonly GYMDbContext _dbContext;

        public Login(GYMDbContext dbContext)
        {
            InitializeComponent();
            _adminRepository = new AdminRepository(dbContext);
            _dbContext = dbContext;
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
                Home home = new Home(_dbContext);
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
