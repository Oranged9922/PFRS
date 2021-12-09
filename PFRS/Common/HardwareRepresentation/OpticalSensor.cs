using Utils.Vector;
namespace Common.HardwareRepresentation
{
    public class OpticalSensor : ISensor
    {
        public IRobot MountedOn;
        public Vector2 relPosFromRobotCenter;

        public float GetReading()
        {
            throw new NotImplementedException();
        }
    }
}
