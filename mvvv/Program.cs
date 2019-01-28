using System;

namespace mvvv
{
    class Program
    {


        static void Main()
        {
            int[] foobar = { 6, 42, 35, 8, 21, 4, 11, 53 };
            Goober(foobar);



        }
        static void Goober(int[] oober)
        {
            for (int i = 0; i < oober.Length; i++)
            {
                for (int j = 0; j < oober.Length - i - 1; j++)
                {
                    if (oober[j] > oober[j + 1])
                    {
                        int temp = oober[j];
                        oober[j] = oober[j + 1];
                        oober[j + 1] = temp;
                    }
                }
            }
        }
    }
}
