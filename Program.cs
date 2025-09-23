namespace Bankaccont_ovning
{
    internal class Program
    {
          static void Main(string[] args)
        {
            Bankaccont bankaccont = new Bankaccont(91);

            bankaccont.Deposit(92);
            bankaccont.Withdraw(5000);
            bankaccont.ShowBalance();

        }
    }
}
