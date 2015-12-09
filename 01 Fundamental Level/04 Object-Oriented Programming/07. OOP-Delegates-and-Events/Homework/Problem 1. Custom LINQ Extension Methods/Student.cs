namespace Problem_1.Custom_LINQ_Extension_Methods
{
    public class Student
    {
        public Student(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public string Name { get; set; }

        public int Grade { get; set; }
    }
}
