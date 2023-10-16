using ServiceContracts;
namespace Services;

public class CitiesService : ICitiesService
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
    }

    public List<string> GetCities()
    {
        return _cities;
    }
}
