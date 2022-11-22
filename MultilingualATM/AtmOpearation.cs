using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using static MultilingualATM.AtmOpearation;
using static MultilingualATM.Program;

namespace MultilingualATM
{
    /*So the idea in this code is to simulate a real time ATM where we already have an existing User(User1,User2,User3)
     * Here they enter a password (ALREADY EXISTING) the ATM does 4 operation(Language(3 different types), Checking Balance, Withdrawal and Tranfer,
     * The opeartion when user1 tranfer money to user2 or user3 , they should be able to get the money and the money will be removed from user1.
     * and also endless loop lol
     */

    class AtmOpearation
    {

        public static decimal _money;




        public AtmOpearation(decimal money)
        {

            _money = money;
        }
        public AtmOpearation()
        {

        }



        public void OperationOptions(string User, string Fund, string NoFund)
        {
            Console.WriteLine("Enter 1 for Balance, 2 for Withdraw, 3 for Transfer, 4 to Return to main menu");
            string? Operation = Console.ReadLine();

            switch (Operation)
            {

                case "1":
                    Console.Clear();
                    Console.Write("Balance is: ");
                    Console.WriteLine(Balance(Fund));

                    Console.WriteLine("Do you want to perform another operation? Enter Y to continue");
                    string? Continue = Console.ReadLine();
                    if (Continue.ToUpper() == "Y")
                    {
                        Console.Clear();
                        OperationOptions(User, Fund, NoFund);
                    }
                    Program.Run();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Enter Amount To Withdraw");
                    string? withdraw = Console.ReadLine();
                    decimal WithdrawFee = Convert.ToDecimal(withdraw);
                    Console.WriteLine(Withdrawal(WithdrawFee, Fund, NoFund));

                    Console.WriteLine("Do you want to perform another operation? Enter Y to continue");
                    string? Continue2 = Console.ReadLine();
                    if (Continue2.ToUpper() == "Y")
                    {
                        Console.Clear();
                        OperationOptions(User, Fund, NoFund);
                    }
                    Program.Run();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Enter Amount To Transfer");
                    string? transfer = Console.ReadLine();
                    Console.WriteLine("Who do you want to send to");
                    string? reciever = Console.ReadLine();

                    decimal TransferFee = Convert.ToDecimal(transfer);

                    if (User == "user1")
                    {
                        Console.WriteLine(Transfer(User,TransferFee, reciever, Fund, NoFund));
                    }else if (User == "user2")
                    {
                        Console.WriteLine(Transfer(User, TransferFee, reciever, Fund, NoFund));
                    }
                    else if (User == "user3")
                    {
                        Console.WriteLine(Transfer(User, TransferFee, reciever, Fund, NoFund));
                    }

                    Console.WriteLine("Do you want to perform another operation? Enter Y to continue");
                    string? Continue3 = Console.ReadLine();
                    if (Continue3.ToUpper() == "Y")
                    {
                        Console.Clear();
                        OperationOptions(User, Fund, NoFund);
                    }
                    Program.Run();

                
                    break;
                case "4":
                    Program.Run();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Enter a valid Option");
                    OperationOptions(User, Fund, NoFund);
                    break;
            }




        }

        public void RussianOperationOptions(string User, string Fund, string NoFund)
        {
            Console.WriteLine("Введите 1 для баланса, 2 для снятия, 3 для перевода, 4, чтобы вернуться в главное меню");
            string? Operation = Console.ReadLine();

            switch (Operation)
            {

                case "1":
                    Console.Clear();
                    Console.Write("Баланс: ");
                    Console.WriteLine(Balance(Fund));

                    Console.WriteLine("Вы хотите выполнить другую операцию? Введите Y, чтобы продолжить");
                    string? Continue = Console.ReadLine();
                    if (Continue.ToUpper() == "Y")
                    {
                        Console.Clear();
                        RussianOperationOptions(User, Fund, NoFund);
                    }
                    Program.Run();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Введите сумму для вывода");
                    string? withdraw = Console.ReadLine();
                    decimal WithdrawFee = Convert.ToDecimal(withdraw);
                    Console.WriteLine(Withdrawal(WithdrawFee, Fund, NoFund));

                    Console.WriteLine("Вы хотите выполнить другую операцию? Введите Y, чтобы продолжить");
                    string? Continue2 = Console.ReadLine();
                    if (Continue2.ToUpper() == "Y")
                    {
                        Console.Clear();
                        RussianOperationOptions(User, Fund, NoFund);
                    }
                    Program.Run();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Введите сумму для перевода");
                    string? transfer = Console.ReadLine();
                    decimal TransferFee = Convert.ToDecimal(transfer);
                    Console.WriteLine("Кому вы хотите отправить");
                    string? reciever = Console.ReadLine();
                    
                    if (User == "user1")
                    {
                        Console.WriteLine(Transfer(User, TransferFee, reciever, Fund, NoFund));
                    }
                    else if (User == "user2")
                    {
                        Console.WriteLine(Transfer(User, TransferFee, reciever, Fund, NoFund));
                    }
                    else if (User == "user3")
                    {
                        Console.WriteLine(Transfer(User, TransferFee, reciever, Fund, NoFund));
                    }
                    Console.WriteLine("Вы хотите выполнить другую операцию? Введите Y, чтобы продолжить");
                    string? Continue3 = Console.ReadLine();
                    if (Continue3.ToUpper() == "Y")
                    {
                        Console.Clear();
                        RussianOperationOptions(User, Fund, NoFund);
                    }
                    Program.Run();


                    break;
                case "4":
                    Program.Run();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Введите правильный вариант");
                    RussianOperationOptions(User, Fund, NoFund);
                    break;
            }




        }

