namespace SOLID
{
    // Open/Closed Principle (OCP)
    // Liskov Substitution Principle (LSP)
    public abstract class Game : IGame
    {
        protected int _val;
        abstract public int GetValue();
        abstract public void Play(); 
    }
}