using static MultilingualATM.AtmOpearation;

namespace MultilingualATM;
public class Program
{
    static void Main(string[] args)
    {


        Program.Run();
        


    }

    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("TYPE 1 for English");
        Console.WriteLine("Тип 2 для русского");
        Console.WriteLine("类型 3 中文");
        Console.WriteLine("Type 4 to Cancel");

        string? language = Console.ReadLine();

        Console.Clear();

        LanguageOptions(language);

       

       


    }

  


    public static void LanguageOptions(string? num)
    {
       

        AtmOpearation ATM = new AtmOpearation();
        Dictionary<string, string> Login = new Dictionary<string, string>
            {   {"user1", "1234"},
                {"user2", "5678"},
                {"user3", "6969"}
            };





        switch (num)
        {
            case "1":
                ATM.English(Login);

                break;
            case "2":
                ATM.Russian(Login);
                break;
            case "3":
                ATM.Chinese(Login);
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("Thanks for choosing us");
                break;
            default:
                Console.WriteLine("Enter Valid Option");
                Run();
                break;
        }




    }

    public class StartingMoney
    {
        public static List<decimal>? _Amount;
        public static decimal num;
        public static decimal num2;
        public static decimal num3;
        public static decimal dept;
        public static decimal dept2;
        public static decimal dept3;



        public StartingMoney()
        {
            _Amount = new List<decimal> { 2000000, 12000000, 2000400900 };
        }
        public decimal First_Amount()
        {
            decimal Total = TransferUser1() + _Amount[0] - DebitUser1();
            return Total;
        }
        public decimal Second_Amount()
        {
            decimal Total = TransferUser2() + _Amount[1] - DebitUser2();
            return Total;
        }
        public decimal Third_Amount()
        {
            decimal Total = TransferUser3() + _Amount[2] - DebitUser3();
            return Total;
        }

        public static decimal TransferUser1()
        {

            return num;
        }
        public static decimal TransferUser2()
        {
            return num2;
        }
        public static decimal TransferUser3()
        {
            return num3;
        }
        public static decimal DebitUser1()
        {

            return dept;
        }
        public static decimal DebitUser2()
        {
            return dept2;
        }
        public static decimal DebitUser3()
        {
            return dept3;
        }
    }


}

