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


namespace Opal.NetApiExt.Generated.Model.pallet_evm.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Log
        /// Ethereum events from contracts.
        /// </summary>
        Log = 0,
        
        /// <summary>
        /// >> Created
        /// A contract has been created at given address.
        /// </summary>
        Created = 1,
        
        /// <summary>
        /// >> CreatedFailed
        /// A contract was attempted to be created, but the execution failed.
        /// </summary>
        CreatedFailed = 2,
        
        /// <summary>
        /// >> Executed
        /// A contract has been executed successfully with states applied.
        /// </summary>
        Executed = 3,
        
        /// <summary>
        /// >> ExecutedFailed
        /// A contract has been executed with errors. States are reverted with only gas fees applied.
        /// </summary>
        ExecutedFailed = 4,
    }
    
    /// <summary>
    /// >> 373 - Variant[pallet_evm.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Opal.NetApiExt.Generated.Model.ethereum.log.Log, Opal.NetApiExt.Generated.Model.primitive_types.H160, Opal.NetApiExt.Generated.Model.primitive_types.H160, Opal.NetApiExt.Generated.Model.primitive_types.H160, Opal.NetApiExt.Generated.Model.primitive_types.H160>
    {
    }
}
