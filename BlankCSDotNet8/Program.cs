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
            int studentcnt = 0;
            while (true) {
                Console.WriteLine("Options");
                Console.WriteLine("1 for Add a Student.");
                Console.WriteLine("2 for Enter grades for a Student.");
                Console.WriteLine("3 for View all Student Grades.");
                Console.WriteLine("0 for Quit.");
                string? choice = Console.ReadLine()?.Trim();
                switch (choice) {
                    case "1":
                        if (studentcnt < mxstudents) {
                            Console.WriteLine("Enter Student Name.");
                            string nam = Console.ReadLine();
                            Console.WriteLine("Enter Student ID.");
                            int sid = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Student Form Group.");
                            string sfg = Console.ReadLine();
                            studentcnt += 1;
                            students[studentcnt-1].name = nam;
                            students[studentcnt-1].id = sid;
                            students[studentcnt-1].form_group = sfg;
                        } else {
                            Console.WriteLine("\nError. Maximum student limit reached. Please upgrade to Pro Version.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter Student ID.");
                        int sid = Convert.ToInt32(Console.ReadLine());
                        bool sfnd = false;
                        for (int i = 0; i < mxstudents; ++i) {
                            if (students[i].id == sid) {
                                sfnd = true;
                                for (int j = 0; j < mxsubjects; ++j) {
                                    Console.WriteLine($"Please enter a grade for {subjects[j]}.");
                                    int subgrade = Convert.ToInt32(Console.ReadLine());
                                    if (subgrade > 100 || subgrade < 0) {
                                        Console.WriteLine("Invalid grade entered. Retry with a numebr between 0 and 100.");
                                        --j;
                                    }
                                    grades[studentcnt-1,j] = subgrade;
                                } else {
                                    Console.WriteLine("Student ID not found. Create the student in database first.");
                                }
                            }
                        }
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
