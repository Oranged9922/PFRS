using Common.HardwareRepresentation;
using Common;
namespace Simulator
{
    public struct SimulationFrame
    {
        public RobotCoordinates RobotCoordinates;
        public float[] sensorsReadings;
        public SimulationFrame(IRobot robot, int frameNumber)
        {
            sensorsReadings= new float[robot.RobotInfo.Sensors.Count];
            FrameNumber = frameNumber;
            this.RobotCoordinates = robot.RobotCoordinates;

            for (int i = 0; i < robot.RobotInfo.Sensors.Count; i++)
            {
                sensorsReadings[i] = robot.RobotInfo.Sensors[i].GetReading();
            }
        }

        public int FrameNumber { get; internal set; }

    }
}
