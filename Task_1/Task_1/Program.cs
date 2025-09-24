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
            byte byteVar;       // допиши значение
            short shortVar;     // допиши значение
            int intVar;         // допиши значение
            long longVar;      // допиши значение

            // Типы с плавающей точкой
            float floatVar;  // допиши значение
            double doubleVar; // допиши значение
            decimal decimalVar; // допиши значение

            // Символ и строка
            char charVar;     // допиши значение
            string stringVar;  // допиши значение

            // Логический тип
            bool boolVar;   // допиши значение

            //Списки\массивы
            List<int> listInts; // инициализируй и допиши значения
            List<decimal> listDecimals; // инициализируй и допиши значения
            List<string> listStrings; // инициализируй и допиши значения
            List<char> listChars; // инициализируй и допиши значения

            string[] arrStrings; // инициализируй и допиши значения
            int[] arrInts; // инициализируй и допиши значения
            char[] arrChars; // инициализируй и допиши значения

            List<string[]> listArrStrings; // инициализируй и допиши значения
            List<List<int>> listListInts; // инициализируй и допиши значения
            List<List<bool>>[] arrListListBool = new List<List<bool>>[3]; // инициализируй и допиши значения



            //Пример инициализаии для List<List<double>>

            Console.WriteLine("Вывод List<List<double>>:");
            List<double> childList1 = new List<double>() { 2.3d, 4.3d, 5.4d};
            List<double> childList2 = new List<double>() { 0.0d, 3.0d, 9999.2d };
            List<List<double>> parentList = new List<List<double>>();
            parentList.Add(childList1);
            parentList.Add(childList2);
            for (int i = 0; i < parentList.Count; i++)
            {
                Console.WriteLine($"List: {i+1}");
                for (int j = 0; j < parentList[i].Count; j++)
                {
                    Console.WriteLine(parentList[i][j].ToString());
                }
            }
            // Здесь выводим всё в консоль (смотри пример)
            

            Console.ReadLine();
        }
    }
}
