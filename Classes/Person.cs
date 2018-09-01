using System;

namespace Classes
{
    public class Person
    {
        public string Name;
        public string Name1 { get; set; }
        private DateTime _birthdate;


        public Person(DateTime birthday)
        {
            Birthday = Birthday;
        }
        
        public DateTime Birthday { get; private set; }//readonly set, cant be change after set, set in Constructor

        public int Age
        {//doesn't make sense to have a set method
            get
            {
                var timeSpan = DateTime.Today - Birthday;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }//end Person class
}
