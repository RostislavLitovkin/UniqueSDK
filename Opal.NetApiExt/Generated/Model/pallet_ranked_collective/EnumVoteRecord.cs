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


namespace Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_ranked_collective
{
    
    
    /// <summary>
    /// >> VoteRecord
    /// </summary>
    public enum VoteRecord
    {
        
        /// <summary>
        /// >> Aye
        /// </summary>
        Aye = 0,
        
        /// <summary>
        /// >> Nay
        /// </summary>
        Nay = 1,
    }
    
    /// <summary>
    /// >> 80 - Variant[pallet_ranked_collective.VoteRecord]
    /// </summary>
    public sealed class EnumVoteRecord : BaseEnumExt<VoteRecord, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>
    {
    }
}
