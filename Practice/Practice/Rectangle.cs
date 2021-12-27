public class Rectangle : Figure
{

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    public override int GetSquare()
    {
        return Width * Height;
    }
}
