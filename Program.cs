namespace EmployeeWageComputationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1, emp_Rate_Per_Hr = 20, empHrs = 0, empWage = 0;
            Random rannum = new Random();
            int checkPresent = rannum.Next(0, 2);
            Console.WriteLine("Random Number: " + checkPresent);
            if (checkPresent == fullTime)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * emp_Rate_Per_Hr;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}