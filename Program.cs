namespace Home3_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задача 1. Нарисовать квадрат заданной
            // длины и заданного символа
            Console.WriteLine("Задача 1.");
            PrintSquare(3, '&');

            // задача 2. Является ли число палиндром
            Console.WriteLine("\nЗадача 2.");
            Console.WriteLine("Введите число (проверка на палиндром)->");

            int numb = Convert.ToInt32(Console.ReadLine());

            bool result = Palindrom(numb);

            if (result)
            {
                Console.WriteLine($"{numb} - число палиндром");
            }
            else
            {
                Console.WriteLine($"{numb} - число не палиндром");
            }

            // задача 3. Метод фильтрации массива заданными
            // параметрами
            Console.WriteLine("\nЗадача 3.");

            int[] basic_arr = new int[] { 1, 2, 2, 6, -1, 8, 8, 7, 6 };

            int[] filt_arr = new int[] { 6, 7, -1, 1};

            Console.Write("Исходный массив: ");
            foreach(int i in basic_arr)
            {
                Console.Write($"{i} ");
            }

            Console.Write("\nМассив фильтр: ");
            foreach (int i in filt_arr)
            {
                Console.Write($"{i} ");
            }

            basic_arr = ArryFilter(basic_arr, filt_arr);

            Console.Write("\nМассив после фильтрации: ");
            foreach (int i in basic_arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // Задача 4. Класс "Веб-сайт"

            Console.WriteLine("\nЗадача 4.");
            Website wb = new Website("youtube.com", "https://www.youtube.com/", "Сайт с разными видосиками.", "55.66.88.99");
            Console.WriteLine("Описание объекта \"Веб-сайт:\"");
            wb.Print();

            wb.Name = "github.com";
            wb.PathWeb = "https://github.com/";
            wb.Description = "Сайт для хранения проектов";
            wb.IPaddress = "11.22.33.44";

            Console.WriteLine("\nОписание нового объекта \"Веб-сайт:\"");
            wb.Print();

            // задача 5. Класс журнала

            Console.WriteLine("\nЗадача 5.");
            Journal jrnl = new Journal("ComputerBild",2010, "Компьютерный журнал.", "8-800-2000-600","www.coumputerbild.ru");
            Console.WriteLine("Описание объекта \"Журнала:\"");
            jrnl.Print();

            jrnl.Name = "Программист";
            jrnl.Year = 2010;
            jrnl.Description = "Журнал для программистов";
            jrnl.PhoneNumber = "8-800-6000-600";
            jrnl.Email = "ProgrammersForum.ru";

            Console.WriteLine("\nОписание нового объекта \"Журнала:\"");
            jrnl.Print();

            // задача 6. Класс магазин

            Console.WriteLine("\nЗадача 6.");
            Store st = new Store("СПОРТЛАНДИЯ", "ул. Московская, д.6", "Магазин спортивных товаров","8-955-637-8221","www.sprot.ru");
            Console.WriteLine("Описание объекта \"Магазин:\"");
            st.Print();

            st.Name = "Магнит";
            st.Address = "ул. Белинского, д. 179";
            st.Description = "Магазин продуктов";
            st.PhoneNumber = "8-888-555-1234";
            st.Email = "magnit.ru";

            Console.WriteLine("\nОписание нового объекта \"Магазин:\"");
            st.Print();
        }

        // метод для рисования квадрата заданных размеров
        // и стороной заданным символом
        public static void PrintSquare(int side = 5, char ch = '*')
        {
            // циклы для рисования квадрата
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    // условие для проверки какая часть квадрата
                    // будет отрисована, если внутри квадрата, то
                    // отрисовывается пробел, иначе заданным символом
                    if ((0 < j) && (j < side - 1) && (0 < i) && (i < side - 1))
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write(ch);
                    }
                }
                Console.WriteLine();
            }
        }

        // метод определяющий является ли число палиндромом
        public static bool Palindrom(int number)
        {
            // преобразуем число в строку, для
            // удобства доступа к конкретной позиции числа
            string str = number.ToString();
            int size = str.Length;
            // цикл для определения является ли число палиндромом
            for (int i = 0; i < size / 2; i++)
            {
                // сравниваем два крайних числа,
                // если они не равны, то возвращаем
                // значение false, иначе true
                if (str[i] != str[size - 1 - i])
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        // метод фильтрующий массив по заданным параметрам
        public static int[] ArryFilter(int[] arr, int[] filter)
        {
            // определим новый временный массив 
            // размером равным исходному
            int[] newArr = new int[arr.Length];
            // переменная определяющая состояния наличия
            // числа из фильтара в исходном массиве
            bool state = true;
            // счетчик определяющий количество чисел
            // входящих в новый массив
            int count = 0;

            // цикл для заполнения нового массива числами
            // которые не входят в фильтрующий массив чисел
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < filter.Length; j++)
                {
                    if (arr[i] == filter[j])
                    {
                        state = false;
                        break;
                    }
                }
                if (state == true)
                {
                    newArr[count] = arr[i];
                    count++;
                }
                state = true;
            }
            // изменяем размер массива до необходимого размера
            Array.Resize(ref newArr, count);
            return newArr;
        }
    }
}
