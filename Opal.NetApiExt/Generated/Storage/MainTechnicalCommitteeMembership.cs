//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Opal.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> TechnicalCommitteeMembershipStorage
    /// </summary>
    public sealed class TechnicalCommitteeMembershipStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> TechnicalCommitteeMembershipStorage Constructor
        /// </summary>
        public TechnicalCommitteeMembershipStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TechnicalCommitteeMembership", "Members"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT34)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TechnicalCommitteeMembership", "Prime"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32)));
        }
        
        /// <summary>
        /// >> MembersParams
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public static string MembersParams()
        {
            return RequestGenerator.GetStorage("TechnicalCommitteeMembership", "Members", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> MembersDefault
        /// Default value as hex string
        /// </summary>
        public static string MembersDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public async Task<Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT34> Members(string blockhash, CancellationToken token)
        {
            string parameters = TechnicalCommitteeMembershipStorage.MembersParams();
            var result = await _client.GetStorageAsync<Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT34>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> PrimeParams
        ///  The current prime member, if one exists.
        /// </summary>
        public static string PrimeParams()
        {
            return RequestGenerator.GetStorage("TechnicalCommitteeMembership", "Prime", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> PrimeDefault
        /// Default value as hex string
        /// </summary>
        public static string PrimeDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        public async Task<Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Prime(string blockhash, CancellationToken token)
        {
            string parameters = TechnicalCommitteeMembershipStorage.PrimeParams();
            var result = await _client.GetStorageAsync<Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> TechnicalCommitteeMembershipCalls
    /// </summary>
    public sealed class TechnicalCommitteeMembershipCalls
    {
        
        /// <summary>
        /// >> add_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method AddMember(Opal.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(46, "TechnicalCommitteeMembership", 0, "add_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RemoveMember(Opal.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(46, "TechnicalCommitteeMembership", 1, "remove_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> swap_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SwapMember(Opal.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress remove, Opal.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress add)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(remove.Encode());
            byteArray.AddRange(add.Encode());
            return new Method(46, "TechnicalCommitteeMembership", 2, "swap_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> reset_members
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ResetMembers(Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> members)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(members.Encode());
            return new Method(46, "TechnicalCommitteeMembership", 3, "reset_members", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> change_key
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ChangeKey(Opal.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(46, "TechnicalCommitteeMembership", 4, "change_key", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_prime
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetPrime(Opal.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(46, "TechnicalCommitteeMembership", 5, "set_prime", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> clear_prime
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ClearPrime()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(46, "TechnicalCommitteeMembership", 6, "clear_prime", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> TechnicalCommitteeMembershipConstants
    /// </summary>
    public sealed class TechnicalCommitteeMembershipConstants
    {
    }
    
    /// <summary>
    /// >> TechnicalCommitteeMembershipErrors
    /// </summary>
    public enum TechnicalCommitteeMembershipErrors
    {
        
        /// <summary>
        /// >> AlreadyMember
        /// Already a member.
        /// </summary>
        AlreadyMember,
        
        /// <summary>
        /// >> NotMember
        /// Not a member.
        /// </summary>
        NotMember,
        
        /// <summary>
        /// >> TooManyMembers
        /// Too many members.
        /// </summary>
        TooManyMembers,
    }
}