        public void ChineseOperationOptions(string User, string Fund, string NoFund)
        {
            Console.WriteLine("余额输入1，提款输入2，转账输入3, 4 返回主菜单");
            string? Operation = Console.ReadLine();

            switch (Operation)
            {

                case "1":
                    Console.Clear();
                    Console.Write("余额是: ");
                    Console.WriteLine(Balance(Fund));

                    Console.WriteLine("是否要执行其他操作？ 输入 Y 继续");
                    string? Continue = Console.ReadLine();
                    if (Continue.ToUpper() == "Y")
                    {
                        Console.Clear();
                        ChineseOperationOptions(User, Fund, NoFund);
                    }
                    Program.Run();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("输入取款金额");
                    string withdraw = Console.ReadLine();
                    decimal WithdrawFee = Convert.ToDecimal(withdraw);
                    Console.WriteLine(Withdrawal(WithdrawFee, Fund, NoFund));

                    Console.WriteLine("是否要执行其他操作？ 输入 Y 继续");
                    string? Continue2 = Console.ReadLine();
                    if (Continue2.ToUpper() == "Y")
                    {
                        Console.Clear();
                        ChineseOperationOptions(User, Fund, NoFund);
                    }
                    Program.Run();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("输入转账金额");
                    string transfer = Console.ReadLine();
                    decimal TransferFee = Convert.ToDecimal(transfer);
                    Console.WriteLine("你想送给谁");
                    string? reciever = Console.ReadLine();
                    if (User == "user1")
                    {
                        Console.WriteLine(Transfer(User, TransferFee, reciever, Fund, NoFund));
                    }
                    else if (User == "user2")
                    {
                        Console.WriteLine(Transfer(User, TransferFee, reciever, Fund, NoFund));
                    }
                    else if (User == "user3")
                    {
                        Console.WriteLine(Transfer(User, TransferFee, reciever, Fund, NoFund));
                    }

                    Console.WriteLine("是否要执行其他操作？ 输入 Y 继续");
                    string? Continue3 = Console.ReadLine();
                    if (Continue3.ToUpper() == "Y")
                    {
                        Console.Clear();
                        ChineseOperationOptions(User, Fund, NoFund);
                    }
                    Program.Run();


                    break;
                case "4":
                    Program.Run();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("输入有效选项");
                    ChineseOperationOptions(User, Fund, NoFund);
                    break;
            }




        }


