using System;
using System.ComponentModel;
using System.Linq;

namespace BirthdayReminder
{
    public class PersonManager
    {
        public BindingList<Person> People { get; set; }

        public PersonManager()
        {
            People = new BindingList<Person>();
        }
        public void Add(string name, DateTime birthday)
        {
            if (name.Length < 3)
                throw new ArgumentException("Name is too short");
            if (birthday.Date > DateTime.Today)
                throw new ArgumentException("Birthday must not be in future");
            Person person = new Person(name, birthday.Date);
            People.Add(person);
        }
        public void Remove(Person person)
        {
            People.Remove(person);
        }
        public Person FindNearest()
        {
            var sortedPeople = People.OrderBy(p => p.RemainingDays());
            return sortedPeople.First();
        }
    }
}
