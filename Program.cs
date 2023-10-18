class Task1
{
    static void Main()
    {
        int n = 1090;
        int m = 4;

        int sum = n + m;

        if (sum >= 10 && sum <= 99)

        {
            Console.WriteLine("cem ikireqemli ededdir");
        }

        if (sum >= 100 && sum <= 999)

        {
            Console.WriteLine("cem uc reqemli ededdir");
        }

        if (sum >= 1000 || sum <= 9)

        {
            Console.WriteLine("nezere alinmayib");
        }



    }

}