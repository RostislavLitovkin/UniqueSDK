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


namespace Opal.NetApiExt.Generated.Model.pallet_maintenance.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> MaintenanceEnabled
        /// </summary>
        MaintenanceEnabled = 0,
        
        /// <summary>
        /// >> MaintenanceDisabled
        /// </summary>
        MaintenanceDisabled = 1,
    }
    
    /// <summary>
    /// >> 385 - Variant[pallet_maintenance.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnum<Event>
    {
    }
}
