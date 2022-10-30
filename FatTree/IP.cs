namespace FatTree;

public struct IP
{
    public byte P1 { get; }
    public byte P2 { get; }
    public byte P3 { get; }
    public byte P4 { get; }

    public IP(byte p1, byte p2, byte p3, byte p4)
    {
        P1 = p1;
        P2 = p2;
        P3 = p3;
        P4 = p4;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(P1, P2, P3, P4);
    }

    public override string ToString()
    {
        return $"{P1}.{P2}.{P3}.{P4}";
    }
}