using System.Security.Cryptography.X509Certificates;

namespace Methods_ATM
{
    public class Program
    {
        int amount = 2000;
        public void CURRENT_BALANCE()
        {
            Console.WriteLine("corrent blance amount " + amount);
        }
        public void WITHDRAW_AMOUNT()
        {
            Console.WriteLine("enter the amount:");
            int choice1 = int.Parse(Console.ReadLine());
            if ((choice1 > (amount - 500)))
            {
                Console.WriteLine("your minimum balance:Your account does not have sufficient balance");
            }

            else
            {
                amount -= choice1;
                Console.WriteLine("collect your amount: " + choice1);
            }
        }
        public void DEPOSIT_AMOUNT()
        {
            Console.WriteLine("ENTER THE AMOUNT:  ");
            int choice2 = int.Parse(Console.ReadLine());
            amount += choice2;
            Console.WriteLine("BLANCE THE AMOUNT :" + amount);
        }
        public void MAINMETHODS()
        {
            Console.WriteLine("enter the pin");
            for (int j = 0; j < 3; j++)
            {
                int pass = int.Parse(Console.ReadLine());
                for (int i = 1; true; i++)
                {
                    if (pass == 1234)
                    {
                        Console.WriteLine("WELCOME TO ATM SERVICE");
                        Console.WriteLine("1. CURRENT BLANCE  ");
                        Console.WriteLine("2. WITHDRAW AMOUNT ");
                        Console.WriteLine("3.DEPOSIT AMOUNT ");
                        Console.WriteLine("4.EXIT");
                        Console.WriteLine("ENTER THE CHOICE:");

                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                CURRENT_BALANCE();
                                break;
                            case 2:
                                WITHDRAW_AMOUNT();
                                break;
                            case 3:
                                DEPOSIT_AMOUNT();
                                break;
                            case 4:
                                Console.WriteLine("Nandri Meendum Varuga!");
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("not CHOICE");
                                break;
                        }
                    }
                    else if (pass != 1234)
                    {
                        Console.WriteLine(" incorrect pin try to next time");
                        Console.WriteLine("ENTER THE PIN......");
                        break;
                    }
                }
            }
        }
    }
    public class ATM
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.MAINMETHODS();
        }
    }
}