#if FANTASY_SERVER
namespace Fantasy;

public class MachineConfigInfo
{
    public uint Id;
    public string OuterIP;
    public string OuterBindIP;
    public string InnerBindIP;
    public int ManagementPort;
}
#endif
