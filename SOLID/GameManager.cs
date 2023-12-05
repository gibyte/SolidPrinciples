namespace SOLID
{
    // Dependency Inversion Principle (DIP)
    public class GameManager
    {
        private readonly IEnumerable<Game> _games;
        public GameManager(IEnumerable<Game> games)
        {
            _games = games;
        }
        public void PlayGames()
        {
            foreach (var game in _games)
            {
                game.Play();
            }
        }
    }
}
