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


namespace Opal.NetApiExt.Generated.Model.pallet_preimage.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> TooBig
        /// Preimage is too large to store on-chain.
        /// </summary>
        TooBig = 0,
        
        /// <summary>
        /// >> AlreadyNoted
        /// Preimage has already been noted on-chain.
        /// </summary>
        AlreadyNoted = 1,
        
        /// <summary>
        /// >> NotAuthorized
        /// The user is not authorized to perform this action.
        /// </summary>
        NotAuthorized = 2,
        
        /// <summary>
        /// >> NotNoted
        /// The preimage cannot be removed since it has not yet been noted.
        /// </summary>
        NotNoted = 3,
        
        /// <summary>
        /// >> Requested
        /// A preimage may not be removed when there are outstanding requests.
        /// </summary>
        Requested = 4,
        
        /// <summary>
        /// >> NotRequested
        /// The preimage request cannot be removed since no outstanding requests exist.
        /// </summary>
        NotRequested = 5,
        
        /// <summary>
        /// >> TooMany
        /// More than `MAX_HASH_UPGRADE_BULK_COUNT` hashes were requested to be upgraded at once.
        /// </summary>
        TooMany = 6,
        
        /// <summary>
        /// >> TooFew
        /// Too few hashes were requested to be upgraded (i.e. zero).
        /// </summary>
        TooFew = 7,
    }
    
    /// <summary>
    /// >> 487 - Variant[pallet_preimage.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
