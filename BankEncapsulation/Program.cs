namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("Welcome to K Bank! What is the amount you would like to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);
            double userBalance = account.GetBalance();

            Console.WriteLine($"Current balance: {userBalance,0:c}");

            // below is not part of assignment, just me playing around with what I have learned! would love some tips on how to improve this :)

            Console.WriteLine("Would you like to withdraw an amount? (y/n)");

            string ans;
            ans = Console.ReadLine();

            if (ans == "y")
            {
                Console.WriteLine($"What is the amount you would like to withdraw?");
                double amountToWithdraw = double.Parse(Console.ReadLine());

                account.Withdraw(amountToWithdraw);
                double userNewBalance = account.NewBalance();

                Console.WriteLine($"Your new balance is: {userNewBalance,0:c}");

                Console.WriteLine("Thank you for using our services. Goodbye!");

            }
            else
            {
                Console.WriteLine("Thank you for using our services. Goodbye!");
            }



        }


            
    }
}
