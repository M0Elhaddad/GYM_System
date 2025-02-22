using GYM_BLL;
using GYM_DAL;
using GYM_DAL.Entities;
using Microsoft.IdentityModel.Tokens;


namespace GYM_System.Pages
{
    public partial class AddUpdateTrainee : UserControl
    {
        private readonly GYMDbContext _dbContext;
        private readonly TraineeRepository _traineeRepository;
        private readonly TypeOfExerciseRepository _typeOfExerciseRepo;
        private readonly TypeOfSubscriptionRepository _typeOfSubscriptionRepo;
        int SelectedId = -1;
        public AddUpdateTrainee(int Id, GYMDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _traineeRepository = new TraineeRepository(dbContext);
            _typeOfExerciseRepo = new TypeOfExerciseRepository(dbContext);
            _typeOfSubscriptionRepo = new TypeOfSubscriptionRepository(dbContext);
            SelectedId = Id;
        }

        private void AddUpdateTrainee_Load(object sender, EventArgs e)
        {
            var exercise = _typeOfExerciseRepo.GetAll();
            cmb_Exercise.DataSource = exercise;
            cmb_Exercise.DisplayMember = "Type";
            cmb_Exercise.ValueMember = "Id";
            var subscribe = _typeOfSubscriptionRepo.GetAll();
            cmb_Subscribtion.DataSource = subscribe;
            cmb_Subscribtion.DisplayMember = "Type";
            cmb_Subscribtion.ValueMember = "Id";

            if (SelectedId > 0) //update
            {
                lab_Type.Text = "Update Trainee";
                btn_Add.Visible = false;
                btn_Update.Visible = true;
                var trainee = _traineeRepository.Get(SelectedId);
                if (trainee != null)
                {
                    txt_TraineeName.Text = trainee.Name;
                    txt_Age.Text = trainee.Age.ToString();
                    txt_Phone.Text = trainee.Phone.ToString();
                    dt_Subscription.Value = trainee.DateOfSubscription;
                    dt_Expire.Value = trainee.DateOfExpire;
                    cmb_Exercise.SelectedValue = trainee.TypeOfExerciseId;
                    cmb_Subscribtion.SelectedValue = trainee.TypeOfSubscriptionId;
                }
            }
            else //insert
            {
                lab_Type.Text = "Add Trainee";
                btn_Add.Visible = true;
                btn_Update.Visible = false;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_TraineeName.Text != "" && txt_Age.Text != "" && txt_Phone.Text != "" && cmb_Exercise.SelectedValue != null && cmb_Subscribtion != null)
            {
                if (dt_Expire.Value > dt_Subscription.Value )
                {
                    Trainee trainee = new Trainee()
                    {
                        Name = txt_TraineeName.Text,
                        Age = int.Parse(txt_Age.Text),
                        Phone = int.Parse(txt_Phone.Text),
                        DateOfExpire = dt_Expire.Value,
                        DateOfSubscription = dt_Subscription.Value,
                        TypeOfExerciseId = Convert.ToInt32(cmb_Exercise.SelectedValue),
                        TypeOfSubscriptionId = Convert.ToInt32(cmb_Subscribtion.SelectedValue)
                    };
                    int result = _traineeRepository.Add(trainee);
                    if (result > 0)
                        MessageBox.Show("Product Add SuccessFully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("The Date of expire Must be Grater than or Equal Date of Subscribe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
                txt_TraineeName.Text = "";
                txt_Age.Text = "";
                txt_Phone.Text = "";
            }
            else
                MessageBox.Show("Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_TraineeName.Text != "" && txt_Age.Text != "" && txt_Phone.Text != "" && cmb_Exercise.SelectedValue != null && cmb_Subscribtion.SelectedValue != null)
            {
                Trainee? trainee = _traineeRepository.Get(SelectedId);
                if (trainee is not null && dt_Expire.Value > dt_Subscription.Value)
                {
                    trainee.Id = SelectedId;
                    trainee.Name = txt_TraineeName.Text;
                    trainee.Age = int.Parse(txt_Age.Text);
                    trainee.Phone = int.Parse(txt_Phone.Text);
                    trainee.DateOfExpire = dt_Expire.Value;
                    trainee.DateOfSubscription = dt_Subscription.Value;
                    trainee.TypeOfExerciseId = Convert.ToInt32(cmb_Exercise.SelectedValue);
                    trainee.TypeOfSubscriptionId = Convert.ToInt32(cmb_Subscribtion.SelectedValue);

                    int result = _traineeRepository.Update(trainee);
                    if (result > 0)
                        MessageBox.Show("Product Updated SuccessFully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    btn_Add.Visible = true;
                    btn_Update.Visible = false;
                    txt_TraineeName.Text = "";
                    txt_Age.Text = "";
                    txt_Phone.Text = "";
                }
            }
            else
              MessageBox.Show("Enter Valid Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void txt_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_TraineeName_Leave(object sender, EventArgs e)
            => name_validation.Text = txt_TraineeName.Text.IsNullOrEmpty() ? "Field is Required" : "";

        private void txt_TraineeName_KeyUp(object sender, KeyEventArgs e)
            => name_validation.Text = txt_TraineeName.Text.IsNullOrEmpty() ? "Field is Required" : "";

        private void txt_Age_Leave(object sender, EventArgs e)
            => age_validation.Text = txt_Age.Text.IsNullOrEmpty() ? "Field is Required" : "";


        private void txt_Age_KeyUp(object sender, KeyEventArgs e)
            => age_validation.Text = txt_Age.Text.IsNullOrEmpty() ? "Field is Required" : "";


        private void txt_Phone_Leave(object sender, EventArgs e)
            => phone_validation.Text = txt_Phone.Text.IsNullOrEmpty() ? "Field is Required" : "";


        private void txt_Phone_KeyUp(object sender, KeyEventArgs e)
            => phone_validation.Text = txt_Phone.Text.IsNullOrEmpty() ? "Field is Required" : "";


    }
}
