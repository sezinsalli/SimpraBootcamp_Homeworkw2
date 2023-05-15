using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SimpraHomework.Service.Exceptions
{
    public class ClientSideException:Exception
    {
        public ClientSideException(string message) : base(message)
        {
            
        }
    }
}
