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


namespace Opal.NetApiExt.Generated.Model.pallet_state_trie_migration.pallet
{
    
    
    /// <summary>
    /// >> Progress
    /// </summary>
    public enum Progress
    {
        
        /// <summary>
        /// >> ToStart
        /// </summary>
        ToStart = 0,
        
        /// <summary>
        /// >> LastKey
        /// </summary>
        LastKey = 1,
        
        /// <summary>
        /// >> Complete
        /// </summary>
        Complete = 2,
    }
    
    /// <summary>
    /// >> 93 - Variant[pallet_state_trie_migration.pallet.Progress]
    /// </summary>
    public sealed class EnumProgress : BaseEnumExt<Progress, BaseVoid, Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1, BaseVoid>
    {
    }
}
