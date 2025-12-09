namespace check;

public static class Check6174
{
    public static bool CheckIsRepeated(int n)
    {
        string number = n.ToString();

        bool IsRepeated = number.Distinct().Count() == 1;

        return IsRepeated;
    }

    public static int CheckNumIs6174(int n)
    {
        int D = n;
        while (D != 6174 && !CheckIsRepeated(n))
        {

            int big = SortNumBigtoSmall(D);
            int small = SortNumSmalltoBig(D);

            D = big - small;
            
            if (CheckIsRepeated(D))
            {
                break;
            }

            Console.Write(D + " ");
        }
        return D;
    }

    private static int SortNumBigtoSmall(int n)
    {
        char[] Digits = n.ToString().ToCharArray();
        Array.Sort(Digits);
        Array.Reverse(Digits);

        string Sortnum = new string(Digits);

        return Convert.ToInt32(Sortnum);

    }
    private static int SortNumSmalltoBig(int n)
    {
        char[] Digits = n.ToString().ToCharArray();
        Array.Sort(Digits);

        string Sortnum = new string(Digits);

        return Convert.ToInt32(Sortnum);

    }
}
