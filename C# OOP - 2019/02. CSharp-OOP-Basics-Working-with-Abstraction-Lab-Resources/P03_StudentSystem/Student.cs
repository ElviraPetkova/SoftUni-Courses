namespace P03_StudentSystem
{
    public class Student
    {
        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public double Grade { get; set; }

        public string Status()
        {
            string status = string.Empty;

            if (this.Grade >= 5.00)
            {
                status = "Excellent student.";
            }
            else if (this.Grade < 5.00 && this.Grade >= 3.50)
            {
                status = "Average student.";
            }
            else
            {
                status = "Very nice person.";
            }

            return status;
        }

        public override string ToString()
        {
            string info = $"{this.Name} is {this.Age} years old. {Status()}";

            return info;
        }

    }
}