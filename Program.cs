using System;
using System.Threading.Tasks;
using System.Threading;

//HomeWork 8 C#
//Developer by kipov.m.h
//1.09.2022

namespace HomeWork2
{
    class Program
    {
        ////////////Глобальные переменные////////////////
        public const string VerDev = "V.0.2.2";
        //////Номер задания//////
        public const string NamberWork = "Home work 8";
        //////Название программ///////
        public const string ProgramName_1 = "Программа создает двумерный массив из случайных чисел и упорядочит по убыванию элемента каждой строки двумерного массива";
        public const string ProgramName_2 = "Программа создает прямоугольный двумерный массив, который будет находить строку с наименьшей суммой элементов.";
        public const string ProgramName_3 = "Программа принимает на входе две матрицы, после чего будет находить произведение двух матриц и выводить результат.";
        public const string ProgramName_4 = "Создает трёхмерный массив из неповторяющихся двузначных чисел, после чего будет построчно выводить массив, добавляя индексы каждого элемента";
        public const string ProgramName_5 = "Программа создает пустой массив 4 на 4 и заполняет спирально массив последовательными числами";
        //////////////////////////////
        public static bool LoadScrin = true;
        public static int DownNum = 0;
        ///////
        ///////////////////////////////////////// Int Вывод 2х мерного массива с нумерацией //////////////////////////////////////////
        static void IMW_Console(int[,] array, bool delay)
        {
            for (int n = 0; n < array.GetLength(0); n++)
            {
                for (int m = 0; m < array.GetLength(1); m++)
                {
                    if (m < array.GetLength(1) - 1)
                    {
                        if (delay) { Thread.Sleep(100); }
                        Console.Write($"{n+1}.{m + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(string.Format($": {array[n, m]:F0}. "));
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        if (delay) { Thread.Sleep(100); }
                        Console.Write($"{n + 1}.{m + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(string.Format($": {array[n, m]:F0}.\n"));
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
        ///////////////////////////////////////// Int Вывод 3х мерного массива с нумерацией //////////////////////////////////////////
        static void IMW_Console(int[,,] array)
        {
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    for (int z = 0; z < array.GetLength(2); z++)
                    {
                        if (z < array.GetLength(2) - 1)
                        {
                            
                            Console.Write($"({x},{y},{z})");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(string.Format($": {array[x, y, z]:F0}. "));
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                           
                            Console.Write($"({x},{y},{z})");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(string.Format($": {array[x, y, z]:F0}.\n"));
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                       
                }
            }
        }
        ///////////////////////////////////////// Matrix Вывод матрицы ////////////////////////////////////////
        static void Matrix_W_Console(int[,] array, bool delay)
        {
            for (int n = 0; n < array.GetLength(0); n++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"|");
                for (int m = 0; m < array.GetLength(1); m++)
                {
                    if (m < array.GetLength(1) - 1)
                    {
                        if (delay) { Thread.Sleep(100); }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(string.Format($" {array[n, m]} "));
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        if (delay) { Thread.Sleep(100); }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(string.Format($" {array[n, m]}|\n"));
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
        //////////////////////////////////////////////// сортировка массива ///////////////////////////////////////////////////////////
        
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static int[,] Sort_array(int[,] array)
        {
            for (int n = 0; n < array.GetLength(0); n++)
            {
                
                for (int m = 0; m < array.GetLength(1); m++)
                {
                    if (m < array.GetLength(1)-1)
                    {
                        if (array[n, m+1] < array[n, m])
                        {
                            int t = array[n, m+1];
                            array[n, m+1] = array[n, m];
                            array[n, m] = t;
                        }
                    }
                      
                }
            }
            return array;
        }
        //////////////////////////////////////////////// сортировка массива по убыванию ////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static int[,] Down_array(int[,] array)
        {
            int LengthStroc = array.GetLength(0);
            int LengthStolb = array.GetLength(1);
            int[] nums = new int[LengthStroc];
            
            for (int n = 0; n < LengthStroc; n++)
            {

                for (int m = 0; m < LengthStolb; m++)
                {
                    if (m < array.GetLength(1) - 1)
                    {
                        nums[n] = nums[n] + array[n, m];  
                    } 
                    else if (n > 0)
                    {
                        if (nums[DownNum] > nums[n])
                        {
                            DownNum = n;
                        }
                    }
                }
            }
            return array;
        }

        ///////////////////////////////////////// Промежуточное меню для выхода или продолжнеия программы /////////////////////////////
        static void Contin()
        {
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.Write("\nНажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы начать.");

            Console.Write("Нажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Q, End, Escape ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы выйти.\n");
            Console.ResetColor();
        }
        //////////////////////////////////// Выход из программы по нажатию кнопок /////////////////////////////////////////////////////
        static int textWrite(int Exit_Play, string NameProg)
        {
            Contin();

            while (true)
            {
                var Presskey = Convert.ToString(Console.ReadKey().Key);
                if (Presskey == "q0" || Presskey == "End" || Presskey == "Backspace" || Presskey == "Escape" || Presskey == "Q1" || Presskey == "Q" || Presskey == "q")
                {
                    return 0;
                }
                else if (Presskey == "Enter" || Presskey == "Spacebar")
                {
                    return 1;
                }
                else
                {
                    devWrite(NameProg);
                    Contin();
                    return 3;
                }
            }
        }
        ///////////////////////////////// Очистка экрана и вывод redkipov. ////////////////////////////////////////////////////////////
        static void devWrite(string s)
        {
            
                Console.Clear();
                const String nameDev = "redkipov";
                Console.ForegroundColor = ConsoleColor.Cyan; // цвет 
                Console.Write("developer - ");
                Console.ForegroundColor = ConsoleColor.DarkRed; // цвет 
                Console.WriteLine(nameDev);
                Console.ForegroundColor = ConsoleColor.DarkGray; // цвет 
                Console.WriteLine(VerDev);
                Console.ForegroundColor = ConsoleColor.Yellow; // цвет 
                Console.WriteLine(s);
                Console.ResetColor();
            
            


        }
        /////////////////////////////////////////////////// Меню приветствия //////////////////////////////////////////////////////////
        //___________________________________________________________________________________________________________________________//
        static void WelcomeWrite(string NameProg)
        {
            devWrite(NameProg);
            Console.ForegroundColor = ConsoleColor.DarkCyan; //  цвет
            Console.WriteLine(NamberWork);
            Console.ForegroundColor = ConsoleColor.Green; //  цвет зеленый
            Console.Write("Введите соотвествующую цифру программы, которую вы хотите ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta; //  цвет
            Console.WriteLine("запустить");
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[1] "); ////// Первая программа.
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_1);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[2] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_2);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[3] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_3);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[4] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_4);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[5] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_5);
            ///////////////////////////////////////////////////////////
            Console.Write("\nНажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Q, End, Escape ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы выйти.");
            Console.ResetColor(); // сбрасываем в стандартный
        }
        //############################################### Программа 1 ###############################################################//
        //###########################################################################################################################//
        static void Program_1(int Exit_Play)
        {
            ///////////переменные
            int[,] array = new int[4, 4] { { 0, 0, 0, 0 },
                                          { 0, 0, 0, 0 },
                                          { 0, 0, 0, 0 },
                                          { 0, 0, 0, 0 }};
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[1] {ProgramName_1}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                //))))))))))))))))) Logica (((((((((((((((((  
                array = Shuffle(array, 400);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                Console.WriteLine("Размер массива: [4,4]");

                IMW_Console(array,false);
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    array = Sort_array(array);
                }
               
                Console.WriteLine("\nОтсортированный массив:\n");
                IMW_Console(array,false);
                
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        //############################################### Программа 2 ###############################################################//
        //###########################################################################################################################//
        static void Program_2(int Exit_Play)
        {
            ///////////переменные
            int[,] array = new int[5, 4] { { 0, 0, 0, 0 },
                                           { 0, 0, 0, 0 },
                                           { 0, 0, 0, 0 },
                                           { 0, 0, 0, 0 },
                                           { 0, 0, 0, 0 }};
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[2] {ProgramName_2}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                devWrite(NameProg);
                Console.ResetColor();
                //))))))))))))))))) Logica (((((((((((((((((  
                array = Shuffle(array, 200);
                DownNum = 0;
                Console.WriteLine("Размер массива: [5,4]");
                IMW_Console(array,false);
                array = Down_array(array);
                Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {DownNum+1} ");
                //))))))))))))))))) End Logica (((((((((((((((((
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        //############################################### Программа 3 ###############################################################//
        //###########################################################################################################################//
        static void Program_3(int Exit_Play)
        {
            int mx = 3;
            int nz = 3;
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[3] {ProgramName_3}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                //))))))))))))))))) Logica ((((((((((((((((( 3 
                devWrite(NameProg);
                try
                {
                     Console.WriteLine("Введите количество строк матрицы: ");
                     Console.WriteLine("Или нажмите Enter для создания 3x3: ");
                    mx = Convert.ToInt32(Console.ReadLine());
                    if (mx>7)
                    {
                        mx= 7;
                    }
                     Console.WriteLine("Введите количество столбцов матрицы: ");
                     Console.WriteLine("Или нажмите Enter для создания 3x3: ");
                    nz = Convert.ToInt32(Console.ReadLine());
                    if (nz > 7)
                    {
                        nz = 7;
                    }
                }
                catch
                {
                    devWrite(NameProg);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели недопустимые значения....");
                    Console.WriteLine("Размер матрицы будет 3 на 3");
                    //Console.WriteLine("Нажмите Enter чтобы продолжить");
                    Console.ForegroundColor = ConsoleColor.White;
                    //Console.ReadKey();
                    nz = 3;
                    mx = 3;
                }
                
                
                int[,] array1 = new int[nz, mx];
                int[,] array2 = new int[mx, mx];

                // заполнение матрицы случайными числами.
                array1 = Shuffle(array1,20);
                array2 = Shuffle(array2,20);

                Console.WriteLine("Матрица заполнена случайными числами: ");

                //// Вывод массива на экран 3
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nПервая матрица: \n");
                Console.ForegroundColor = ConsoleColor.White;
                Matrix_W_Console(array1,false);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\nВторая матрица: \n");
                Console.ForegroundColor = ConsoleColor.White;
                Matrix_W_Console(array2,false);

                Console.ForegroundColor = ConsoleColor.Red;
                ///////// Если нет ошибок. 3
                try
                {
                    // умножение матрицы.
                    
                    int sizeArray1_n = array1.GetLength(0);
                    int sizeArray2_m = array2.GetLength(1);
                    
                    int[,] resultArray = new int[sizeArray1_n, sizeArray2_m];
                    
                        for (int n = 0; n < sizeArray1_n; n++)
                        {
                            
                            for (int m3 = 0; m3 < sizeArray2_m; m3++)
                            {
                                for (int n3 = 0; n3 < sizeArray1_n; n3++)
                                {
                                    if (n3 < sizeArray1_n-1)
                                    {
                                      resultArray[n, m3] = (array1[n, n3] * array2[n3, m3]) + (array1[n, n3 + 1] * array2[n3 + 1, m3]);
                                    }
                               
                                }

                            }
                            
                        }
                    
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\nПроизведение 2х матриц: \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Matrix_W_Console(resultArray, false);
                    //Console.WriteLine(".");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                ///////// Если произошла ошибка. 3
                catch
                {
                    //UserNumbers = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Произошла ошибка при расчетах!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                //))))))))))))))))) End Logica ((((((((((((((((( 3
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }

        //############################################### Программа 4 ###############################################################//
        //###########################################################################################################################//
        static void Program_4(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[4] {ProgramName_4}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                //))))))))))))))))) Logica (((((((((((((((((
                int[,,] array = new int[3, 3, 3];
                array = Shuffle(array, 90);
                //))))))))))))))))) End Logica (((((((((((((((((
                devWrite(NameProg);
                Console.WriteLine("Результат работы:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Массив: 3x3x3. ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Трёхмерный массив из неповторяющихся 2х значных числел сгенерирован: ");
                Console.ForegroundColor = ConsoleColor.White;
                IMW_Console(array);
                
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        //############################################### Программа 5 ###############################################################//
        //###########################################################################################################################//
        static void Program_5(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[5] {ProgramName_5}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                //))))))))))))))))) Logica ((((((((((((((((( 
                int[,] array = new int[4,4];


                int LengthStroc = array.GetLength(0);
                int LengthStolb = array.GetLength(1);

                int nums=0;
                devWrite(NameProg);
                Console.WriteLine("Результат работы:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2х мерный массив 4 на 4: ");
                Console.ForegroundColor = ConsoleColor.White;
                IMW_Console(array,false); // вывод на экран
                Console.WriteLine("\nСпиральное заполнение массива: \nВывод с задержкой\n");

                for (int m = 0; m < 4; m++) /// направо
                    {
                        if (m == 3)/////////////////////////
                        {
                            for (int n = 0; n < 4; n++)//Вниз
                            {
                                if (n == 3)///////////////////////////
                                {
                                    for (int x = 3; x > -1; --x)// Налево
                                    {  
                                        if (x == 0)
                                        {  
                                            for (int y = 3; y > 0; y--) // Вверх
                                            {
                                                if (y == 1)
                                                {
                                                    for (int z = 0; z < 4; z++) // Направо
                                                    {
                                                        if (z == 3)
                                                        {
                                                            for (int a = 2; a < 3; a++) // Вниз
                                                            {
                                                            nums++;
                                                            array[a, 2] = nums;
                                                            nums++;
                                                            array[a, 1] = nums;
                                                            }
                                                        }
                                                        else
                                                        {
                                                        nums++;
                                                        array[1, z] = nums;
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                nums++;
                                                array[y, 0] = nums;
                                                }
                                            }
                                        }
                                        else
                                        {
                                        nums++;
                                        array[3, x] = nums;
                                        }
                                    }
                                }
                                else
                                {
                                    nums++;
                                    array[n, 3] = nums;
                                }
                            }
                        }
                        else////
                        {
                         nums++;
                         array[0, m] = nums;
                        }
                        
                    }
                //))))))))))))))))) End Logica (((((((((((((((((
                
                Console.ForegroundColor = ConsoleColor.White;
                IMW_Console(array,true); // вывод на экран
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }

        //############################################### Программа скрытая #########################################################//
        //###########################################################################################################################//
        static void Program_7(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = "Скрытое меню";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                devWrite(NameProg);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Генератор 20 случайных чисел");
                Console.ResetColor();
                ////////**************** Logica **************////////
                //int[,] array = CreaterArray(20);
                //WriteArray(array, 1);
                //array = Shuffle(array, 0, 100);
                //WriteArray(array, 1);
                ////////**************** End Logica **************////////
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        /////////////////// функции работы с массивами //////////////////
        static int WriteArray(int[] array, int zero)
        {
            int numbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    if (zero == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}, ");
                    }
                    else if (array[i] > 0)
                    {
                        numbers++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}, ");
                    }
                }
                else
                {
                    if (zero == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}.\n");
                    }
                    else if (array[i] > 0)
                    {
                        numbers++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i + 1}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($":{array[i]}.\n");
                    }
                    else
                    {
                        Console.Write(".......\n");
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            if (zero == 1) { return numbers = 0; }
            else { return numbers; }
        }
        
        ///////////////////////////////
        static int[] CreaterArray(int number)
        {
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }
        ////////////////////////////////
        
        ///////////////////////////////// 2
        static int[,] Shuffle(int[,] array, int amout)
        {
           // int number = 0;
            for (int n = 0; n < array.GetLength(0); n++)
            {

                for (int m = 0; m < array.GetLength(1); m++)
                {
                    
                    Thread.Sleep(1);
                    
                    array[n, m] = new Random().Next(0, n + amout);
                }
            }
            return array;
        }
        //////////////////////////////// 3
        static int[,,] Shuffle(int[,,] array, int amout) //2
        {
            
            for (int x = 0; x < array.GetLength(0); x++)
            {
                Thread.Sleep(1);
                
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    Thread.Sleep(1);
                    for (int z = 0; z < array.GetLength(2); z++)
                    {
                        Thread.Sleep(1);
                        array[x, y, z] = new Random().Next(0, z + amout);
                    }
                       
                }
            }
            return array;
        }

        //******************************************************** MAIN *********************************************************************//
        //###################################################################################################################################//

        static void Main(string[] args)
        {
            var PresskeyP = "Null";
            const String NameProg = "Главное меню";
            int Exit_Play = 1;
            WriteMenu(NameProg);
            while (true)
            {
                /////////////////////////////////////////// Ожидание нажатия кнопки //////////////////////////////////////////
                try
                {
                    PresskeyP = Convert.ToString(Console.ReadKey().Key);
                    //////////////////////////////////// Выбор пункта меню, нужной программы /////////////////////////////////////
                    if (PresskeyP == "D1" || PresskeyP == "NumPad1")
                    {
                        LoadScrin = false;
                        //Console.CursorVisible = true;
                        Program_1(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg);
                    }
                    else if (PresskeyP == "D2" || PresskeyP == "NumPad2")
                    {
                        LoadScrin = false;
                        Console.CursorVisible = true;
                        Program_2(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg);
                    }
                    else if (PresskeyP == "D3" || PresskeyP == "NumPad3")
                    {
                        LoadScrin = false;
                        //Console.CursorVisible = true;
                        Program_3(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg);
                    }
                    else if (PresskeyP == "D4" || PresskeyP == "NumPad4")
                    {
                        LoadScrin = false;
                        Console.CursorVisible = true;
                        Program_4(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg);
                    }
                    else if (PresskeyP == "D5" || PresskeyP == "NumPad5")
                    {
                        LoadScrin = false;
                        Console.CursorVisible = true;
                        Program_5(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg);
                    }
                    else if (PresskeyP == "D6" || PresskeyP == "NumPad6")
                    {
                        //Program_6(Exit_Play);
                    }
                    else if (PresskeyP == "D7" || PresskeyP == "NumPad7")
                    {
                        LoadScrin = false;
                        Console.CursorVisible = true;
                        Program_7(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg);
                    }
                    else if (PresskeyP == "q0" || PresskeyP == "End" || PresskeyP == "Backspace" || PresskeyP == "Escape" || PresskeyP == "Q1" || PresskeyP == "Q" || PresskeyP == "q")
                    {
                        System.Environment.Exit(-1);
                        return;
                    }
                }
                catch
                {
                    Console.WriteLine("\nПроизошла ошибка...");
                    //PresskeyP = "Null";
                }
            }
        }


        static void WriteMenu(String NameProg)
        {
            WelcomeWrite(NameProg);
            Console.WriteLine(" ");
            Method();
        }

        ///// BETA
        static async void Method()
        {
            int k = 0;
            char[] LoadString = { '/', '/', '/', '/', '/', '/', '/', '/', '/', '/' };
            ///////////////////////////////////////////////// Task 1
            await Task.Run(() =>
            {
                //async
            });
            ///////////////////////////////////////////////// Task 2
            while (LoadScrin)
            {
                await Task.Delay(500);
                k++;
                if (LoadScrin)
                {
                    //await Task.Delay(950);
                    //Thread.Sleep(1000);
                    Console.Write($"                                                 \r");
                    try
                    {
                        Console.CursorVisible = false;
                        var Time = DateTime.Now;
                        Console.Write($"{Time}      ");
                    }
                    catch
                    {
                        var Time = DateTime.Now;
                        Console.Write($"{Time}      ");
                    }


                }
                else if (!LoadScrin) { return; }
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < k; i++) { Console.Write(LoadString[i]); if (k == LoadString.Length + 1) { k = 0; } }
                Console.ForegroundColor = ConsoleColor.White;
            }
            //await Task.Run(() => Program_7(1) );
        }
    }
    //######################################################## END ###############################################################//
}
//###########################################################################################################################//