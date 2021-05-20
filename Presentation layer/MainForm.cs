using Object_2.Presentation_layer;
using System.Windows.Forms;

namespace Object_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NameButton_Click(object sender, System.EventArgs e)
        {
            if(NameBox.Text == "")
            {
                MessageBox.Show("Fill the info");
                return;
            }
            Hide();
            UserForm form = new UserForm(NameBox.Text);
            form.Show();
        }
    }
}
