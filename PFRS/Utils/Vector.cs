namespace Utils.Vector;
public struct Vector2
{
    public static Vector2 Zero { get; }
    public double X;
    public double Y;

    public static double DotProduct(Vector2 vector, Vector2 other) 
        => vector.X * other.X + vector.Y * other.Y;
    public double LengthSquared { get => DotProduct(this,this); }
    public double Length { get => Math.Sqrt(LengthSquared); }

    public Vector2(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    static Vector2()
    {
        Zero = new Vector2(0,0);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

