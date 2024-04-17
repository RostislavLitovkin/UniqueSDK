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


namespace Substrate.NetApiExt.Generated.Model.cumulus_pallet_parachain_system.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> ValidationFunctionStored
        /// The validation function has been scheduled to apply.
        /// </summary>
        ValidationFunctionStored = 0,
        
        /// <summary>
        /// >> ValidationFunctionApplied
        /// The validation function was applied as of the contained relay chain block number.
        /// </summary>
        ValidationFunctionApplied = 1,
        
        /// <summary>
        /// >> ValidationFunctionDiscarded
        /// The relay-chain aborted the upgrade process.
        /// </summary>
        ValidationFunctionDiscarded = 2,
        
        /// <summary>
        /// >> UpgradeAuthorized
        /// An upgrade has been authorized.
        /// </summary>
        UpgradeAuthorized = 3,
        
        /// <summary>
        /// >> DownwardMessagesReceived
        /// Some downward messages have been received and will be processed.
        /// </summary>
        DownwardMessagesReceived = 4,
        
        /// <summary>
        /// >> DownwardMessagesProcessed
        /// Downward messages were processed using the given weight.
        /// </summary>
        DownwardMessagesProcessed = 5,
        
        /// <summary>
        /// >> UpwardMessageSent
        /// An upward message was sent to the relay chain.
        /// </summary>
        UpwardMessageSent = 6,
    }
    
    /// <summary>
    /// >> 33 - Variant[cumulus_pallet_parachain_system.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U32, BaseVoid, Substrate.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApiExt.Generated.Model.primitive_types.H256>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApiExt.Generated.Types.Base.Arr32U8>>
    {
    }
}
