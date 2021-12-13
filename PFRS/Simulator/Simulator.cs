using Analyzer;
using Common.HardwareRepresentation;

namespace Simulator
{
    public static class Simulator
    {

        public static List<SimulationFrame> Simulate(
            int simulateFor = 5, 
            int fps = 30, 
            Formula.SetupDelegate setupDelegate = null, 
            Formula.LoopDelegate loopDelegate = null, 
            IRobot robot = null)
        {
            List<SimulationFrame> frames = new();
            // run setup once
            setupDelegate.Invoke(robot.RobotInfo);
            for (int i = 0; i < simulateFor*fps; i++)
            {
                // run loop every time
                loopDelegate.Invoke(robot.RobotInfo);
                // robot.RobotInfo is changed
                robot.Update(fps);
                frames.Add(new SimulationFrame(robot, i+1));
            }
            return frames;
        }
    }
}
