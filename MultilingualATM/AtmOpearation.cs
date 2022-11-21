using System;
using System.Security.Cryptography.X509Certificates;
using static MultilingualATM.AtmOpearation;

namespace MultilingualATM
{


     class AtmOpearation
    {
        //private readonly Dictionary<UserInterface, int> Amount;
        readonly UserInterface IUser1 = new IUser1();
        readonly UserInterface IUser2 = new IUser2();
        readonly UserInterface IUser3 = new IUser3();

        public static decimal _money ;


        //public AtmOpearation()
        //{
        //    Amount = new Dictionary<UserInterface, int>
        //    {   {IUser1, 2000},
        //        {IUser2, 10000},
        //        { IUser3, 3000}
        //    };

        //}

        public AtmOpearation(decimal money)
        {
           
            _money = money ; 
        }

        public interface UserInterface
        {
            void Balance();
            void Withdraw();
            void Transfer();
        }

        private void OperationOptions()
        {
            Console.WriteLine("Enter 1 for Balance, 2 for Withdraw, 3 for Transfer");
            string? Operation = Console.ReadLine();

            switch (Operation)
            {
                 
                case "1":
                    Console.Clear();
                    Console.Write("Balance is: ");
                    Console.WriteLine(Balance());

                    Console.WriteLine("Do you want to perform another operation? Enter Y to cancel");
                    string? Continue = Console.ReadLine();
                    if (Continue.ToUpper() == "Y")
                    {
                        Console.Clear();
                        OperationOptions();
                    }
                    Program.Run();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Enter Amount To Withdraw");
                    string withdraw = Console.ReadLine();
                    decimal WithdrawFee = Convert.ToInt32(withdraw);
                    Console.WriteLine(Withdrawal(WithdrawFee));

                    Console.WriteLine("Do you want to perform another operation? Enter Y to cancel");
                    string? Continue2 = Console.ReadLine();
                    if (Continue2.ToUpper() == "Y")
                    {
                        Console.Clear();
                        OperationOptions();
                    }
                    Program.Run();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Enter Amount To Transfer");
                    string transfer = Console.ReadLine();
                    decimal TransferFee = Convert.ToInt32(transfer);

                    Console.WriteLine(Transfer(TransferFee));

                    Console.WriteLine("Do you want to perform another operation? Enter Y to cancel");
                    string? Continue3 = Console.ReadLine();
                    if (Continue3.ToUpper() == "Y")
                    {
                        Console.Clear();
                        OperationOptions();
                    }
                             Program.Run();
      
                    
                    break;
                default:
                    break;
            }
            


            
        }

        private void RussianOperationOptions()
        {
            Console.WriteLine("Введите 1 для баланса, 2 для снятия, 3 для перевода");
            string? Operation = Console.ReadLine();

            switch (Operation)
            {

                case "1":
                    Console.Clear();
                    Console.Write("Баланс: ");
                    Console.WriteLine(Balance());

                    Console.WriteLine("Вы хотите выполнить другую операцию? Введите Y, чтобы отменить");
                    string? Continue = Console.ReadLine();
                    if (Continue.ToUpper() == "Y")
                    {
                        Console.Clear();
                        RussianOperationOptions();
                    }
                    Program.Run();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Введите сумму для вывода");
                    string withdraw = Console.ReadLine();
                    decimal WithdrawFee = Convert.ToInt32(withdraw);
                    Console.WriteLine(Withdrawal(WithdrawFee));

                    Console.WriteLine("Вы хотите выполнить другую операцию? Введите Y, чтобы отменить");
                    string? Continue2 = Console.ReadLine();
                    if (Continue2.ToUpper() == "Y")
                    {
                        Console.Clear();
                        RussianOperationOptions();
                    }
                    Program.Run();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Введите сумму для перевода");
                    string transfer = Console.ReadLine();
                    decimal TransferFee = Convert.ToInt32(transfer);

                    Console.WriteLine(Transfer(TransferFee));

                    Console.WriteLine("Вы хотите выполнить другую операцию? Введите Y, чтобы отменить");
                    string? Continue3 = Console.ReadLine();
                    if (Continue3.ToUpper() == "Y")
                    {
                        Console.Clear();
                        RussianOperationOptions();
                    }
                    Program.Run();


                    break;
                default:
                    break;
            }




        }

        private void ChineseOperationOptions()
        {
            Console.WriteLine("余额输入1，提款输入2，转账输入3");
            string? Operation = Console.ReadLine();

            switch (Operation)
            {

                case "1":
                    Console.Clear();
                    Console.Write("余额是: ");
                    Console.WriteLine(Balance());

                    Console.WriteLine("是否要执行其他操作？ 输入 Y 继续");
                    string? Continue = Console.ReadLine();
                    if (Continue.ToUpper() == "Y")
                    {
                        Console.Clear();
                        ChineseOperationOptions();
                    }
                    Program.Run();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("输入取款金额");
                    string withdraw = Console.ReadLine();
                    decimal WithdrawFee = Convert.ToInt32(withdraw);
                    Console.WriteLine(Withdrawal(WithdrawFee));

                    Console.WriteLine("是否要执行其他操作？ 输入 Y 继续");
                    string? Continue2 = Console.ReadLine();
                    if (Continue2.ToUpper() == "Y")
                    {
                        Console.Clear();
                        ChineseOperationOptions();
                    }
                    Program.Run();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("输入转账金额");
                    string transfer = Console.ReadLine();
                    decimal TransferFee = Convert.ToInt32(transfer);

                    Console.WriteLine(Transfer(TransferFee));

                    Console.WriteLine("是否要执行其他操作？ 输入 Y 继续");
                    string? Continue3 = Console.ReadLine();
                    if (Continue3.ToUpper() == "Y")
                    {
                        Console.Clear();
                        ChineseOperationOptions();
                    }
                    Program.Run();


                    break;
                default:
                    break;
            }




        }


