using System;

namespace BirthdayReminder
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public Person(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(age))
                age--;
            return age;
        }

        public int RemainingDays()
        {
            DateTime today = DateTime.Today;
            DateTime nextBirthday = Birthday.AddYears(CalculateAge() + 1);

            TimeSpan difference = nextBirthday - DateTime.Today;

            return Convert.ToInt32(difference.TotalDays);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
