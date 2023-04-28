using NetLandApp.Models;

namespace NetLandApp.Services
{
    public interface ICsvService
    {
        IEnumerable<Order> Read(string filePath);
    }
}
