namespace ValidationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, username, password, emailAddress;
            int age;

            // get the user inputs until all are valid.
            // The username should only be output once
            Console.Write("Enter first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Password: ");
            password = Console.ReadLine();
            Console.Write("Enter email address: ");
            emailAddress = Console.ReadLine();


            username = createUserName(firstName,lastName,age);
            Console.WriteLine($"Username is {username}, you have successfully registered please remember your password");

            //  Test your program with a range of tests to show all validation works
            // Show your evidence in the Readme

        }
        static bool ValidName(string name)
        {
            // name must be at least two characters and contain only letters
        }

        static bool validAge(int age)
        {
            //age must be between 11 and 18 inclusive

        }

   
        static bool ValidPassword(string password)
        {
            // Check password is at least 8 characters in length


            // Check password contains a mix of lower case, upper case and non letter characters
            // QWErty%^& = valid
            // QWERTYUi = not valid
            // ab£$%^&* = not valid
            // QWERTYu! = valid


            // Check password contains no runs of more than 2 consecutive or repeating letters or numbers
            // AAbbdd!2 = valid (only 2 consecutive letters A and B and only 2 repeating of each)
            // abC461*+ = not valid (abC are 3 consecutive letters)
            // 987poiq! = not valid (987 are consecutive)



        }
        static bool validEmail(string email)
        {
            // a valid email address
            // has at least 2 characters followed by an @ symbol
            // has at least 2 characters followed by a .
            // has at least 2 characters after the .
            // contains only one @ and any number of .
            // does not contain any other non letter or number characters

        }
        static string createUserName(string firstName, string lastName, int age)
        {
            // username is made up from:
            // first two characters of first name
            // last two characters of last name
            // age
            //e.g. Bob Smith aged 34 would have the username Both34



        }

    }
}
