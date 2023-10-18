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




class Task2
{
    static void Main()
    {

        int qh = 5; // qapi
        int qe = 2;

        int sh = 4; // skaf
        int se = 5;
        int su = 2;

        bool qapidankecir = false;

        if (sh <= qh && se <= qe)

        {
            qapidankecir = true;
        }

        else if (su <= qh && se <= qe)

        {
            qapidankecir = true;
        }

        else if (sh <= qh && su <= qe)

        {
            qapidankecir = true;
        }

        else if (sh <= qe && se <= qh)

        {
            qapidankecir = true;
        }

        else if (su <= qe && se <= qh)

        {
            qapidankecir = true;
        }

        else if (sh <= qe && se <= qh)

        {
            qapidankecir = true;
        }

        if (qapidankecir)

        {
            Console.WriteLine("skaf qapidan kecir");
        }

        else

        {
            Console.WriteLine("skaf qapidan kecmir");
        }

    }
}

