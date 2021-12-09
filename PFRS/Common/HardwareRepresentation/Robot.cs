using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.HardwareRepresentation
{
    public abstract class Robot : IRobot
    {
        public Dictionary<string, object> Properties { get; set; } = new Dictionary<string, object>()
        {
            {"Position", new RobotCoordinates()},
            {"Sensors", new List<ISensor>()},
        };
        public Dictionary<string, object> Methods { get; set; } = new Dictionary<string, object>();


        // PUT CONSTRUCTORS HERE !!
        private static readonly List<Func<IRobot>> _ctors = new()
        {
            () => new FiveSensorsRobot(),
        };

        public static void GetRobots(Dictionary<string, IRobot> result)
        {
            foreach (var item in _ctors)
            {
                IRobot r = item.Invoke();
                result[r.GetType().ToString()] = r;
            }
        }

        public void AddMethod((string methodName, object method) keyValue)
        {
            Methods[keyValue.methodName] = keyValue.method;
        }

        public void AddProperty((string propertyName, object property) keyValue)
        {
            Properties[keyValue.propertyName] = keyValue.property;
        }

    }
}
