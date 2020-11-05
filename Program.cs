using System;

/**
Name: Simeon Adewale
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
            double[] totalgrossPayroll = new double[7]; // an array to hold total gross payroll of individual departments and the length of the array is set to 7


            string[] departments = {"Personnel", "Marketing", "Information Technology", "Computer Services", "Sales", "Legal", "Accounting"}; // store theall the department names
            double personnelTotalPayroll = 0;
            double marketingTotalPayroll = 0;
            double itTotalPayroll = 0;
            double csTotalPayroll = 0;
            double salesTotalPayroll = 0;
            double legalTotalPayroll = 0;
            double accountingTotalPayroll = 0;
            sentinelValue = "0";
            Console.WriteLine("Enter the employee’s name: ");
            employeeName = Console.ReadLine(); // get the employee's name as the primer

            while (employeeName != sentinelValue)
            {

                for (int i = 0; i < departments.Length; i++)
                {
                    Console.WriteLine($"{i + 1} = {departments[i]} department");// display the department and the department number.
                }

                Console.WriteLine("\nEnter a department number from the list of departments above: ");
                departmentNumber = Convert.ToInt32(Console.ReadLine());

                while(departmentNumber < 1 || departmentNumber > 7) // check if the department number entered is not between 1 to 7
                {
                    Console.WriteLine("\nYou have entered an invalid department number.\n");

                    for (int i = 0; i < departments.Length; i++)
                    {
                        Console.WriteLine($"{i + 1} = {departments[i]} department");// display the department and the department number.
                    }

                    Console.WriteLine("Enter a department number from the list of departments above: ");
                    departmentNumber = Convert.ToInt32(Console.ReadLine());
                        
                }

                
                Console.WriteLine("Enter the hourly salary: ");
                hourlyPay = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the number of hours worked: ");
                numberOfHours = Convert.ToInt32(Console.ReadLine());

                grossSalary = hourlyPay * numberOfHours;

                

                if(departmentNumber == 1){
                    departmentName = departments[0];
                    personnelTotalPayroll += grossSalary;
                }
                else if(departmentNumber == 2){
                    departmentName = departments[1];
                    marketingTotalPayroll += grossSalary;

                }
                else if(departmentNumber == 3){
                    departmentName = departments[2];
                    itTotalPayroll += grossSalary;

                }
                else if(departmentNumber == 4){
                    departmentName = departments[3];
                    csTotalPayroll += grossSalary;

                }
                else if(departmentNumber == 5){
                    departmentName = departments[4];
                    salesTotalPayroll += grossSalary;

                }
                else if(departmentNumber == 6){
                    departmentName = departments[5];
                   legalTotalPayroll += grossSalary;

                }
                else {
                    departmentName = departments[6];
                    accountingTotalPayroll += grossSalary;

                }
                
                //each department is assigned a total gross payroll
                totalgrossPayroll[0] = personnelTotalPayroll;
                totalgrossPayroll[1] = marketingTotalPayroll;
                totalgrossPayroll[2] = itTotalPayroll;
                totalgrossPayroll[3] = csTotalPayroll;
                totalgrossPayroll[4] = salesTotalPayroll;
                totalgrossPayroll[5] = legalTotalPayroll;
                totalgrossPayroll[6] = accountingTotalPayroll;

                Console.WriteLine("\nYou've entered the following information");
                Console.WriteLine($"Employee name = {employeeName}");
                Console.WriteLine($"The gross salary = ${grossSalary}");
                Console.WriteLine($"Department name = {departmentName}");

                
                Console.WriteLine("\n To continue, enter the employee’s name or 0 to quit: ");
                employeeName = Console.ReadLine();

            }

                         
            Console.WriteLine("{0,-30} {1,5}\n", "Department Name", "Department Total"); // using the composite formatting method and also alignmnet, -30 get the first string align left
            
            for (int x = 0; x < departments.Length; x++)
            {

                Console.WriteLine("{0, -30} {1,5}", departments[x], totalgrossPayroll[x]);
            }


        }
    }
}
