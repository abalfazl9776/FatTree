namespace FatTree;

public class AggregateSwitch : Node
{
    public int Pod { get; set; }

    public int Number { get; set; }
    
    public AggregateSwitch(int id, IP ip, int pod, int number) : base(id, ip)
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