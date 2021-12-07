using PFRS.Common.SceneRepresentation;

namespace PFRS.Simulator
{
    public class Simulator
    {
        public static List<SimulationFrame> Simulate(SceneSettings sceneSettings, SimulatorScript script)
        {
            List<SimulationFrame> frames = new();
            // first frame is generated with -setup-
            SimulationFrame first = new();
            first.ApplySettings(sceneSettings);
            frames.Add(first);

            for(int i = 0; i < sceneSettings.DurationInFrames; i++) frames.Add(GenerateNextFrame(frames[i - 1], script, sceneSettings.DurationInFrames));
            return frames;
        }

        private static SimulationFrame GenerateNextFrame(SimulationFrame simulationFrame, SimulatorScript script, int totalFrames)
        {
            SimulationFrame frame = new();
            SceneSettings settings = new(script.Loop,simulationFrame, totalFrames);
            frame.ApplySettings(settings);
            return frame;
        }
    }
}