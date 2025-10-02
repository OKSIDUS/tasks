namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "abonents.xlsx";
            var reader = new ExcelReader(filePath);

            Console.WriteLine("=== Все абоненты ===");
            reader.PrintAll();

            Console.WriteLine("\n=== Абоненты из Москвы ===");
            reader.PrintByCity("Москва");

            Console.WriteLine("=== Все абоненты отсортированы по имени A-Z ===");
            reader.PrintByNameAsc();
            Console.WriteLine("=== Все абоненты отсортированы по фамилии Z-A ===");
            reader.PrintByLastNameDesc();
            Console.WriteLine("=== Все абоненты у которых имя длинее 8 символов ===");
            reader.PrintByNameLenght();
            Console.WriteLine("=== Все абоненты с четных рядов ===");
            reader.PrintOnlyOddRow();

            Console.ReadKey();
        }
    }
}
