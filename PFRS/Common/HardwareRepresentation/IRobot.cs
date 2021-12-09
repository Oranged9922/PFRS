namespace Common.HardwareRepresentation;
public interface IRobot
{
    public IRobotInfo RobotInfo { get; }
    public RobotCoordinates RobotCoordinates { get; }

    void Update(int fps);
}

public interface IRobotInfo
{
    public List<ISensor> Sensors { get; }
    public List<IMotor> Motors { get; }
}

