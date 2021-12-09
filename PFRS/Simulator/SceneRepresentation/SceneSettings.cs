﻿using Common;
using Common.HardwareRepresentation;

namespace Simulator.SceneRepresentation;

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
}
