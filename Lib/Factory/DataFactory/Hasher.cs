
using AshesMapBib.Models.AccountModels;
using AshesMapBib.Models.AccountModels.ClientModel;
using HashidsNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.DataFactory
{
    public class Hasher : IHasher
    {
        public Hashids hashids = new Hashids("ArschKeksGesicht", 6);
        public UserProfile ToProfile(UserProfileView from)
        {
            UserProfile to = new();
           
            if (string.IsNullOrWhiteSpace(from.Id) || from.Id == "new")
            { to.Id = 0; }
            else { to.Id = hashids.Decode(from.Id)[0]; }
            
            if (string.IsNullOrWhiteSpace(from.KrakenClientId) || from.KrakenClientId == "new")
            { to.KrakenClientId = 0; }
            else { to.KrakenClientId = hashids.Decode(from.KrakenClientId)[0]; }
            
            
            to.Name=from.Name;
            to.SignalTag=from.SignalTag;
            to.SignalName=from.SignalName;
            to.SignalAvatar=from.SignalAvatar;
            to.SignalFeet=from.SignalFeet;
            to.ServerId=from.ServerId;
            to.IsMainProfile = from.IsMainProfile;

            return to;
        }

        public UserProfileView ToProfileView(UserProfile from)
        {
            UserProfileView to = new();
            to.Id = hashids.Encode(from.Id);
            to.KrakenClientId = hashids.Encode(from.KrakenClientId);
            to.Name = from.Name;
            to.SignalTag = from.SignalTag;
            to.SignalName = from.SignalName;
            to.SignalAvatar = from.SignalAvatar;
            to.SignalFeet = from.SignalFeet;
            to.ServerId = from.ServerId;
            to.IsMainProfile = from.IsMainProfile;

            return to;
        }
    }
}
