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


    public static Vector2 operator +(Vector2 a, Vector2 b)
        => new(a.X+b.X, a.Y+b.Y);
    public static Vector2 operator *(Vector2 a, Vector2 b)
        => new(a.X*b.X,a.Y*b.Y);

    public static Vector2 operator -(Vector2 a, Vector2 b)
        => new(a.X - b.X, a.Y - b.Y);


    static Vector2()
    {
        Zero = new Vector2(0,0);
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

public struct Vector3
{
    public double X;
    public double Y;
    public double Z;

    public static double DotProduct(Vector3 vector, Vector3 other)
        => vector.X * other.X + vector.Y * other.Y + vector.Z *other.Z;
    public double LengthSquared { get => DotProduct(this, this); }
    public double Length { get => Math.Sqrt(LengthSquared); }

    public Vector3(double X = 0, double Y = 0, double Z = 0)
    {
        this.X = X;
        this.Y = Y;
        this.Z = Z;
    }
}


public static class Extensions
{

    public static Vector2 AsInt(this Vector2 orig) =>
        new Vector2((int)orig.X, (int)orig.Y);

}

