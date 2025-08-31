using PraticeAPI.Service.Interface;

namespace PraticeAPI.Service
{
    public class GreetingService : PraticeAPI.Service.Interface.IGreetingService
    {
        public string GetGreeting(string name)
        {
            return "Hello " + name;
        }

    }
}