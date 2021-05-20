using Object_2.Business_layer;
using Object_2.Data_access_layer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Object_2.Presentation_layer
{
    public partial class UserForm : Form
    {
        private UserList _users;
        private string _name;

        public UserForm(string name)
        {
            _name = name;
            InitializeComponent();

            Serializer<UserList> serializer = new Serializer<UserList>();
            _users = serializer.Deserialize();

            if (_users.Users.Select(x => x.Name).Contains(name))
            {
                var user = _users.Users.Where(x => x.Name == name).First();
                AgeBox.Value = user.Age;
                WeightBox.Value = (decimal)user.Weight;
                HeightBox.Value = (decimal)user.Height;
                ActivityBox.SelectedItem = user.DailyActivity.ToString();
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if(ActivityBox.SelectedItem == null)
            {
                MessageBox.Show("Select your daily activity");
                return;
            }
            User user = new User
            {
                Name = _name,
                Age = (int)AgeBox.Value,
                Weight = (double)WeightBox.Value,
                Height = (double)HeightBox.Value,
                DailyActivity = (Activity)Enum.Parse(typeof(Activity), ActivityBox.SelectedItem.ToString()),
            };

            if (!_users.Users.Select(x => x.Name).Contains(user.Name))
                _users.Users.Add(user);

            Serializer<UserList> serializer = new Serializer<UserList>();
            serializer.Serialize(_users);

            Hide();
            ProductForm form = new ProductForm(user);
            form.Show();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
