namespace SOLID
{
    //Single Responsibility Principle (SRP)
    public interface IRandomValue
    {
        int GetValue(int maxVal, int minVal);
    }
}