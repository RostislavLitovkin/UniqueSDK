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


namespace Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_foreign_assets
{
    
    
    /// <summary>
    /// >> ForeignCollectionMode
    /// </summary>
    public enum ForeignCollectionMode
    {
        
        /// <summary>
        /// >> NFT
        /// </summary>
        NFT = 0,
        
        /// <summary>
        /// >> Fungible
        /// </summary>
        Fungible = 1,
    }
    
    /// <summary>
    /// >> 332 - Variant[pallet_foreign_assets.ForeignCollectionMode]
    /// </summary>
    public sealed class EnumForeignCollectionMode : BaseEnumExt<ForeignCollectionMode, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U8>
    {
    }
}
