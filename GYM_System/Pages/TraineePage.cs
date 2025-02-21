using GYM_BLL;
using GYM_DAL;
using GYM_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_System.Pages
{
    public partial class TraineePage : UserControl
    {
        private readonly GYMDbContext _dbContext;
        private readonly TraineeRepository _traineeRepository;
        private readonly TypeOfExerciseRepository _typeOfExerciseRepo;

        public TraineePage(GYMDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _traineeRepository = new TraineeRepository(dbContext);
            _typeOfExerciseRepo = new TypeOfExerciseRepository(dbContext);
        }

        private void TraineePage_Load(object sender, EventArgs e)
        {
            var trainees = _traineeRepository.GetAll();
            dgv_Trainee.DataSource = trainees;
            dgv_Trainee.Columns["Id"].Visible = false;
            dgv_Trainee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var typeOfExercise = _typeOfExerciseRepo.GetAll();
            cmb_Category.DataSource = typeOfExercise;
            cmb_Category.DisplayMember = "Type";
            cmb_Category.ValueMember = "Id";
            btn_AddTrainee.Visible = true;
            btn_DeleteTrainee.Visible = false;
            btn_UpdateTrainee.Visible = false;
        }
    }
}
