namespace Gradebook_Challenge
{
    internal class Program
    {
        struct Student {
            public string name;
            public int id;
            public string form_group;

            public Student(string namea, int ida, string fga) {
                name = namea;
                id = ida;
                form_group = fga;
            }
        }
        static void Main(string[] args)
        {
            const int mxstudents = 3;
            Student[] students = new Student[mxstudents];
            string[] subjects = {"English Language", "English Literature", "Mathematics", "Biology", "Chemistry", "Physics", "History", "Geography", "Religious Studies", "Spanish", "French", "Art & Design", "Business", "Computer Science", "Drama", "Food Preparation and Nutrition", "DT Graphics", "Music", "Physical Education", "DT Resistant Materials"};
            int mxsubjects = subjects.Length;
        }
    }
}
