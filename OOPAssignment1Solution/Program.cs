using Common.AssignmentClasses;

namespace OOPAssignment1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee[] empArr = {
                    new(1, "Ahmed", Security.Developer, 25000, Gender.Male, new(10, 12 ,2023)),
                    new(2, "Mona", Security.Secretary, 10000, Gender.Female, new(10, 9 ,2021)),
                    new(3, "Khaled", (Security.Guest | Security.Developer | Security.Secretary | Security.Dba), 30000, Gender.Male, new(10, 1 ,2024)),
                };
                Console.WriteLine(empArr[2].SecurityLevel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}