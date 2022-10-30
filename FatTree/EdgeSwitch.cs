using System.Text;

namespace FatTree;

public class EdgeSwitch : Node
{
    public byte Pod { get; }
    public byte Number { get; }
    private readonly List<Link> _links;
    public IReadOnlyCollection<Link> Links => _links.AsReadOnly();
    
    public EdgeSwitch(int id, IP ip, byte pod, byte number) : base(id, ip)
    {
        Pod = pod;
        Number = number;
        _links = new List<Link>();
    }

    public void AddLink(Link link)
    {
        _links.Add(link);
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