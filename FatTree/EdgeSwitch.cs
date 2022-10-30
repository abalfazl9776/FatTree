using System.Text;

namespace FatTree;

public class EdgeSwitch : Node
{
    public byte Pod { get; set; }

    public byte Number { get; set; }
    
    public EdgeSwitch(int id, IP ip, byte pod, byte number) : base(id, ip)
    {
        Pod = pod;
        Number = number;
    }

    public override bool IsConnectedTo(IP ip)
    {
        throw new NotImplementedException();
    }

    public override bool IsConnectedTo(int id)
    {
        throw new NotImplementedException();
    }

    public override void SetOffline()
    {
        throw new NotImplementedException();
    }

    public override void SetOnline()
    {
        throw new NotImplementedException();
    }
}