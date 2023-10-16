using ServiceContracts;
namespace Services;

public class CitiesService : ICitiesService, IDisposable
{
    private Guid _serviceInstanceId;
    private List<string> _cities;


    public Guid ServiceInstanceId { get { return _serviceInstanceId; } }
    public CitiesService()
    {
        _serviceInstanceId = Guid.NewGuid();
        _cities = new List<string>(){
            "London",
            "Paris",
            "Torremolinos",
            "Alicante"
        };
        // TO-DO: Add logic to open the db connection
    }

    public List<string> GetCities()
    {
        return _cities;
    }

    public void Dispose()
    {
        // TO-DO: Add logic to close db connection
    }
}
