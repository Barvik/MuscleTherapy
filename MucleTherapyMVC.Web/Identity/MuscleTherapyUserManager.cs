using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace MucleTherapyMVC.Web.Identity
{
    public class MuscleTherapyUserManager : UserManager<MuscleTherapyUser>
    {
        public MuscleTherapyUserManager(IUserStore<MuscleTherapyUser> store) : base(store)
        {
        }

        public override Task<MuscleTherapyUser> FindAsync(string userName, string password)
        {
            return base.FindAsync(userName, password);
        }
     }
}