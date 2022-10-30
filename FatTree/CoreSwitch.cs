namespace FatTree;

public class CoreSwitch : Node
{
    private readonly List<Link> _links;
    public IReadOnlyCollection<Link> Links => _links.AsReadOnly();
    
    public CoreSwitch(int id, IP ip) : base(id, ip)
    {
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