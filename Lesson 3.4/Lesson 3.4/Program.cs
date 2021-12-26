using System;

namespace Lesson_3._4
{

    class Program
    {
        public static void GlobalBoard(string[,] _board, int _number)
        {
            System.Console.WriteLine("X  0  1  2  3  4  5  6  7  8  9");
            for (int x = 0; x <= _board.GetLength(0) - 1; x++)
            {

                System.Console.Write(_number);
                for (int y = 0; y <= _board.GetLength(0) - 1; y++)
                {

                    System.Console.Write($"  {_board[x, y]}");
                }
                _number++;
                System.Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Морской бой");
            String[,] board = { { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"} };
            //Console.WriteLine(board[2,1]);
            int Number = 0;
            String Play = null;
            int ShipA = 1;
            int ShipB = 2;
            int ShipC = 3;
            int Game = 0;
            int x1 = 0;
            int y1 = 0;

            System.Console.WriteLine($"Имеются; \n {ShipA} = трёхклеточный корабль[А]. \n {ShipB} = двухклеточных корабля[Б]. \n {ShipC} = одноклетчные коробли[С].\n");

            System.Console.WriteLine("Для размещения кораблей введите координаты с последующим указанием типа корабля без пробела (русская раскладка, нижний регистр).\n Например 14а \n \n Примечание - Корабль типа А" +
                " не может находится в координатах [0.Х] и [9.Х] \n Корабль типа Б не может находится в координатах[9.Х] \n");



            System.Console.WriteLine("Игровое Поле");

            GlobalBoard(board, Number);

            while (Game < 6)
            {
                Play = System.Console.ReadLine();
                x1 = Convert.ToInt32(Play[0].ToString());
                y1 = Convert.ToInt32(Play[1].ToString());

                if ((x1 == 0 | x1 <= 9) & (y1 == 0 | y1 <= 9))
                {
                    if (Play[2] == 'а' & x1 > 0 & x1 < 9 & ShipA != 0)
                    {
                        board[x1, y1] = "X";
                        board[x1 - 1, y1] = "X";
                        board[x1 + 1, y1] = "X";
                        ShipA--;
                        Game++;
                        System.Console.WriteLine($"Осталось кораблей типа А {ShipA}");
                        GlobalBoard(board, Number);
                        System.Console.Clear();
                        System.Console.WriteLine($"Имеются; \n {ShipA} = трёхклеточный корабль[А]. \n {ShipB} = двухклеточных корабля[Б]. \n {ShipC} = одноклетчные коробли[С].\n Например 14а \n");
                        GlobalBoard(board, Number);
                        System.Console.WriteLine("Готово.");
                    }
                    else

                    if (Play[2] == 'б' & x1 >= 0 & x1 < 9 & ShipB != 0)
                    {
                        board[x1, y1] = "X";
                        board[x1 + 1, y1] = "X";
                        ShipB--;
                        Game++;
                        System.Console.WriteLine($"Осталось кораблей типа б {ShipB}");
                        GlobalBoard(board, Number);
                        System.Console.Clear();
                        System.Console.WriteLine($"Имеются; \n {ShipA} = трёхклеточный корабль[А]. \n {ShipB} = двухклеточных корабля[Б]. \n {ShipC} = одноклетчные коробли[С].\n Например 14а \n");
                        GlobalBoard(board, Number);
                        System.Console.WriteLine("Готово.");
                    }
                    else

                        if (Play[2] == 'с' & ShipC != 0)
                    {
                        board[x1, y1] = "X";
                        ShipC--;
                        Game++;
                        System.Console.WriteLine($"Осталось кораблей типа с {ShipC}");
                        GlobalBoard(board, Number);
                        System.Console.Clear();
                        System.Console.WriteLine($"Имеются; \n {ShipA} = трёхклеточный корабль[А]. \n {ShipB} = двухклеточных корабля[Б]. \n {ShipC} = одноклетчные коробли[С].\n Например 14а \n");
                        GlobalBoard(board, Number);
                        System.Console.WriteLine("Готово.");
                    }
                    else
                    {
                        System.Console.WriteLine("Не верно ввёдённые координаты для данного типа корабля.");
                    }
                }
            }
            System.Console.WriteLine("Все корабли размещены");
        }
    }
}

