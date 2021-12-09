using Common.HardwareRepresentation;

namespace Simulator
{
    public struct SimulationFrame
    {
        public SimulationFrame(IRobot robot, int frameNumber)
        {
            FrameNumber = frameNumber;
        }

        public int FrameNumber { get; internal set; }

    }
}
