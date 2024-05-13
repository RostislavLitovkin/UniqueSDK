//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_common.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> CollectionCreated
        /// New collection was created
        /// </summary>
        CollectionCreated = 0,
        
        /// <summary>
        /// >> CollectionDestroyed
        /// New collection was destroyed
        /// </summary>
        CollectionDestroyed = 1,
        
        /// <summary>
        /// >> ItemCreated
        /// New item was created.
        /// </summary>
        ItemCreated = 2,
        
        /// <summary>
        /// >> ItemDestroyed
        /// Collection item was burned.
        /// </summary>
        ItemDestroyed = 3,
        
        /// <summary>
        /// >> Transfer
        /// Item was transferred
        /// </summary>
        Transfer = 4,
        
        /// <summary>
        /// >> Approved
        /// Amount pieces of token owned by `sender` was approved for `spender`.
        /// </summary>
        Approved = 5,
        
        /// <summary>
        /// >> ApprovedForAll
        /// A `sender` approves operations on all owned tokens for `spender`.
        /// </summary>
        ApprovedForAll = 6,
        
        /// <summary>
        /// >> CollectionPropertySet
        /// The colletion property has been added or edited.
        /// </summary>
        CollectionPropertySet = 7,
        
        /// <summary>
        /// >> CollectionPropertyDeleted
        /// The property has been deleted.
        /// </summary>
        CollectionPropertyDeleted = 8,
        
        /// <summary>
        /// >> TokenPropertySet
        /// The token property has been added or edited.
        /// </summary>
        TokenPropertySet = 9,
        
        /// <summary>
        /// >> TokenPropertyDeleted
        /// The token property has been deleted.
        /// </summary>
        TokenPropertyDeleted = 10,
        
        /// <summary>
        /// >> PropertyPermissionSet
        /// The token property permission of a collection has been set.
        /// </summary>
        PropertyPermissionSet = 11,
        
        /// <summary>
        /// >> AllowListAddressAdded
        /// Address was added to the allow list.
        /// </summary>
        AllowListAddressAdded = 12,
        
        /// <summary>
        /// >> AllowListAddressRemoved
        /// Address was removed from the allow list.
        /// </summary>
        AllowListAddressRemoved = 13,
        
        /// <summary>
        /// >> CollectionAdminAdded
        /// Collection admin was added.
        /// </summary>
        CollectionAdminAdded = 14,
        
        /// <summary>
        /// >> CollectionAdminRemoved
        /// Collection admin was removed.
        /// </summary>
        CollectionAdminRemoved = 15,
        
        /// <summary>
        /// >> CollectionLimitSet
        /// Collection limits were set.
        /// </summary>
        CollectionLimitSet = 16,
        
        /// <summary>
        /// >> CollectionOwnerChanged
        /// Collection owned was changed.
        /// </summary>
        CollectionOwnerChanged = 17,
        
        /// <summary>
        /// >> CollectionPermissionSet
        /// Collection permissions were set.
        /// </summary>
        CollectionPermissionSet = 18,
        
        /// <summary>
        /// >> CollectionSponsorSet
        /// Collection sponsor was set.
        /// </summary>
        CollectionSponsorSet = 19,
        
        /// <summary>
        /// >> SponsorshipConfirmed
        /// New sponsor was confirm.
        /// </summary>
        SponsorshipConfirmed = 20,
        
        /// <summary>
        /// >> CollectionSponsorRemoved
        /// Collection sponsor was removed.
        /// </summary>
        CollectionSponsorRemoved = 21,
    }
    
    /// <summary>
    /// >> 369 - Variant[pallet_common.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.TokenId, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.TokenId, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.TokenId, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.TokenId, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT12>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT12>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.TokenId, Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT12>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.TokenId, Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT12>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT12>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId, Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.CollectionId>
    {
    }
}
