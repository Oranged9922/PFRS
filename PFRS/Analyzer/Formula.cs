
using Common.HardwareRepresentation;

namespace Analyzer;
public class Formula
{
    public delegate void SetupDelegate(IRobotInfo robotInfo);
    public delegate void LoopDelegate(IRobotInfo robotInfo);

    public SetupDelegate Setup = (IRobotInfo robot)  => { };
    public LoopDelegate Loop = (IRobotInfo robot) => { };
}

