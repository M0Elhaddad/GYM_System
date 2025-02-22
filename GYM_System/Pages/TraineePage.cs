using GYM_BLL;
using GYM_DAL;
using System.Data;

namespace GYM_System.Pages
{
    public partial class TraineePage : UserControl
    {
        private readonly GYMDbContext _dbContext;
        private readonly TraineeRepository _traineeRepository;
        private readonly TypeOfExerciseRepository _typeOfExerciseRepo;
        private readonly TypeOfSubscriptionRepository _typeOfSubscriptionRepo;
        private readonly new Panel Container;
        int SelectedId = -1;
        public TraineePage(GYMDbContext dbContext, Panel container)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _traineeRepository = new TraineeRepository(dbContext);
            _typeOfExerciseRepo = new TypeOfExerciseRepository(dbContext);
            _typeOfSubscriptionRepo = new TypeOfSubscriptionRepository(dbContext);
            Container = container;
        }

        private void TraineePage_Load(object sender, EventArgs e)
        {
            var trainees = _traineeRepository.GetAll();
            dgv_Trainee.DataSource = trainees;
            dgv_Trainee.Columns["Id"].Visible = false;
            dgv_Trainee.Columns["TypeOfSubscriptionId"].Visible = false;
            dgv_Trainee.Columns["TypeOfExerciseId"].Visible = false;
            dgv_Trainee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var typeOfExercise = _typeOfExerciseRepo.GetAll();
            cmb_Exercise.DataSource = typeOfExercise;
            cmb_Exercise.DisplayMember = "Type";
            cmb_Exercise.ValueMember = "Id";
            var typeOfSubscription = _typeOfSubscriptionRepo.GetAll();
            cmb_Subscription.DataSource = typeOfSubscription;
            cmb_Subscription.DisplayMember = "Type";
            cmb_Subscription.ValueMember = "Id";
            btn_AddTrainee.Visible = true;
            btn_DeleteTrainee.Visible = false;
            btn_UpdateTrainee.Visible = false;
        }

        private void AddUserControl(UserControl userControl)
        {
            Container.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            Container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void dgv_Trainee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow trainee = dgv_Trainee.SelectedRows[0];
            SelectedId = Convert.ToInt32(trainee.Cells["Id"].Value);
            btn_AddTrainee.Visible = false;
            btn_DeleteTrainee.Visible = true;
            btn_UpdateTrainee.Visible = true;
        }

        private void btn_DeleteTrainee_Click(object sender, EventArgs e)
        {
            DialogResult Sure = MessageBox.Show("Are You Sure To Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sure == DialogResult.Yes)
            {
                if (SelectedId > 0)
                {
                    var trainee = _traineeRepository.Get(SelectedId);
                    if (trainee != null)
                    {
                        int result = _traineeRepository.Delete(trainee);
                        if (result > 0)
                        {
                            MessageBox.Show("Trainee Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        TraineePage_Load(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("Trainee Not Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_AddTrainee_Click(object sender, EventArgs e)
        {
            AddUpdateTrainee addUpdateTrainee = new AddUpdateTrainee(SelectedId, _dbContext);
            AddUserControl(addUpdateTrainee);
        }

        private void btn_UpdateTrainee_Click(object sender, EventArgs e)
        {
            AddUpdateTrainee product = new AddUpdateTrainee(SelectedId, _dbContext);
            AddUserControl(product);
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            var SearchTable = _traineeRepository.GetTraineeByName(txt_Search.Text);
            dgv_Trainee.DataSource = SearchTable;
            dgv_Trainee.Columns["Id"].Visible = false;
            dgv_Trainee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void cmb_Exercise_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var tableProduct = _traineeRepository.GetTraineeByExercise(Convert.ToInt32(cmb_Exercise.SelectedValue));
            dgv_Trainee.DataSource = tableProduct;
            dgv_Trainee.Columns["Id"].Visible = false;
            dgv_Trainee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmb_Subscription_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var tableProduct = _traineeRepository.GetTraineeBySubscription(Convert.ToInt32(cmb_Subscription.SelectedValue));
            dgv_Trainee.DataSource = tableProduct;
            dgv_Trainee.Columns["Id"].Visible = false;
            dgv_Trainee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
