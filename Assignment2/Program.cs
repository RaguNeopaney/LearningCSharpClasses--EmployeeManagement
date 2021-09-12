class Program
{
    static void Main()
    {
        // loop termination answer
        string userInput = "";
        System.Console.WriteLine("************" + Employee.organizationName + "************");
        // loop for 10 employee information
        do
        {
            // Employee object
            Employee emp = new Employee();

            // Read Employee details from user input
            System.Console.Write("Enter employee ID: ");
            emp.empID = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Enter employee name: ");
            emp.empName = System.Console.ReadLine();
            System.Console.Write("Enter per hour wage: ");
            emp.salaryPerHour = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Enter number of hour employee worked: ");
            emp.noOfWorkingHours = System.Convert.ToDouble(System.Console.ReadLine());

            // Calculate net salary based on number of hours worked amd per hour wage
            emp.netSalary = emp.noOfWorkingHours * emp.salaryPerHour;

            System.Console.WriteLine();

            // Display Employee Details
            System.Console.WriteLine("Employee Details");
            System.Console.WriteLine("Employee ID: "+ emp.empID);
            System.Console.WriteLine("Employee Name: "+ emp.empName);
            System.Console.WriteLine("Employee Wage Per Hour: "+ emp.salaryPerHour);
            System.Console.WriteLine("Employee No. of Hour Worked: "+ emp.noOfWorkingHours);
            System.Console.WriteLine("Employee Net Salary: "+ emp.netSalary);
            System.Console.WriteLine("Type of Employee: "+ Employee.typeOfEmployee);
            System.Console.WriteLine("Employee Department: "+ emp.departmentName);





            // counter for number of employies
            int empNumbers = 1;
          
            System.Console.Write("Do you wish to continue adding employee? (yes/no) : ");
            userInput = System.Console.ReadLine();
        } while (userInput == "y" || userInput == "Y" || userInput == "yes" || userInput == "Yes");
       
        System.Console.ReadKey();
    }
}