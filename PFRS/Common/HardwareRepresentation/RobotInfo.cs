namespace Common.HardwareRepresentation
{
    internal class RobotInfo : IRobotInfo
    {
        public List<ISensor> Sensors { get; set; }
        public List<IMotor> Motors { get; set; }
    }
}