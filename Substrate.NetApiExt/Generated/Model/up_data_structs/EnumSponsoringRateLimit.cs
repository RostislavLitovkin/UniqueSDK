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


namespace Substrate.NetApiExt.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> SponsoringRateLimit
    /// </summary>
    public enum SponsoringRateLimit
    {
        
        /// <summary>
        /// >> SponsoringDisabled
        /// </summary>
        SponsoringDisabled = 0,
        
        /// <summary>
        /// >> Blocks
        /// </summary>
        Blocks = 1,
    }
    
    /// <summary>
    /// >> 279 - Variant[up_data_structs.SponsoringRateLimit]
    /// </summary>
    public sealed class EnumSponsoringRateLimit : BaseEnumExt<SponsoringRateLimit, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U32>
    {
    }
}
