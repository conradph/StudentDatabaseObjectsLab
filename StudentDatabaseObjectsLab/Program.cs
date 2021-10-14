using System;
using System.Collections.Generic;

namespace StudentDatabaseObjectsLab
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<string> names = new List<string>() { "Phillip", "Andy", "Cassly", "Zachary", "Cortez", "Richard", "Erin", "James", "Cullin", "Cordero" };
            //List<string> hometown = new List<string>() { "Canton, MI", "Berkley, MI", "Detroit, MI", "Wyandotte, MI", "Detroit, MI", "Canton, MI", "Troy, MI", "Yap, FSM", "Fowlerville, MI", "Berkley, MI" };
            //List<string> food = new List<string>() { "Fried Chicken", "French Fries", "Steak", "Sushi", "Chicken Fettuccine Alfredo", "Sushi", "Tacos", "Katsu", "Pad Thai", "BBQ" };
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("Phillip", "Canton, MI", "Fried Chicken"));
            studentList.Add(new Student("Andy", "Berkely, MI", "French Fries"));
            studentList.Add(new Student("Cassly", "Detroit, MI", "Steak"));
            studentList.Add(new Student("Zachary", "Wyandotte, MI", "Sushi"));
            studentList.Add(new Student("Cortez", "Detroit, MI", "Chicken Fettuccine Alfredo"));
            studentList.Add(new Student("Richard", "Canton, MI", "Sushi"));
            studentList.Add(new Student("Erin", "Troy, MI", "Tacos"));
            studentList.Add(new Student("James", "Yap, FSM", "Katsu"));
            studentList.Add(new Student("Cullin", "Fowlerville, MI", "Pad Thai"));
            studentList.Add(new Student("Cordero", "Berkley, MI", "BBQ"));
            Console.WriteLine(studentList.Count);

            bool again = true;
            while (again)
            {


                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (Enter a number 1-10");

                for (int i = 0; i < studentList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {studentList[i].Name}");
                }
                int studentResponse = int.Parse(Console.ReadLine()) - 1;
                bool invalidStudent = true;
                while (invalidStudent)
                {


                    if (studentResponse >= 0 && studentResponse <= studentList.Count-1)
                        invalidStudent = false;
                    else
                    {
                        Console.WriteLine("That student does not exist. Please try again (enter a number 1-10)");
                        studentResponse = int.Parse(Console.ReadLine()) - 1;
                        invalidStudent = true;
                    }
                }
                bool more = true;
                while (more)
                {

                    string knowMore = "no";
                    Console.WriteLine($"Student {studentResponse + 1} is {studentList[studentResponse].Name}. What would you like to know about {studentList[studentResponse].Name} (enter \"hometown\" or \"favorite food\")");
                    string infoResponse = Console.ReadLine().ToLower();

                    bool askAgain = true;
                    while (askAgain)
                    {


                        if (infoResponse == "hometown")
                        {
                            Console.WriteLine($"{studentList[studentResponse].Name} is from {studentList[studentResponse].HomeTown}. Would you like to know more? (enter \"yes\" or \"no\")");
                            knowMore = Console.ReadLine().ToLower();
                            askAgain = false;
                        }
                        else if (infoResponse == "favorite food")
                        {
                            Console.WriteLine($"{studentList[studentResponse].FavoriteFood} is the favorite food of {studentList[studentResponse].Name}. Would you like to know more? (enter \"yes\" or \"no\")");
                            knowMore = Console.ReadLine().ToLower();
                            askAgain = false;
                        }
                        else
                        {

                            Console.WriteLine("That data does not exist. Please try again. (enter \"hometown\" or \"favorite food\")");
                            infoResponse = Console.ReadLine().ToLower();
                            askAgain = true;
                        }
                    }
                    if (knowMore == "no")
                    {
                        more = false;
                        Console.WriteLine("Thanks!");

                    }
                    else if (knowMore == "yes")
                    {
                        more = true;
                    }
                }
                Console.WriteLine("Would you like to learn about any other class members? (enter \"yes\" or \"no\")");
                string otherMembers = Console.ReadLine().ToLower();
                if (otherMembers == "no")
                {
                    Console.WriteLine("Goodbye");
                    again = false;
                }
                else if (otherMembers == "yes")
                {
                    again = true;
                }
            }


        }
    }
}