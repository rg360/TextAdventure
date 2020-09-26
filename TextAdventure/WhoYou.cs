using System;
namespace TextAdventure
{
    public class WhoYou
    {
        public WhoYou()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public WhoYou(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


    }
}
