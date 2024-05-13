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


namespace Opal.NetApiExt.Generated.Model.pallet_membership.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> AlreadyMember
        /// Already a member.
        /// </summary>
        AlreadyMember = 0,
        
        /// <summary>
        /// >> NotMember
        /// Not a member.
        /// </summary>
        NotMember = 1,
        
        /// <summary>
        /// >> TooManyMembers
        /// Too many members.
        /// </summary>
        TooManyMembers = 2,
    }
    
    /// <summary>
    /// >> 513 - Variant[pallet_membership.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}