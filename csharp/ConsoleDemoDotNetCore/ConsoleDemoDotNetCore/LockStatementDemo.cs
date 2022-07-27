using System;
using System.Threading.Tasks;

namespace ConsoleDemoDotNetCore
{
    public class LockTest {
        public static void RunTest() 
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for(int i = 0; i < 1000_000; i++)
                {
                    n++;
                }
            });
            for (int i = 0; i < 1000_000; i++) {
                n--;
            }
            up.Wait();
            Console.WriteLine(n);
        }
    }
    public class Account
    {
        private readonly object balanceLock = new();
        private decimal balance;

        public Account(decimal initialBalance) => balance = initialBalance;

        public decimal Debit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The debit amount cannot be negative.");
            }

            decimal appliedAmount = 0;
            lock (balanceLock)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    appliedAmount = amount;
                    Console.WriteLine($"Debit -${amount} And Balance = {balance};");
                }
            }
            return appliedAmount;
        }

        public void Credit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The credit amount cannot be negative.");
            }

            lock (balanceLock)
            {
                balance += amount;
                Console.WriteLine($"Credit +${amount} And Balance = {balance};");
            }
        }

        public decimal GetBalance()
        {
            lock (balanceLock)
            {
                return balance;
            }
        }
    }

    public class AccountTest
    {
        public static async Task Main()
        {
            var account = new Account(1000);
            var tasks = new Task[100];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => Update(account));
            }
            await Task.WhenAll(tasks);
            Console.WriteLine($"____Account's balance is {account.GetBalance()}");
            // Output: Account's balance is 2000
        }

        static void Update(Account account)
        {
            decimal[] amounts = { 0, 2, -3, 6, -2, -1, 8, -5, 11, -6 };
            foreach (var amount in amounts)
            {
                if (amount >= 0)
                {
                    account.Credit(amount);
                }
                else
                {
                    account.Debit(Math.Abs(amount));
                }
            }
        }
    }
}
