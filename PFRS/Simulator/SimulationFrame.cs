using Common.HardwareRepresentation;
using Common;
using Utils.Vector;

namespace Simulator
{
    public struct SimulationFrame
    {
        public RobotCoordinates RobotCoordinates;

        // just for debugging purposes
        public Vector2[] SensorsCoordinates;
        public int[] MotorsSpeed;
        public float[] SensorsReadings;
        public SimulationFrame(IRobot robot, int frameNumber)
        {
            SensorsReadings= new float[robot.RobotInfo.Sensors.Count];
            FrameNumber = frameNumber;
            MotorsSpeed = robot.MotorsSpeed;
            this.RobotCoordinates = robot.RobotCoordinates;
            this.SensorsCoordinates = robot.SensorsCoordinates;
            for (int i = 0; i < robot.RobotInfo.Sensors.Count; i++)
            {
                SensorsReadings[i] = robot.RobotInfo.Sensors[i].GetReading();
            }
        }

        public int FrameNumber { get; internal set; }

    }
}
