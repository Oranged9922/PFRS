using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.HardwareRepresentation
{
    public abstract class Robot : IRobot
    {
        // PUT CONSTRUCTORS HERE !!
        private static readonly Dictionary<string,Func<IRobot>> _ctors = new()
        {
            { "FiveSensorsRobot", () => new FiveSensorsRobot() },
        };

        public abstract IRobotInfo RobotInfo { get; }
        public RobotCoordinates RobotCoordinates { get; set; }
        public float[,] Track { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }

        public static Func<IRobot> GetRobotCtor(string robotName)
        {
                return _ctors[robotName];
        }

        public abstract void Update(int fps);

        public static void GetRobots(Dictionary<string, IRobot> result)
        {
            foreach (var item in _ctors)
            {
                result[item.Key] = item.Value.Invoke();
            }

        }
    }
}
