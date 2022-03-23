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

public struct Matrix3
{

    public static Matrix3 Identity { get; set; }

    public float M11;

    public Vector2 ApplyTrasform(Vector2 v)
    =>
         new Vector2
            (
                M11 * v.X + M12 * v.Y,
                M21 * v.X + M22 * v.Y
            );

    public Matrix3 Rotate(double angle)
        =>
           new(
                   M11: (float)Math.Cos(angle),
                   M12: -(float)Math.Sin(angle),
                   M13: 0,

                   M21: (float)Math.Sin(angle),
                   M22: (float)Math.Cos(angle),
                   M23: 0,

                   M31: 0,
                   M32: 0,
                   M33: 1
               );

    public float M12;
    public float M13;

    public float M21;
    public float M22;
    public float M23;

    public float M31;
    public float M32;
    public float M33;


    public Matrix3(float M11, float M12, float M13, float M21, float M22, float M23, float M31, float M32, float M33) : this()
    {
        this.M11 = M11;
        this.M12 = M12;
        this.M13 = M13;
        this.M21 = M21;
        this.M22 = M22;
        this.M23 = M23;
        this.M31 = M31;
        this.M32 = M32;    
        this.M33 = M33;
    }
}


public static class Extensions
{

    public static Vector2 AsInt(this Vector2 orig) =>
        new Vector2((int)orig.X, (int)orig.Y);

    public static double Angle(this Vector2 a, Vector2 b) => Math.Acos(Vector2.DotProduct(a, b) / (a.Length * b.Length));


    public static Matrix3 RotateAndTranslate(this Matrix3 m, double angle, Vector2 vec)
   =>
           new(
                   M11: (float)Math.Cos(angle),
                   M12: -(float)Math.Sin(angle),
                   M13: (float)(vec.X),

                   M21: (float)Math.Sin(angle),
                   M22: -(float)Math.Cos(angle),
                   M23: (float)(vec.Y),

                   M31: 0,
                   M32: 0,
                   M33: 1
               );
}

