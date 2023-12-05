namespace SOLID
{
    public class GameRandomValue : Game
    {
        public GameRandomValue()
        {
            _val = GetValue();
        }

        override public int GetValue()
        {
            Random rnd = new();
            return rnd.Next();
        }
        override public void Play()
        {
            Console.WriteLine("Игра угадай число!!!");
            while (true)
            {
                Console.Write("Введите число: ");
                var value = Console.ReadLine();
                int usrNum;
                try
                {
                    usrNum = Convert.ToInt32(value);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("{0} находится за пределами диапазона типа Int32.", value);
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Значение {0} '{1}' имеет нераспознаваемый формат.",
                        value.GetType().Name, value);
                    continue;
                }
                if (_val == usrNum)
                {
                    Console.WriteLine($"Верно!");
                    break;
                }
                Console.WriteLine(_val > usrNum ? $"Больше!" : $"Меньше!");
            }
        }
    }
}
