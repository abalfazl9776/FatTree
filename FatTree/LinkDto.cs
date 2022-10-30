namespace FatTree;

public struct LinkDto
{
    public int Node_1 { get; }
    public int Node_2 { get; }

    public LinkDto(int node1, int node2)
    {
        Node_1 = node1;
        Node_2 = node2;
    }
}