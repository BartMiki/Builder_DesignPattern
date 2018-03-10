using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            List<Command> commands = new List<Command>()
            {
                new Command() {Amount = 100, TheAction = Command.Action.Deposit},
                new Command() {Amount = 50, TheAction = Command.Action.Withdraw}
            };

            Console.WriteLine($"Balance {account.Balance}$.");
            foreach (var command in commands)
            {
                account.Process(command);
                Console.WriteLine($"After {command.TheAction} balance is {account.Balance}$.");
            }
        }
    }
}
