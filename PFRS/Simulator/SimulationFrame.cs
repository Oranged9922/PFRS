using Common.HardwareRepresentation;
using Common;
namespace Simulator
{
    public struct SimulationFrame
    {
        public RobotCoordinates RobotCoordinates;
        public SimulationFrame(IRobot robot, int frameNumber)
        {
            FrameNumber = frameNumber;
            this.RobotCoordinates = robot.RobotCoordinates;
        }

        public int FrameNumber { get; internal set; }

    }
}
