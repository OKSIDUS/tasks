using System;

namespace Task_1
{
    internal class Program
    {
        //Задача допиши значения для каждого типа данных и выведи их в консоль, пример целочисленных типов данных:
        // int intVar = 4;
        // long longVar = 5L;
        //Так же выведи минимальные и максимальные значения для следующих типов данных (Целочисленеые, Типы с плавающей точкой)
        static void Main(string[] args)
        {

            // Целочисленные типы
            byte byteVar = 128;       // допиши значение 0-255
            var shortVar = 16240;   // допиши значение -32,768 - 32,767
            int intVar = 9876543;         // допиши значение -2,147,483,648 - 2,147,483,647
            var longVar = 1234567890987654321L;      // допиши значение -9,223,372,036,854,775,808 - 9,223,372,036,854,775,807

            // Типы с плавающей точкой
            float floatVar = 1.2f;  // допиши значение -3.4E+38 - 3.4E+38
            double doubleVar = 3.14; // допиши значение -1.7E+308 - 1.7E+308
            decimal decimalVar = 2.07m; // допиши значение -79,228,162,514,264,337,593,543,950,335 - 79,228,162,514,264,337,593,543,950,335

            // Символ и строка
            char charVar = ']';     // допиши значение 
            string stringVar = "Bob";  // допиши значение 

            // Логический тип
            bool boolVar = true;   // допиши значение

            //Списки\массивы
            List<int> listInts = new List<int>() { 1, 2, 3 }; // инициализируй и допиши значения
            List<decimal> listDecimals = new List<decimal>() { 1.3m, 4.3m, 6.1m }; // инициализируй и допиши значения
            List<string> listStrings = new List<string>() { "Bober", "Kurwa" }; // инициализируй и допиши значения
            List<char> listChars = new List<char>() { 'b', 'l', 'y', 'a' }; // инициализируй и допиши значения

            string[] arrStrings = ["Ya", "bombil", "Iraq"]; // инициализируй и допиши значения
            int[] arrInts = [1, 2, 3, 4, 5]; // инициализируй и допиши значения
            char[] arrChars = ['H', 'u', 'y']; // инициализируй и допиши значения

            List<string[]> listArrStrings = new List<string[]>()
            {
                new string[] { "Bim", "Bam" },
                new string[] { "Boom", "Bem" }
            }; // инициализируй и допиши значения
            List<List<int>> listListInts = new List<List<int>>(); // инициализируй и допиши значения
            List<List<bool>>[] arrListListBool = new List<List<bool>>[3]; // инициализируй и допиши значения

            Console.WriteLine("");

            //Пример инициализаии для List<List<double>>

            Console.WriteLine("Вывод List<List<double>>:");
            List<double> childList1 = new List<double>() { 2.3d, 4.3d, 5.4d };
            List<double> childList2 = new List<double>() { 0.0d, 3.0d, 9999.2d };
            List<List<double>> parentList = new List<List<double>>();
            parentList.Add(childList1);
            parentList.Add(childList2);
            for (int i = 0; i < parentList.Count; i++)
            {
                Console.WriteLine($"List: {i + 1}");
                for (int j = 0; j < parentList[i].Count; j++)
                {
                    Console.WriteLine(parentList[i][j].ToString());
                }
            }
            // Здесь выводим всё в консоль (смотри пример)

            Console.WriteLine("Вывод List<int>:");
            List<int> listInts228 = new List<int>() { 2, 2, 8 };
            for (int i = 0; i < listInts228.Count; i++)
            {
                Console.WriteLine(listInts228[i].ToString());
            }

            Console.WriteLine("Вывод List<decimal>:");
            List<decimal> listDecimals479 = new List<decimal>() { 4.2m, 7.1m, 9.5m };
            for (int i = 0; i < listDecimals479.Count; i++)
            {
                Console.WriteLine(listDecimals479[i].ToString());
            }

            Console.WriteLine("Вывод List<string>:");
            List<string> listStrings2 = new List<string>() { "Bober", "Kurwa" };
            for (int i = 0; i < listStrings2.Count; i++)
            {
                Console.WriteLine(listStrings2[i].ToString());
            }

            Console.WriteLine("Вывод List<char>:");
            List<char> listChars4 = new List<char>() { 'O', 'l', 'e', 'g' };
            for (int i = 0; i < listChars4.Count; i++)
            {
                Console.WriteLine(listChars4[i].ToString());
            }

            Console.WriteLine("Вывод string[]:");
            string[] arrStrings3 = ["Ya", "bombil", "Plastelin"];
            for (int i = 0; i < arrStrings3.Length; i++)
            {
                Console.WriteLine(arrStrings3[i].ToString());
            }

            Console.WriteLine("Вывод int[]:");
            int[] arrInts4 = [1, 3, 3, 7];
            for (int i = 0; i < arrInts4.Length; i++)
            {
                Console.WriteLine(arrInts4[i].ToString());
            }

            Console.WriteLine("Вывод char[]:");
            char[] arrChars3 = ['x', 'y', 'z'];
            for (int i = 0; i < arrChars3.Length; i++)
            {
                Console.WriteLine(arrChars3[i].ToString());
            }
            // -
            Console.WriteLine("Вывод List<string[]>:");
            List<string[]> listArrStrings2 = new List<string[]>
            {
                new string[] { "Who", "was" },
                new string[] {"there", "yesterday"}
            };
            for (int i = 0; i < listArrStrings2.Count; i++)
            {
                Console.WriteLine($"List: {i + 1}");
                for (int j = 0; j < listArrStrings2[i].Length; j++)
                {
                    Console.WriteLine(listArrStrings2[i][j].ToString());
                }
            }

            Console.WriteLine("Вывод List<List<int>>:");
            List<int> miniInt1 = new List<int>() { 1, 4 };
            List<int> miniInt2 = new List<int>() { 8, 8 };
            List<List<int>> BigInt = new List<List<int>>();
            BigInt.Add(miniInt1);
            BigInt.Add(miniInt2);
            for (int i = 0; i < BigInt.Count; i++)
            {
                Console.WriteLine($"List: {i + 1}");
                for (int j = 0; j < BigInt.Count; j++)
                {
                    Console.WriteLine(BigInt[i][j].ToString());
                }
            }
            // -
            Console.WriteLine("Вывод List<List<bool>>[]:");
            List<List<bool>>[] FD = new List<List<bool>>[]
            {
                new List<List<bool>>
                {
                    new List<bool> { true, false },
                    new List<bool> { false, true }
                },
                new List<List<bool>>
                {
                    new List<bool> { false, false },
                    new List<bool> { true, true }
                }
            };

            int ArIn = 0;
            foreach (List<List<bool>> list1 in FD)
            {
                Console.WriteLine($"Array {ArIn +1}:");

                int LiIn = 0;
                foreach (List<bool> list2 in list1 )
                {
                    Console.WriteLine($"List {LiIn +1}:");
                    foreach (bool value in list2)
                    {
                        Console.WriteLine(value);
                    }
                    Console.WriteLine();
                    LiIn++;
                }
                ArIn++;
            }

            Console.ReadLine();
        }
    }
}