        private void Operation(Dictionary<string, string> Login, string Username)
        {
            int tries = 0;
            int PossibleTries = 5;
            UserInterface User1 = new IUser1();
            UserInterface User2 = new IUser2();
            UserInterface User3 = new IUser3();


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

                    if (Username.ToLower() == "user1")
                    {
                        User1.English();
                    }else if (Username.ToLower() == "user2")
                    {
                        User2.English();
                    }
                    else if (Username.ToLower() == "user3")
                    {
                        User3.English();

                    }

                    

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
            UserInterface User1 = new IUser1();
            UserInterface User2 = new IUser2();
            UserInterface User3 = new IUser3();


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


                    if (Username.ToLower() == "user1")
                    {
                        User1.Russian();
                    }
                    else if (Username.ToLower() == "user2")
                    {
                        User2.Russian();
                    }
                    else if (Username.ToLower() == "user2")
                    {
                        User3.Russian();

                    }

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
            UserInterface User1 = new IUser1();
            UserInterface User2 = new IUser2();
            UserInterface User3 = new IUser3();


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


                    if (Username.ToLower() == "user1")
                    {
                        User1.Chinese();
                    }
                    else if (Username.ToLower() == "user2")
                    {
                        User2.Chinese();
                    }
                    else if (Username.ToLower() == "user2")
                    {
                        User3.Chinese();

                    }

                    break;
                }
                else
                {
                    Console.Clear();
                }
            }



        }

        private decimal Balance(string Fund)
        {
            Console.Write($"{Fund}  ");
            return _money ;

        }

        private decimal Withdrawal(decimal withdraw, string Fund, string NoFund)
        {
            if (withdraw < Balance(Fund))
            {
                _money = Balance(Fund) - withdraw;

            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{NoFund.ToUpper()}");
                Console.WriteLine($"{Balance(Fund)} < {withdraw} ?????");
            }
            return Balance(Fund);
        }

        private decimal Transfer(string User, decimal transfer, string reciever, string Fund, string NoFund)
        {
            IUser3 user3 = new IUser3();
           

            if (transfer < Balance(Fund))
            {
                _money = Balance(Fund) - transfer;

                if (User.ToLower() == "user1")
                {
                  
                    StartingMoney.dept = transfer;
                }else if (User.ToLower() == "user2")
                {
                    StartingMoney.dept2 = transfer;
                }
                else if(User.ToLower() == "user3")
                {
                    StartingMoney.dept3 = transfer;
                }

                if (reciever.ToLower() == "user1")
                {
                    StartingMoney.num = transfer;
                    
                } else if (reciever.ToLower() == "user2")
                {
                    StartingMoney.num2 = transfer;
                }
                else if (reciever.ToLower() == "user3")
                {

                    StartingMoney.num3 = transfer;
                }
               
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"{NoFund.ToUpper()}");
                Console.WriteLine($"{Balance(Fund)} < {transfer} ?????");
            }
            return Balance(Fund);
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


        public void Chinese(Dictionary<string, string> Login)
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
    public interface UserInterface
    {
        void English();
        void Russian();
        void Chinese();
    }


    public class ImplementInterface
    {
        public void English(UserInterface user)
        {

        }
        public void Russian(UserInterface user)
        {

        }
        public void Chinese(UserInterface user)
        {

        }
    }


    public class IUser1 : UserInterface
    {
       


        public void English()
        {
        StartingMoney IntialAmount = new StartingMoney();
            AtmOpearation ATM = new AtmOpearation(IntialAmount.First_Amount());
            ATM.OperationOptions("user1", "Cash Balance", "Insufficient  Funds");
        }

        public void Russian()
        {
            StartingMoney IntialAmount = new StartingMoney();
            AtmOpearation ATM = new AtmOpearation(IntialAmount.First_Amount());
            ATM.RussianOperationOptions("user1", "Денежных баланс", "Недостаточно средств");
        }

        public void Chinese()
        {
            StartingMoney IntialAmount = new StartingMoney();
            AtmOpearation ATM = new AtmOpearation(IntialAmount.First_Amount());
            ATM.ChineseOperationOptions("user1", "现金余额", "不充足的资金");
        }
    }


    public class IUser2 : UserInterface
    {

        public void English()
        {
            StartingMoney IntialAmount = new StartingMoney();
            AtmOpearation ATM = new AtmOpearation(IntialAmount.Second_Amount() );
            ATM.OperationOptions("user2", "Cash Balance", "Insufficient  Funds"); 
        }

        public void Russian()
        {
            StartingMoney IntialAmount = new StartingMoney();
            AtmOpearation ATM = new AtmOpearation(IntialAmount.Second_Amount());
            ATM.RussianOperationOptions("user2", "Денежных баланс", "Недостаточно средств"); 
        }

        public void Chinese()
        {
            StartingMoney IntialAmount = new StartingMoney();
            AtmOpearation ATM = new AtmOpearation(IntialAmount.Second_Amount());
            ATM.ChineseOperationOptions("user2", "现金余额", "不充足的资金"); 
        }
    }


    public class IUser3 : UserInterface
    {
       

        public void English()
        {
            StartingMoney IntialAmount = new StartingMoney();
            AtmOpearation ATM = new AtmOpearation(IntialAmount.Third_Amount() );
            ATM.OperationOptions("user3", "Cash Balance", "Insufficient  Funds");
        }

        public void Russian()
        {
            StartingMoney IntialAmount = new StartingMoney();
            AtmOpearation ATM = new AtmOpearation(IntialAmount.Third_Amount() );
            ATM.RussianOperationOptions("user3", "Денежных баланс", "Недостаточно средств"); 
        }

        public void Chinese()
        {
            StartingMoney IntialAmount = new StartingMoney();
            AtmOpearation ATM = new AtmOpearation(IntialAmount.Third_Amount());
            ATM.ChineseOperationOptions("user3", "现金余额", "不充足的资金"); 
        }


    }
  
}





