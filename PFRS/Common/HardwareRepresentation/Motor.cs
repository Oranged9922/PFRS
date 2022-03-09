using Utils.Vector;
namespace Common.HardwareRepresentation
{
    internal class Motor : IMotor
    {
        internal int _speed = 50;

        internal IRobot MountedOn;
        internal Vector2 relPosFromRobotCenter;

        public int Speed { set => _speed = Utils.Utils.Clamp(value,1400,1600);}
    }
}