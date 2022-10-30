namespace FatTree;

public class Link
{
    public Node _1 { get; set; }
    public Node _2 { get; set; }

    public Link(Node _1, Node _2)
    {
        this._1 = _1;
        this._2 = _2;
    }
}