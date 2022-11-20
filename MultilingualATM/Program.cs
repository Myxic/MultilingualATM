using static MultilingualATM.AtmOpearation;

namespace MultilingualATM;
public class Program
{
    static void Main(string[] args)
    {


        Program.Run();
        AtmOpearation LO = new AtmOpearation(200000);



        //Console.WriteLine(LO.Withdrawal(2000));
        //Console.WriteLine(LO.Withdrawal(2000));
        //Console.WriteLine(LO.Withdrawal(2000));
        //Console.WriteLine(LO.Withdrawal(20000));
        //Console.WriteLine(LO.Withdrawal(200000));
        //Console.WriteLine(LO.Transfer(2000));
        //AtmOpearation.LanguageOptions("1");

    }

    public static void Run()
    {
        Console.WriteLine("TYPE 1 for English");
        Console.WriteLine("Тип 2 для русского");
        Console.WriteLine("类型 3 中文");

        string? language = Console.ReadLine(); 

        LanguageOptions(language);

       

       


    }
    public static void LanguageOptions(string? num)
    {
        AtmOpearation LO = new AtmOpearation(200000);
        Dictionary<string, string> Login = new Dictionary<string, string>
            {   {"user1", "1234"},
                {"user2", "5678"},
                {"user3", "6969"}
            };
        switch (num)
        {
            case "1":
                LO.English(Login);

                break;
            case "2":
                LO.Russian(Login);
                break;
            case "3":
                LO.Chinese(Login);
                break;
            default:
                Console.WriteLine("Enter Valid Option");
                Run();
                break;
        }



    }

}

