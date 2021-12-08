using PFRS.Common;
using PFRS.Common.HardwareRepresentation;
using PFRS.Simulator;
namespace PFRS.Simulator.SceneRepresentation;

public class SceneSettings
{
    public RobotCoordinates RobotCoordinates { get; init; }
    public int DurationInFrames { get; set; }
    public int CurrentFrame { get; init; }
    
    public SceneSettings(Func<IRobot> Loop, SimulationFrame previousFrame, int DurationInFrames)
    {
        CurrentFrame = previousFrame.FrameNumber + 1;
        this.DurationInFrames = DurationInFrames;

    }
    public SceneSettings()
    {

    }
}
