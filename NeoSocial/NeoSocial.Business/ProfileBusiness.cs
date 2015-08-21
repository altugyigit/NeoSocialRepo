using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoSocial.Database.Models;
using NeoSocial.Database.IUnitOfWork;
using NeoSocial.Database.Repository;

namespace NeoSocial.Business
{
    interface IProfileBusiness
    {
        UserProfile getProfileInfo();
    }
    public class ProfileBusiness:IProfileBusiness
    {
        UserContext _userContext;
        UserProfile _userProfile;

        public ProfileBusiness()
        {
            _userContext = new UserContext(new DbContextFactory());
        }

        public UserProfile getProfileInfo(int userId)
        {
            _userProfile = new UserProfile();

            _userContext.UserProfileRepository.Find(a => a.UserID == userId);

            return _userProfile; 
        }
    }
}
