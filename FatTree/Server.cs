namespace FatTree;

public class Server : Node
{
    public Link Link { get; private set; }

    public Server(int id, IP ip) : base(id, ip)
    {
    }

    public void SetLink(Link link)
    {
        Link = link;
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