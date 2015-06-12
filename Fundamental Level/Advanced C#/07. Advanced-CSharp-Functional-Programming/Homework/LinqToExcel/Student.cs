//  Create a class Student that holds all aforementioned data fields from the file.
//  Add a field Result and a method CalculateResult() that calculates the total course result of a student using the formula
//  (exam result + homework sent + homework evaluated + teamwork + attendances + bonus) / 5.

namespace LinqToExcel
{
    public class Student
    {
        public Student(int id, string firstName, string lastName, string email, string gender, string studentType, double examResult, double homeworkSent, double homeworkEvaluated, double teamworkScore, double attendancesCount, double bonus)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Gender = gender;
            this.StudentType = studentType;
            this.ExamResult = examResult;
            this.HomeworkSent = homeworkSent;
            this.HomeworkEvaluated = homeworkEvaluated;
            this.TeamworkScore = teamworkScore;
            this.AttendancesCount = attendancesCount;
            this.Bonus = bonus;
            this.Result = (examResult + homeworkSent + homeworkEvaluated + teamworkScore + attendancesCount + bonus) / 5;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string StudentType { get; set; }
        public double ExamResult { get; set; }
        public double HomeworkSent { get; set; }
        public double HomeworkEvaluated { get; set; }
        public double TeamworkScore { get; set; }
        public double AttendancesCount { get; set; }
        public double Bonus { get; set; }
        public double Result { get; set; }
    }
}