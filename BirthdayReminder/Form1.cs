using System;
using System.Windows.Forms;

namespace BirthdayReminder
{
    public partial class OverviewForm : Form
    {
        private PersonManager personManager = new PersonManager();

        public OverviewForm()
        {
            InitializeComponent();

            todayLabel.Text = DateTime.Now.ToLongDateString();
            peopleListBox.DataSource = personManager.People;

            RefreshNearest();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PersonForm personForm = new PersonForm(personManager);
            personForm.ShowDialog();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (peopleListBox.SelectedItem != null)
            {
                personManager.Remove((Person)peopleListBox.SelectedItem);
            }
        }
        private void RefreshNearest()
        {
            if (personManager.People.Count > 0)
            {
                Person nearest = personManager.FindNearest();
                int age = nearest.CalculateAge();
                if (DateTime.Today != nearest.Birthday)
                    age++;
                nearestLabel.Text = nearest.Name + " (" + age + " years old) in " + nearest.RemainingDays() + " days";
            }
            else
                nearestLabel.Text = "No people in list";
        }

        private void peopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (peopleListBox.SelectedItem != null)
            {
                Person selected = (Person)peopleListBox.SelectedItem;
                birthdayLabel.Text = selected.Birthday.ToLongDateString();
                ageLabel.Text = selected.CalculateAge().ToString();
                birthdayMonthCalendar.SelectionStart = selected.Birthday;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OverviewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
