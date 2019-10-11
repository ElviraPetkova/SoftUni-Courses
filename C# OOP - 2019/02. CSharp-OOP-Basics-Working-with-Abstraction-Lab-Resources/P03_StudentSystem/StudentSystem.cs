namespace P03_StudentSystem
{
    using System.Collections.Generic;

    public class StudentSystem
    {
        private Dictionary<string, Student> information;

        public StudentSystem()
        {
            this.information = new Dictionary<string, Student>();
        }

        public void Add(string name, int age, double grade)
        {
            if (!information.ContainsKey(name))
            {
                Student student = new Student(name, age, grade);
                this.information[name] = student;
            }
        }

        public Student Show(string name)
        {
            if (this.information.ContainsKey(name))
            {
                Student student = this.information[name];

                return student;
            }

            return null;
        }

    }
}
