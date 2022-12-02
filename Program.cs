namespace EmployeeWageComputationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1;
            Random rannum = new Random();
            int checkPresent = rannum.Next(0, 2);
            Console.WriteLine("Random Number: " + checkPresent);
            if (checkPresent == fullTime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}