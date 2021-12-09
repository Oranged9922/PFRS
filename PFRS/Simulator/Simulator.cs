using Analyzer;
using Common.HardwareRepresentation;
using Simulator.SceneRepresentation;

namespace Simulator
{
    public static class Simulator
    {

        public static List<SimulationFrame> Simulate(int simulateFor = 5, int fps = 30, Formula.SetupDelegate setupDelegate = null, Formula.LoopDelegate loopDelegate = null, IRobot robot = null)
        {
            List<SimulationFrame> frames = new();
            setupDelegate.Invoke(robot);
            for (int i = 0; i < simulateFor*fps; i++)
            {
                loopDelegate.Invoke(robot);

                frames.Add(new SimulationFrame(robot, i+1));
            }
            return frames;
        }
    }
}