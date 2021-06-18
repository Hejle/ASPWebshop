using ASPWebshop.Services.Interfaces;

namespace ASPWebshop.Services.Implementations
{
    public class InfoService : IInfoService
    {

        public string GetName()
        {
            return "Sebastian";
        }

        public string GetEmail()
        {
            return "name@domain.com";
        }
    }
}