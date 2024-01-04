namespace SOLID
{
    public class Game : IGame
    {
        private readonly string _name = "Игра: угадай число!";
        private readonly int _val;
        private readonly Settings _settings;
        public Game(Settings settings, IRandomValue randomValue)
        {
            _settings = settings;
            _val = randomValue.GetValue(_settings.MaxValue, _settings.MinValue);
        }
        public string Info()
        {
            return _name;
        }

        public void Play()
        {
            Console.WriteLine(Info());
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
                        value?.GetType().Name, value);
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