using System.Security.Principal;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {

            var yvettesAccount = new BankAccount(100);

            Console.WriteLine($"Current Balance: ${yvettesAccount.GetBalance()}");

            yvettesAccount.Deposit(200);

            Console.WriteLine($"After your deposit, your current balance is ${yvettesAccount.GetBalance()}");

            yvettesAccount.Withdraw(150);

            Console.WriteLine($"After your withdraw, your current balance is ${yvettesAccount.GetBalance()}");
        }
    

    }
}
