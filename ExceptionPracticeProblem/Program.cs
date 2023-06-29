namespace ExceptionPracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Practice Problem!");
            Console.WriteLine("Enter the person's age:");
            string input = Console.ReadLine();

            try
            {
                if (string.IsNullOrEmpty(input))
                {
                    throw new InvalidAgeException("Age cannot be null or empty.");
                }

                int age = Convert.ToInt32(input);

                Person person = new Person();
                person.Age = age;

                string ageCategory = person.GetAgeCategory();
                Console.WriteLine($"The person falls into the '{ageCategory}' category.");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid age format. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}