        private void Operation(Dictionary<string,string>Login, string Username)
        {
                int tries = 0;
                int PossibleTries = 5;



                while (tries < PossibleTries)
                {
                    Console.Write("Enter YOUR EXISTING Pin:  ");

                    string? Password = Console.ReadLine();
                    Console.WriteLine(Login[Username.ToLower()]);

                    if (Password == Login[Username.ToLower()])
                    {
                        Console.Clear();
                        Console.WriteLine("Logged in");
                        Console.WriteLine($"Welcome {Username.ToUpper()} What Operation do you want to perform");
                       

                        OperationOptions();

                        break;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }

            
           
        }
        private void RussianOperation(Dictionary<string, string> Login, string Username)
        {
            int tries = 0;
            int PossibleTries = 5;



            while (tries < PossibleTries)
            {
                Console.Write("Введите ВАШ СУЩЕСТВУЮЩИЙ PIN-код:  ");

                string? Password = Console.ReadLine();
                Console.WriteLine(Login[Username.ToLower()]);

                if (Password == Login[Username.ToLower()])
                {
                    Console.Clear();
                    Console.WriteLine("Вы вошли");
                    Console.WriteLine($"Добро пожаловать{Username.ToUpper()} Какую задачу вы хотите выполнить");


                    RussianOperationOptions();

                    break;
                }
                else
                {
                    Console.Clear();
                }
            }



        }
        private void ChineseOperation(Dictionary<string, string> Login, string Username)
        {
            int tries = 0;
            int PossibleTries = 5;



            while (tries < PossibleTries)
            {
                Console.Write("输入您现有的密码:  ");

                string? Password = Console.ReadLine();
                Console.WriteLine(Login[Username.ToLower()]);

                if (Password == Login[Username.ToLower()])
                {
                    Console.Clear();
                    Console.WriteLine("登录");
                    Console.WriteLine($"欢迎 {Username.ToUpper()} 你想执行什么任务");


                    ChineseOperationOptions();

                    break;
                }
                else
                {
                    Console.Clear();
                }
            }



        }
        private decimal Balance()
        {
            return _money;

        }
        private decimal Withdrawal(decimal withdraw)
        {
            if (withdraw < Balance())
            {
               _money =  Balance() - withdraw;

            }
            else
            {
                Console.WriteLine($"{Balance()} < {withdraw} ?????");
            }
            return Balance();
        }
        private decimal Transfer(decimal transfer)
        {
            if (transfer < Balance())
            {
                _money = Balance() - transfer;
            }
            else
            {
                Console.WriteLine($"{Balance()} < {transfer} ?????");
            }
            return Balance();
        }

        public void English(Dictionary<string, string> Login)
        {
            Console.Write("Enter YOUR EXISTING Username:  ");

            string? Username = Console.ReadLine();


            if (Login.ContainsKey(Username.ToLower()))
            {
                Operation(Login, Username);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Username");
                English(Login);
            }
        }
        public void Russian(Dictionary<string, string> Login)
        {
            Console.Write("Введите ВАШЕ СУЩЕСТВУЮЩЕЕ имя пользователя:  ");

            string? Username = Console.ReadLine();


            if (Login.ContainsKey(Username.ToLower()))
            {
                RussianOperation(Login, Username);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Неверное имя пользователя");
                Russian(Login);
            }
        }

    
        public  void Chinese(Dictionary<string, string> Login)
        {
            Console.Write("输入您现有的用户名:  ");

            string? Username = Console.ReadLine();


            if (Login.ContainsKey(Username.ToLower()))
            {
                ChineseOperation(Login, Username);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("无效的用户名");
                Chinese(Login);
            }
        }
    
    }


    public class IUser1 : UserInterface
    {
        public void Withdraw()
        {
            throw new NotImplementedException();
        }

        public void Balance()
        {
            throw new NotImplementedException();
        }

        public void Transfer()
        {
            throw new NotImplementedException();
        }
    }
    public class IUser2 : UserInterface
    {
        public void Withdraw()
        {
            throw new NotImplementedException();
        }

        public void Balance()
        {
            throw new NotImplementedException();
        }

        public void Transfer()
        {
            throw new NotImplementedException();
        }
    }
    public class IUser3 : UserInterface
    {
        public void Withdraw()
        {
            throw new NotImplementedException();
        }

        public void Balance()
        {
            throw new NotImplementedException();
        }

        public void Transfer()
        {
            throw new NotImplementedException();
        }
    }
}




