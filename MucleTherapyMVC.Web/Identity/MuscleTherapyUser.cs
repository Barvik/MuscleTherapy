using Microsoft.AspNet.Identity;

namespace MucleTherapyMVC.Web.Identity
{
    public class MuscleTherapyUser : IUser
    {
        public string Id { get; private set; }
        public string UserName { get; set; }
    }
}