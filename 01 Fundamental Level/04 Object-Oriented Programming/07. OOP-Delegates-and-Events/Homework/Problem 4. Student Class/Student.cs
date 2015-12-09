namespace Problem_4.Student_Class
{
    public delegate void OnPropertyChangeEventHandler(Student student, PropertyChangedEventArgs args);

    public class Student
    {
        private string _name;
        private int _age;

        public event OnPropertyChangeEventHandler PropertyChanged;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Name", this._name, value));
                }

                this._name = value;
            }
        }

        public int Age
        {
            get
            {
                return this._age;
            }

            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Age", this._age, value));
                }

                this._age = value;
            }
        }
    }
}
