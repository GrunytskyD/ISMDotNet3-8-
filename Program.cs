using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            // видалення від'ємних елементів
            int A[20];
            int d;//змінна ,що містить зміст
            int i;// допоміжна змінна
            //введення масива 
            //...
            //розв'язок самого змісту 
            d = 1;//початкова установа змінної d
            for (i = 0; i < 50; i++)
                if ((A[i] % 2) == 1)
                    d = d * A[i];

        }
    }
}
