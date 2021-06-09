using System;
using System.Windows.Forms;

namespace BirthdayReminder
{
    public partial class PersonForm : Form
    {
        private PersonManager personManager;

        public PersonForm(PersonManager personManager)
        {
            InitializeComponent();
            this.personManager = personManager;
        }

        public PersonForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                personManager.Add(nameTextBox.Text, birthdayDateTimePicker.Value);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void PersonForm_Load(object sender, EventArgs e)
        {

        }
    }
}
