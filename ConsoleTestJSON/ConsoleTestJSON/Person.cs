namespace TestJSON
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        //Parameterless constructor, needed for serialization
        public Person() {}

        public override string ToString()
        {
            return string.Format("First Name: {0}\nLast Name: {1}\nAge:{2}", 
                this.FirstName, this.LastName, this.Age);
        }
    }
}
