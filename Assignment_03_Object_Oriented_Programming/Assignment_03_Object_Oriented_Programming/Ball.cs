namespace Assignment_03_Object_Oriented_Programming;

public class Ball
{
    public int Size { get; private set; }
    public Color Color { get; private set; }
    public int ThrowCount { get; private set; }

    public Ball(int size, Color color)
    {
        Size = size;
        Color = color;
        ThrowCount = 0;
    }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if (Size > 0)
        {
            ThrowCount++;
        }
    }
}