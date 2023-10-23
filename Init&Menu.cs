using NodeDef;

namespace Laba2_Alg
{
    internal class Init_Menu
    {
        public static int ReadInt(string message, Func<int, bool> validator)
        {
            int result;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out result) || !validator(result));
            return result;
        }


        public static void ShowStandart()
        {
            NodeWork<int> stack = new NodeWork<int>();

            stack.Add(18);
            stack.Add(5);
            stack.Add(45);
            stack.Add(56);
            stack.Add(78);
            stack.Add(34);
            stack.Add(27);
            stack.Add(337);
            stack.Add(2);
            stack.Add(8);
            stack.AddToFront(4);
            stack.AddToFront(2);

            Console.WriteLine("\nОригинальный стек:");
            stack.Display();

            Console.WriteLine("\nУдаление первых двух элементов стека:");
            stack.RemoveFromFront();
            stack.RemoveFromFront();
            stack.Display();

            Console.WriteLine("\nСмена первого и последнего элемента:");
            stack.SwapFirstAndEndEl();
            stack.Display();

            Console.WriteLine("\nРеверс стека:");
            stack.Reverse();
            stack.Display();


            Console.WriteLine("\nЕсть ли элемент?");
            int choiceEl = 1045;
            Console.WriteLine(stack.Equal(choiceEl));

            Console.WriteLine("\nОчистка стека");
            stack.ClearStack();

            Console.WriteLine("\nВывод стека:");
            stack.Display();

        }

        public static void ShowOnChoice(int choice, NodeWork<int> stack)
        {


            if (choice == 2)
            {
                choice = ReadInt("Добавить в начало число:", x => x < 0 || x >= 0);

                stack.AddToFront(choice);
                Console.WriteLine();
                stack.Display();

            }
            else if (choice == 3)
            {
                Console.WriteLine();
                stack.RemoveFromFront();
                stack.Display();
            }
            else if (choice == 4)
            {
                Console.WriteLine();
                stack.SwapFirstAndEndEl();
                stack.Display();

            }
            else if (choice == 5)
            {
                Console.WriteLine();
                stack.Reverse();
                stack.Display();

            }
            else if (choice == 6)
            {

                int choiceEl = ReadInt("Принадлежит ли стеку элемент:", x => x >= 0 || x < 0);
                Console.WriteLine(stack.Equal(choiceEl));

            }
            else if (choice == 7)
            {
                Console.WriteLine();
                stack.ClearStack();
                stack.Display();

            }
            else
            {
                stack.Display();
            }
        }


        public static void Menu(NodeWork<int> list)
        {
            int choice;

            Console.WriteLine("1 - Показ стандартных функций работы со связным списком");
            Console.WriteLine("2 - Добавление элемента стека");
            Console.WriteLine("3 - Удаление элемента стека");
            Console.WriteLine("4 - Поменять местами первый и последний стека");
            Console.WriteLine("5 - Разворот стека");
            Console.WriteLine("6 - Принадлежит ли элемент стеку");
            Console.WriteLine("7 - Очищение стека");
            Console.WriteLine("8 - Вывод стека");


            while (true)
            {

                choice = ReadInt("\nВыберите необходимое действие: ", x => x > 0 && x < 14);
                switch (choice)
                {
                    case 1:
                        ShowStandart();
                        break;
                    case 2:
                        ShowOnChoice(2, list);
                        break;
                    case 3:
                        ShowOnChoice(3, list);
                        break;
                    case 4:
                        ShowOnChoice(4, list);
                        break;
                    case 5:
                        ShowOnChoice(5, list);
                        break;
                    case 6:
                        ShowOnChoice(6, list);
                        break;
                    case 7:
                        ShowOnChoice(7, list);
                        break;
                    case 8:
                        ShowOnChoice(8, list);
                        break;

                }


                /*Console.WriteLine("\nПродолжить работу?");
                Console.WriteLine("1 - Продолжить");
                Console.WriteLine("2 - Продолжить и очистить консоль");
                Console.WriteLine("3 - Завершение работы");
                choice = ReadInt("Выберите необходимое действие: ", x => x > 0 && x < 4);

                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        Console.Clear();
                        break;
                    case 3:

                        return;
                }
*/
            }

        }

    }
}
