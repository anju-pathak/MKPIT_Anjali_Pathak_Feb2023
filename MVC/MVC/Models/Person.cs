namespace MVC.Models
{
    public class Person
    {
        public string name;
        public int age;
        //constructor
        public Person(string a, int b)
        {
            name = a;
            age = b;

        }
        //creating property named Name and Age
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Age
        {
            get
            { return age; }
        }

    }
}


