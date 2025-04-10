
using AshesMapBib.Models.AccountModels;
using AshesMapBib.Models.AccountModels.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.DataFactory
{
    public interface IHasher
    {
        UserProfile ToProfile(UserProfileView from);
        UserProfileView ToProfileView(UserProfile from);

    }
}
