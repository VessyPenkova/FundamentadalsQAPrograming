namespace _15009_Password_Validator_Exercise_Nested_Loops_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            //1st Condition
            bool isValindLegth = password.Length >= 6 && password.Length <= 10;
            //2nd Condition 
            ConatiningOfPasswordValidator(password);
            bool isValid2Conatin = ConatiningOfPasswordValidator(password);
            //3rd Condition
            NumerOfDigitValidator(password);
            bool isValidQuantityOftheTheDigits = NumerOfDigitValidator(password);

            if (isValindLegth == true && isValid2Conatin == true && isValidQuantityOftheTheDigits == true)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (isValindLegth == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (isValid2Conatin == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (isValidQuantityOftheTheDigits == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

            }
        }
        static bool ConatiningOfPasswordValidator(string password)
        {
            //2nd Condition           
            for (int i = 0; i <= password.Length - 1; i++)
            {
                char currentChar = password[i];
                if (char.IsLetterOrDigit(currentChar) == false)
                {
                    return false;
                }
            }
            return true;
        }

        static bool NumerOfDigitValidator(string password)
        {
            //3rd Condition
            int digitCounter = 0;
            for (int i = 0; i <= password.Length - 1; i++)
            {
                char currentChar = password[i];
                digitCounter = 0;
                if (char.IsDigit(currentChar) == true)
                {
                    digitCounter++;
                }
            }            
            return digitCounter >= 2;
        }
    }
}


//Write a program that checks if a given password is valid.

//The password validation rules are:
// 1st Condition: It should contain 6 – 10 characters (inclusive)-> Msg"Password must be between 6 and 10 characters" OK
// 2nd Condition: It should contain only letters and digits      -> Msg"Password must consist only of letters and digits"
// 3rd Condition: It should contain at least 2 digits            -> Msg"Password must have at least 2 digits"
//If it is not valid, for any unfulfilled rule print the corresponding message:
