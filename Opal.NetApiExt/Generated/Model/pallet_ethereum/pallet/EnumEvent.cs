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


namespace Opal.NetApiExt.Generated.Model.pallet_ethereum.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Executed
        /// An ethereum transaction was successfully executed.
        /// </summary>
        Executed = 0,
    }
    
    /// <summary>
    /// >> 374 - Variant[pallet_ethereum.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Opal.NetApiExt.Generated.Model.primitive_types.H160, Opal.NetApiExt.Generated.Model.primitive_types.H160, Opal.NetApiExt.Generated.Model.primitive_types.H256, Opal.NetApiExt.Generated.Model.evm_core.error.EnumExitReason, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>
    {
    }
}
