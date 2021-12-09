
using Common.HardwareRepresentation;

namespace Analyzer;
public class Formula
{
    public delegate void SetupDelegate(IRobot robot);
    public delegate void LoopDelegate(IRobot robot);

    public SetupDelegate Setup = (IRobot robot)  => { };
    public LoopDelegate Loop = (IRobot robot) => { };
}

