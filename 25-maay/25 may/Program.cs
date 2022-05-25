using System;

namespace _25_may
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };

            int[] oddnums = new int[10];

            for (int i = 0; i < nums.Length; i++)



            {
                for (int j = 0; i < oddnums.Length; j++)
                {
                    if (num % 2 == 0)
                    {
                        oddnums[i] = num;

                    }


                }

            }
            foreach (var item in oddnums)
            {
                Console.WriteLine(item);
            }




            int[] point = { 7, 8, 9, 9, 9, 5 };

            string[] names = { "Ali", "Coni", "Gun", "Mubariz", "Cahangir" };
            string b = "Alis";

            int a = 4;
            Console.WriteLine(LettersOfName(names));

        } //verilmis arraydeki ededlerin necesinin tek  oldugunu qaytaran metod ya
        static int OddOfNumbers(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    count++;

                }

            }
            return count;
        }
        //verilmis arraydeki verilmis n ededinin sayini tapan alqoritm
        static int CountofN(int[] digits, int n)
        {
            int count = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == n)
                    count++;
            }
            return count;



        }
        //verilmis arrayde verilmis n ededinin olub olmadigini gosteren metod
        static bool ExistOfN(int[] numbers, int n)
        {
            bool check = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    check = true;
                }




            }
            return check;

        }
        // Qrupdaki telebelerin point siyahisi verilib, qrupun ortalama pointini veren metod
        static int FindPoint(int[] numbers)
        {
            int sum = 0;
            int avr;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];



            }
            avr = sum / numbers.Length;
            return avr;

        }
        //verilmis adlar siyahisinda , verilmis adin olub olmamasini gosteren metod
        static bool FindNames(string[] names, string name)
        {
            bool check = false;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    check = true;
                }

            }
            return check;
        }
        //Verilmis adlar siyahisinda (string array) nece adin uzunlugunun 5-den boyuk oldugunu tapan proqram

        static int LettersOfName(string[] names)
        {
            int Count = 0;
            int b = 5;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > b)
                    Count++;

            }
            return Count;
        }
        // Verilmis ededler siyahisindaki cut ededlerden ibraret yeni bir array qaytaran method.
        // Misalcun gonderilmis ededler siyahisinda {1,3,4,5,6} deyerleri varsa method geriye {4,6} deyerlerinden ibaret bir
        // sarray qaytarmalidir
        static void oddFinder(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int[] oddnums = new int[10];

            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    for (int i = 0; i < oddnums.Length; i++)
                    {
                        oddnums[i] = num;
                    }
                }
            }
            foreach (var item in oddnums)
            {
                Console.WriteLine(item);
            }
        }






    }
}