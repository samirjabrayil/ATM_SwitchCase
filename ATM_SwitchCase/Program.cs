
namespace ATM_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Mini ATM

            string secim1 = Console.ReadLine();
            int balans1 = 3000;

            switch (secim1)
            {
                case "1":
                    Console.WriteLine("Balansiniz : " + balans1);
                    break;


                case "2":
                    Console.Write("Cekeceyiniz meblegi daxil edin : ");
                    int mebleg1 = int.Parse(Console.ReadLine());
                    if (mebleg1 > balans1)
                    {
                        Console.WriteLine("Mebleg balansdan coxdur");
                    }
                    else
                    {
                        Console.WriteLine("Balansiniz : " + (balans1 - mebleg1));
                    }
                    break;


                case "3":
                    Console.Write("Yatiracaginiz meblegi daxil edin : ");
                    int yatirilanpul1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Balansiniz : " + (yatirilanpul1 + balans1));
                    break;


                case "4":
                    Console.WriteLine("Hesabdan cixmaq istediyinize eminsiniz?");
                    string eminem1 = Console.ReadLine();
                    switch (eminem1)
                    {
                        case "he":
                            Console.WriteLine("Hesabdan cixdiniz , Ugur dolu gunler dileyirik");
                            break;

                        case "yox":
                            Console.WriteLine("Hansi emeliyyati etmek isteyirdiniz?");

                            break;
                    }

                    break;


                default:
                    Console.WriteLine("Zehmet olmasa duzgun parametrleri girin");
                    break;



            }
            #endregion
        }
    }
}