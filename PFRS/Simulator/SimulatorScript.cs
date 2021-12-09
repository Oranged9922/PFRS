namespace Simulator
{
    public class SimulatorScript
    {
        public Func<Common.HardwareRepresentation.IRobot>? Loop { get; internal set; } = null;
        public Func<Common.HardwareRepresentation.IRobot>? Setup { get; internal set; } = null;

    }
}