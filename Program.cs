namespace EmployeeWageComputationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1, partTime = 0, emp_Rate_Per_Hr = 20, empHrs = 0, empWage = 0, totalSalary = 0, numWorkingDays = 20,day=1,totalWorkingHours=0;
            while (day <= numWorkingDays && totalWorkingHours <= 100)
            {
                Random rannum = new Random();
                int checkPresent = rannum.Next(0, 3);
                Console.WriteLine("Day:" + day);
                switch (checkPresent)
                {
                    case 1:
                        empHrs = 8;
                        Console.WriteLine("Employee is Present Full TIme");
                        break;
                    case 2:
                        empHrs = 4;
                        Console.WriteLine("Employee is Present Part Time");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                totalWorkingHours = totalWorkingHours + empHrs;
                if (totalWorkingHours > 100)
                {
                    totalWorkingHours = totalWorkingHours - empHrs;
                    break;
                }
                empWage = empHrs * emp_Rate_Per_Hr;
                Console.WriteLine("Employee Wage of Day" + day + " :" + empWage);
                totalSalary = totalSalary + empWage;
                day++;
            }
            Console.WriteLine("Total Salary of a Month: " + totalSalary);
        }
    }
}