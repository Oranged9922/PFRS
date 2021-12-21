using Utils.Vector;

namespace Common.HardwareRepresentation;
public interface IRobot
{
    public IRobotInfo RobotInfo { get; }
    public RobotCoordinates RobotCoordinates { get; set; }
    float[,] Track { get; set; }
    Vector2 BitmapSize { get; set; }
    int[] MotorsSpeed { get; set; }
    Vector2 BitmapSizeCenter { get; set; }

    Vector2[] SensorsCoordinates { get; set; }

    void Update(int fps);
}

public interface IRobotInfo
{
    public List<ISensor> Sensors { get; }
    public List<IMotor> Motors { get; }
}

