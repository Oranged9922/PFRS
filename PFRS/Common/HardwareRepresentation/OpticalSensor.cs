using Utils.Vector;
namespace Common.HardwareRepresentation
{
    public class OpticalSensor : ISensor
    {
        public IRobot MountedOn;
        public Vector2 relPosFromRobotCenter;

        public float GetReading()
        {
            Vector2 absolutePositon 
                = (MountedOn.RobotCoordinates.Position + 
                    (relPosFromRobotCenter * new Vector2(MountedOn.SizeX, MountedOn.SizeY)));
            absolutePositon = absolutePositon + new Vector2(MountedOn.SizeX/2, MountedOn.SizeY/2);
            var track = MountedOn.Track;
            return track[(int)absolutePositon.X, (int)absolutePositon.Y] == -1 ? 0 :1;
        }
    }
}
