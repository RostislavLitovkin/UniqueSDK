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


namespace Opal.NetApiExt.Generated.Model.pallet_collator_selection.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> TooManyCandidates
        /// Too many candidates
        /// </summary>
        TooManyCandidates = 0,
        
        /// <summary>
        /// >> Unknown
        /// Unknown error
        /// </summary>
        Unknown = 1,
        
        /// <summary>
        /// >> Permission
        /// Permission issue
        /// </summary>
        Permission = 2,
        
        /// <summary>
        /// >> AlreadyHoldingLicense
        /// User already holds license to collate
        /// </summary>
        AlreadyHoldingLicense = 3,
        
        /// <summary>
        /// >> NoLicense
        /// User does not hold a license to collate
        /// </summary>
        NoLicense = 4,
        
        /// <summary>
        /// >> AlreadyCandidate
        /// User is already a candidate
        /// </summary>
        AlreadyCandidate = 5,
        
        /// <summary>
        /// >> NotCandidate
        /// User is not a candidate
        /// </summary>
        NotCandidate = 6,
        
        /// <summary>
        /// >> TooManyInvulnerables
        /// Too many invulnerables
        /// </summary>
        TooManyInvulnerables = 7,
        
        /// <summary>
        /// >> TooFewInvulnerables
        /// Too few invulnerables
        /// </summary>
        TooFewInvulnerables = 8,
        
        /// <summary>
        /// >> AlreadyInvulnerable
        /// User is already an Invulnerable
        /// </summary>
        AlreadyInvulnerable = 9,
        
        /// <summary>
        /// >> NotInvulnerable
        /// User is not an Invulnerable
        /// </summary>
        NotInvulnerable = 10,
        
        /// <summary>
        /// >> NoAssociatedValidatorId
        /// Account has no associated validator ID
        /// </summary>
        NoAssociatedValidatorId = 11,
        
        /// <summary>
        /// >> ValidatorNotRegistered
        /// Validator ID is not yet registered
        /// </summary>
        ValidatorNotRegistered = 12,
    }
    
    /// <summary>
    /// >> 432 - Variant[pallet_collator_selection.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
