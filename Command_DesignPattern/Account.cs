using System;

namespace Command_DesignPattern
{
    public class Account
    {
        public int Balance { get; set; }

        public void Process(Command c)
        {
            switch (c.TheAction)
            {
                case Command.Action.Deposit:
                    c.Success = true;
                    Balance += c.Amount;
                    break;
                case Command.Action.Withdraw:
                    if (Balance - c.Amount < 0)
                        c.Success = false;
                    else
                    {
                        Balance -= c.Amount;
                        c.Success = true;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}