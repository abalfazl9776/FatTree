namespace FatTree;

public abstract class Node
{
    public int Id { get; init; }
    public IP IP { get; init; }
    public bool IsOnline { get; private set; }

    protected Node(int id, IP ip)
    {
        Id = id;
        IP = ip;
        IsOnline = true;
    }

    public abstract bool IsConnectedTo(IP ip);
    public abstract bool IsConnectedTo(int id);
    
    public abstract void SetOffline();
    public abstract void SetOnline();
}