//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Opal.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IAuraExtStorage interface definition.
    /// </summary>
    public interface IAuraExtStorage : IStorage
    {
        
        /// <summary>
        /// >> Authorities
        ///  Serves as cache for the authorities.
        /// 
        ///  The authorities in AuRa are overwritten in `on_initialize` when we switch to a new session,
        ///  but we require the old authorities to verify the seal when validating a PoV. This will
        ///  always be updated to the latest AuRa authorities in `on_finalize`.
        /// </summary>
        Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19 GetAuthorities();
        
        /// <summary>
        /// >> SlotInfo
        ///  Current slot paired with a number of authored blocks.
        /// 
        ///  Updated on each block initialization.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32> GetSlotInfo();
    }
    
    /// <summary>
    /// AuraExtStorage class definition.
    /// </summary>
    public sealed class AuraExtStorage : IAuraExtStorage
    {
        
        /// <summary>
        /// _authoritiesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19> _authoritiesTypedStorage;
        
        /// <summary>
        /// _slotInfoTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32>> _slotInfoTypedStorage;
        
        /// <summary>
        /// AuraExtStorage constructor.
        /// </summary>
        public AuraExtStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.AuthoritiesTypedStorage = new TypedStorage<Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19>("AuraExt.Authorities", storageDataProvider, storageChangeDelegates);
            this.SlotInfoTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32>>("AuraExt.SlotInfo", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _authoritiesTypedStorage property
        /// </summary>
        public TypedStorage<Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19> AuthoritiesTypedStorage
        {
            get
            {
                return _authoritiesTypedStorage;
            }
            set
            {
                _authoritiesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _slotInfoTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32>> SlotInfoTypedStorage
        {
            get
            {
                return _slotInfoTypedStorage;
            }
            set
            {
                _slotInfoTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await AuthoritiesTypedStorage.InitializeAsync("AuraExt", "Authorities");
            await SlotInfoTypedStorage.InitializeAsync("AuraExt", "SlotInfo");
        }
        
        /// <summary>
        /// Implements any storage change for AuraExt.Authorities
        /// </summary>
        [StorageChange("AuraExt", "Authorities")]
        public void OnUpdateAuthorities(string data)
        {
            AuthoritiesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Authorities
        ///  Serves as cache for the authorities.
        /// 
        ///  The authorities in AuRa are overwritten in `on_initialize` when we switch to a new session,
        ///  but we require the old authorities to verify the seal when validating a PoV. This will
        ///  always be updated to the latest AuRa authorities in `on_finalize`.
        /// </summary>
        public Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19 GetAuthorities()
        {
            return AuthoritiesTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for AuraExt.SlotInfo
        /// </summary>
        [StorageChange("AuraExt", "SlotInfo")]
        public void OnUpdateSlotInfo(string data)
        {
            SlotInfoTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> SlotInfo
        ///  Current slot paired with a number of authored blocks.
        /// 
        ///  Updated on each block initialization.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.sp_consensus_slots.Slot, Substrate.NetApi.Model.Types.Primitive.U32> GetSlotInfo()
        {
            return SlotInfoTypedStorage.Get();
        }
    }
}
