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
            int[,] grades = new int[mxstudents, mxsubjects];
            while (true) {
                Console.WriteLine("Options");
                Console.WriteLine("1 for Add a Student.");
                Console.WriteLine("2 for Enter grades for a Student.");
                Console.WriteLine("3 for View all Student Grades.");
                Console.WriteLine("0 for Quit.");
                string? choice = Console.ReadLine()?.Trim();
                switch (choice) {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "0":
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}
