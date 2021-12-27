public class Circle : Figure
{


    public Circle(int radius)
    {
        Width = Height = radius * 2;
    }
    public override int GetSquare()
    {
        int r = Width / 2;
        return ((int)((int)2 * Math.PI * (r * r)));
    }
}