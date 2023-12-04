namespace SOLID
{
    public class GameRandomNumber : Game
    {
        private int _rndNum;

        public GameRandomNumber() 
        {
            _rndNum = 5;
        }
        public override void Play()
        {
            Console.WriteLine("Игра угадай число!!!");
            Console.Write("Введите число: ");
            while (true)
            {
                int userNmb = Convert.ToInt32(Console.ReadLine());
                if (EndGame(userNmb)) break;
                Console.Write($"Пробуйте заново: ");
            }
        }

        private bool EndGame(int usrNum)
        {
            if (_rndNum == usrNum)
            {
                Console.WriteLine($"Верно!");
                return true;
            }
            Console.WriteLine(_rndNum > usrNum ? $"Больше!" : $"Меньше!");
            return false;
        }
    }
}