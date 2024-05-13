//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Opal.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> AuraExtStorage
    /// </summary>
    public sealed class AuraExtStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> AuraExtStorage Constructor
        /// </summary>
        public AuraExtStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AuraExt", "Authorities"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AuraExt", "SlotInfo"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32>)));
        }
        
        /// <summary>
        /// >> AuthoritiesParams
        ///  Serves as cache for the authorities.
        /// 
        ///  The authorities in AuRa are overwritten in `on_initialize` when we switch to a new session,
        ///  but we require the old authorities to verify the seal when validating a PoV. This will
        ///  always be updated to the latest AuRa authorities in `on_finalize`.
        /// </summary>
        public static string AuthoritiesParams()
        {
            return RequestGenerator.GetStorage("AuraExt", "Authorities", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> AuthoritiesDefault
        /// Default value as hex string
        /// </summary>
        public static string AuthoritiesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Authorities
        ///  Serves as cache for the authorities.
        /// 
        ///  The authorities in AuRa are overwritten in `on_initialize` when we switch to a new session,
        ///  but we require the old authorities to verify the seal when validating a PoV. This will
        ///  always be updated to the latest AuRa authorities in `on_finalize`.
        /// </summary>
        public async Task<Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19> Authorities(string blockhash, CancellationToken token)
        {
            string parameters = AuraExtStorage.AuthoritiesParams();
            var result = await _client.GetStorageAsync<Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SlotInfoParams
        ///  Current slot paired with a number of authored blocks.
        /// 
        ///  Updated on each block initialization.
        /// </summary>
        public static string SlotInfoParams()
        {
            return RequestGenerator.GetStorage("AuraExt", "SlotInfo", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> SlotInfoDefault
        /// Default value as hex string
        /// </summary>
        public static string SlotInfoDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> SlotInfo
        ///  Current slot paired with a number of authored blocks.
        /// 
        ///  Updated on each block initialization.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32>> SlotInfo(string blockhash, CancellationToken token)
        {
            string parameters = AuraExtStorage.SlotInfoParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32>>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> AuraExtCalls
    /// </summary>
    public sealed class AuraExtCalls
    {
    }
    
    /// <summary>
    /// >> AuraExtConstants
    /// </summary>
    public sealed class AuraExtConstants
    {
    }
}
