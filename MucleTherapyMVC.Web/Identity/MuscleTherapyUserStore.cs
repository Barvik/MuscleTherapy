using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace MucleTherapyMVC.Web.Identity
{
    public class MuscleTherapyUserStore : IUserStore<MuscleTherapyUser>
    {

        private bool _isDisposed;

        public MuscleTherapyUserStore()
        {
            
        }

        public void Dispose()
        {
            _isDisposed = true;
        }

        private void ThrowIfDisposed()
        {
            if (_isDisposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }

        public Task CreateAsync(MuscleTherapyUser user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(MuscleTherapyUser user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(MuscleTherapyUser user)
        {
            throw new NotImplementedException();
        }

        public Task<MuscleTherapyUser> FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<MuscleTherapyUser> FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Claim>> GetClaimsAsync(MuscleTherapyUser user)
        {
            throw new NotImplementedException();
        }

        public Task AddClaimAsync(MuscleTherapyUser user, Claim claim)
        {
            throw new NotImplementedException();
        }

        public Task RemoveClaimAsync(MuscleTherapyUser user, Claim claim)
        {
            throw new NotImplementedException();
        }
    }
}