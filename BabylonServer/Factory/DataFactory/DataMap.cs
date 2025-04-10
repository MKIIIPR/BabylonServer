
using AshesMapBib.Models.AccountModels;
using AshesMapBib.Models.AccountModels.ClientModel;
using AutoMapper;
using HashidsNet;

namespace ADataAcces.Mapping
{
    public class DataMap :Profile
    {
        public Hashids hashids=new Hashids("ArschKeksGesicht", 6);


        public DataMap()
        {
            #region ComServer
            //CreateMap<ComServerView, ComServer>()
            //    .BeforeMap((src, dest) =>
            //    {
                    
                    
            //        dest.HubConnectionId = hashids.Decode(src.Connection)[0];
            //        dest.KrakenUserId = hashids.Decode(src.CreatedBy)[0];
            //        dest.Id = hashids.Decode(src.Id)[0];
            //    });
                
            //CreateMap<ComServer, ComServerView>()
            //    .AfterMap((src, dest) =>
            //    {
                    
            //        dest.Connection = hashids.Encode((int)src.HubConnectionId);
            //        dest.CreatedBy = hashids.Encode((int)src.KrakenUserId);
            //        dest.Id = hashids.Encode(src.Id);
            //    });
            #endregion

            #region ServerChannel

             //CreateMap<ServerChannelView, ServerChannel>()
             //   .BeforeMap((src, dest) =>
             //   {
             //       try
             //       {
             //           dest.Id = hashids.Decode(src.Id)[0];
             //           dest.ChannelConnectionId = hashids.Decode(src.ChannelConnectionId)[0];
             //       }
             //       catch (IndexOutOfRangeException ex)
             //       {
             //           Console.WriteLine("konnte nicht übersetzt werdenwerte auf 0 gesetzt");
             //           src.Id = "0"; src.ChannelConnectionId = "0";
             //           dest.Id = new(); ;
             //           dest.ChannelConnectionId = new();
             //       }
                    
             //   });

             //CreateMap<ServerChannel, ServerChannelView>()
             //    .AfterMap((src, dest) =>
             //    {                     
             //        dest.Id = hashids.Encode(src.Id);
             //        dest.ChannelConnectionId = hashids.Encode((int)src.ChannelConnectionId);
             //    });

            #endregion

            #region HubConnection


            //CreateMap<ChannelConnectionView, ChannelConnection>()
            //    .BeforeMap((src, dest) =>
            //    {
            //        var x = hashids.Decode(src.Id)[0];
            //        dest.Id = hashids.Decode(src.Id)[0];
            //    });
            //CreateMap<ChannelConnection, ChannelConnectionView>()
            //    .BeforeMap((src, dest) =>
            //    {
            //        dest.Id = hashids.Encode(src.Id);
            //    });


            #endregion

            #region ComServerRole

            // CreateMap<ComServerRoleView, ComServerRole>()
            //    .BeforeMap((src, dest) =>
            //    {
            //        dest.Id = hashids.Decode(src.Id)[0];
            //    });

            //CreateMap<ComServerRole, ComServerRoleView>()
            //    .BeforeMap((src, dest) =>
            //    {
                    
            //        dest.Id = hashids.Encode(src.Id);
            //    });

            #endregion

            #region UserProfiles
            CreateMap<UserProfile, UserProfileView>()
                .AfterMap((src, dest) =>
                {
                    try
                    {
                        dest.Id = hashids.Encode(src.Id);
                        dest.KrakenClientId = hashids.Encode(src.KrakenClientId);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {

                    }
                    
                });
            CreateMap<UserProfileView, UserProfile>()
                .BeforeMap((src, dest) =>
                {

                    var x = hashids.Decode(src.Id);

                    if (src.Id == ""|| src.Id=="string")
                    { dest.Id = 0; }
                    else 
                    { dest.Id = hashids.Decode(src.Id)[0];}

                    dest.KrakenClientId = hashids.Decode(src.KrakenClientId)[0];


                })
                .AfterMap((src, dest) =>
                {

                    var x = hashids.Decode(src.Id);

                    if (src.Id == "" || src.Id == "string")
                    { dest.Id = 0; }
                    else
                    { dest.Id = hashids.Decode(src.Id)[0]; }

                    dest.KrakenClientId = hashids.Decode(src.KrakenClientId)[0];


                });             
            #endregion

            #region Client
            CreateMap<BabylonClient, KrakenClientView>()
                    .BeforeMap((src, dest) =>
                    {
                        dest.Id = hashids.Encode(src.Id);
                    })
                    .AfterMap((src, dest) =>
                        {
                            dest.Id = hashids.Encode(src.Id);
                        });

            CreateMap<KrakenClientView, BabylonClient>()
        .BeforeMap((src, dest) =>
        {
            dest.Id = hashids.Decode(src.Id)[0];
        });
            #endregion

   
        }

    }
}
