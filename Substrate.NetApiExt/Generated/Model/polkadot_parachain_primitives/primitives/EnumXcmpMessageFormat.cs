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


namespace Substrate.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives
{
    
    
    /// <summary>
    /// >> XcmpMessageFormat
    /// </summary>
    public enum XcmpMessageFormat
    {
        
        /// <summary>
        /// >> ConcatenatedVersionedXcm
        /// </summary>
        ConcatenatedVersionedXcm = 0,
        
        /// <summary>
        /// >> ConcatenatedEncodedBlob
        /// </summary>
        ConcatenatedEncodedBlob = 1,
        
        /// <summary>
        /// >> Signals
        /// </summary>
        Signals = 2,
    }
    
    /// <summary>
    /// >> 546 - Variant[polkadot_parachain_primitives.primitives.XcmpMessageFormat]
    /// </summary>
    public sealed class EnumXcmpMessageFormat : BaseEnum<XcmpMessageFormat>
    {
    }
}
