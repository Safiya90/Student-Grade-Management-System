namespace Student_Grade_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[10];
            double[] grade= new double[10];
            int count=0;
            double sum = 0;
            double highest = grade[0];
            double lowest = grade[0];

            while (true)
            {
                Console.WriteLine("Menu:\n1-Add Student\r\n2-Update Grade\r\n3-View All Students and Grades\r\n4-Show Average, Highest, and Lowest Grades\r\n5-Exit\r\n");
                Console.WriteLine("Please choose from 1 to 5");
                string choose= Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        Console.Write("Enter student name: ");
                        string studentname= Console.ReadLine();
                        Console.Write("Enter student grade: ");
                        int studentgreade=Convert.ToInt32(Console.ReadLine());
                        if (studentgreade >= 0 && studentgreade <=100)
                        {
                            students[count] = studentname;
                            grade[count] = studentgreade;
                            count++;
                        }
                    break;

                    case "2":
                        Console.WriteLine("Please enter the name of student to be updated:");
                        string updateName = Console.ReadLine();
                        bool found = false;
                        for (int i = 0; i < count; i++)
                        {
                            if (updateName == students[i])
                            {
                                Console.Write("Enter new grade: ");
                                int newgrade = Convert.ToInt32(Console.ReadLine());
                                if (newgrade >= 0 && newgrade <= 100)
                                {
                                    grade[i] = newgrade;
                                }
                                found = true;
                            }
                        }
                                break;
                            case "3":
                                for (int i = 0; i < count; i++)
                                {
                                    Console.WriteLine($"{students[i]} has {grade[i]}");
                                }
                                break;
                    case "4":
                        if (count == 0)
                        {
                            Console.WriteLine("There is no student data available.");
                            break;
                        }

                        for (int i = 0; i < count; i++)
                        {
                            sum += grade[i];
                            if (grade[i] > highest) highest = grade[i];
                            if (grade[i] < lowest) lowest = grade[i];
                        }

                        double average = sum / count;
                        Console.WriteLine($"Average Grade: {average}");
                        Console.WriteLine($"Highest Grade: {highest}");
                        Console.WriteLine($"Lowest Grade: {lowest}");
                        break;

                    case "5":
                        Console.WriteLine("Thank you!");
                        return;

                }
            }

        }
    }
}
