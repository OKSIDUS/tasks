using System.Data;
using Task_2.Helper;

namespace Task_2
{
    public class ExcelReader
    {
        private readonly string _filePath;

        public ExcelReader(string filePath)
        {
            _filePath = filePath;
        }

        public void PrintAll()
        {
            DataTable table = ExcelHelper.ReadExcelToDataTable(_filePath);

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"{row["ID"]}: {row["Фамилия"]} {row["Имя"]}, {row["Телефон"]}, {row["Город"]}");
            }
        }

        public void PrintByCity(string city)
        {
            DataTable table = ExcelHelper.ReadExcelToDataTable(_filePath);

            foreach (DataRow row in table.Select($"Город = '{city}'"))
            {
                Console.WriteLine($"{row["Фамилия"]} {row["Имя"]} — {row["Телефон"]}");
            }
        }


        /*Задание 1
         * 
         * Вывести всех пользователей отсортировав по имени А-Я
         * 
         */
        public void PrintByNameAsc()
        {
            throw new NotImplementedException();
        }

        /*Задание 2
         * 
         * Вывести всех пользователей отсортировав по фамилии Я-А
         * 
         */
        public void PrintByLastNameDesc()
        {
            throw new NotImplementedException();
        }


        /*Задание 3
         * 
         * Вывести всех пользователей у кого длина имени >= 8
         * 
         */
        public void PrintByNameLenght()
        {
            throw new NotImplementedException();
        }

        public void PrintOnlyOddRow()
        {
            DataTable table = ExcelHelper.ReadOnlyOddRow(_filePath);

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"{row["ID"]}: {row["Фамилия"]} {row["Имя"]}, {row["Телефон"]}, {row["Город"]}");
            }
        }
    }
}
