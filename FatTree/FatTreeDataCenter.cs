namespace FatTree;

public class FatTreeDataCenter
{
    public byte K { get; }
    private int _coreSwitchesCount;
    private int _aggregateSwitchesCount;
    private int _edgeSwitchesCount;
    private int _serversCount;
    private int _linksCount;
    private List<CoreSwitch> _coreSwitches;
    private List<Server> _servers;
    private List<EdgeSwitch> _edgeSwitches;
    private List<AggregateSwitch> _aggregateSwitches;
    private const byte P1 = 10;
    private const byte PodP4 = 1;

    public FatTreeDataCenter(byte k)
    {
        K = k;
        _coreSwitchesCount = (k / 2) * (k / 2);
        _aggregateSwitchesCount = (k / 2) * (k);
        _edgeSwitchesCount = _aggregateSwitchesCount;
        _serversCount = (k * k * k) / 4;
        _linksCount = 3 * (k * k * k) / 4;
        Build();
    }

    private void Build()
    {
        _servers = new List<Server>(_serversCount);
        _edgeSwitches = new List<EdgeSwitch>(_edgeSwitchesCount);
        _aggregateSwitches = new List<AggregateSwitch>(_aggregateSwitchesCount);
        _coreSwitches = new List<CoreSwitch>(_coreSwitchesCount);

        var id = 0;
        var edgeStartId = _serversCount;
        var aggregateStartId = _serversCount + _edgeSwitchesCount;
        var coreStartId = aggregateStartId + _aggregateSwitchesCount;
        for (byte j = 1; j <= K / 2; j++)
        {
            for (byte i = 1; i <= K / 2; i++)
            {
                _coreSwitches.Add(new CoreSwitch(id: coreStartId++,
                    ip: new IP(P1, K, j, i)
                ));
            }
        }

        for (byte pod = 0; pod < K; pod++)
        {
            for (byte i = 0; i < K / 2; i++)
            {
                _edgeSwitches.Add(new EdgeSwitch(
                    id: edgeStartId++,
                    ip: new IP(P1, pod, i, PodP4),
                    pod: pod,
                    number: i
                ));
                for (byte j = 0; j < K / 2; j++)
                {
                    _servers.Add(new Server(
                        id: id++,
                        ip: new IP(P1, pod, i, Convert.ToByte(j + 2))
                    ));
                }

                _aggregateSwitches.Add(new AggregateSwitch(
                    id: aggregateStartId++,
                    ip: new IP(P1, pod, Convert.ToByte(i + (K / 2)), PodP4),
                    pod: pod,
                    number: i + (K / 2)
                ));
            }
        }
    }
}