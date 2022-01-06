using System;

namespace SF.Practices_17_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var normalAccount = new NormalAccount();
            var salaryAccount = new SalaryAccount();

            normalAccount.Balance = 500.00;
            salaryAccount.Balance = 500.00;

            // обычный счёт
            calculator.CommonInterest(normalAccount);
            
            Console.WriteLine("Обычный счёт:");
            Console.WriteLine($"При балансе {normalAccount.Balance} руб. процентная ставка { normalAccount.Interest }");

            Console.WriteLine();

            // зарплатный счёт
            calculator.CommonInterest(salaryAccount);
            Console.WriteLine("Зарплатный счёт: ");
            Console.WriteLine($"При балансе {salaryAccount.Balance} руб. процентная ставка { salaryAccount.Interest }");

            Console.ReadKey();
        }
    }
}
