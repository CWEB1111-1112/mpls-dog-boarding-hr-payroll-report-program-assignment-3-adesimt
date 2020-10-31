using System;

/**
Name: 
Date of completion:
Please be sure to comment your code - provide a comment for each structure use in 
program.
 */

namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeName, sentinelValue;
            int departmentNumber, numberOfHours;
            double hourlyPay, grossSalary;

            string departmentName = "";
            double totalSalary = 0;

            double[] accumSalary = new double[7];

            string[] departments = {"Personnel", "Marketing", "Information Technology", "Computer Services", "Sales", "Legal", "Accounting"}; // store theall the department names
            sentinelValue = "0";
            Console.WriteLine("Enter the employee’s name: ");
            employeeName = Console.ReadLine(); // get the employee's name as the primer

            while (employeeName != sentinelValue)
            {


                Console.WriteLine("\nEnter the department number from the list of departments below: ");

                for (int i = 0; i < departments.Length; i++)
                {
                    Console.WriteLine($"{i + 1} = {departments[i]} department");// display the department and the department number.
                }

                departmentNumber = Convert.ToInt32(Console.ReadLine());

                while(departmentNumber < 1 || departmentNumber > 7) // check if the department number entered is not between 1 to 7
                {
                    Console.WriteLine("\nYou have entered an invalid department number.");
                    Console.WriteLine("Enter the department number from the list of departments below: ");

                    for (int i = 0; i < departments.Length; i++)
                    {
                        Console.WriteLine($"{i + 1} = {departments[i]} department");// display the department and the department number.
                    }

                    departmentNumber = Convert.ToInt32(Console.ReadLine());
                        
                }

                
                Console.WriteLine("Enter the hourly salary: ");
                hourlyPay = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the number of hours worked: ");
                numberOfHours = Convert.ToInt32(Console.ReadLine());

                grossSalary = hourlyPay * numberOfHours;

                totalSalary += grossSalary;


                if(departmentNumber == 1){
                    accumSalary[0] = totalSalary;
                    departmentName = departments[0];
                }
                else if(departmentNumber == 2){
                    accumSalary[1] = totalSalary;
                    departmentName = departments[1];
                }
                else if(departmentNumber == 3){
                    accumSalary[2] = totalSalary;
                    departmentName = departments[2];
                }
                else if(departmentNumber == 4){
                    accumSalary[3] = totalSalary;
                    departmentName = departments[3];
                }
                else if(departmentNumber == 5){
                    accumSalary[4] = totalSalary;
                    departmentName = departments[4];
                }
                else if(departmentNumber == 6){
                    accumSalary[5] = totalSalary;
                    departmentName = departments[5];
                }
                else {
                    accumSalary[6] = totalSalary;
                    departmentName = departments[6];
                }


                Console.WriteLine("\nYou've entered the following information");
                Console.WriteLine($"Employee name = {employeeName}");
                Console.WriteLine($"The gross salary = ${grossSalary}");
                Console.WriteLine($"Department name = {departmentName}");

                
                
                // Console.WriteLine("\nPress enter to continue or 0 to quit");
                // Console.ReadLine();
                Console.WriteLine("\nEnter the employee’s name: ");
                employeeName = Console.ReadLine();

            }


            Console.WriteLine(accumSalary);

            // for (int x = 0; x < departments.Length; x++)
            // {
            //     for (int y = 0; y < accumSalary.Length; y++)
            //     {
            //         Console.Write(departments[x], accumSalary[y] + " \t");
            //     }

            //     Console.WriteLine("");

            // }


        }
    }
}
