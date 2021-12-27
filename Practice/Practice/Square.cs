public class Square : Figure
{
    public Square(int width) {
        Width = Height = width;
    }
    public override int GetSquare()
    {
        return Width * Width;
    }
}