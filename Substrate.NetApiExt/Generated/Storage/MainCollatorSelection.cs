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


namespace Substrate.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> CollatorSelectionStorage
    /// </summary>
    public sealed class CollatorSelectionStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> CollatorSelectionStorage Constructor
        /// </summary>
        public CollatorSelectionStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "Invulnerables"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "LicenseDepositOf"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "Candidates"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("CollatorSelection", "LastAuthoredBlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
        }
        
        /// <summary>
        /// >> InvulnerablesParams
        ///  The invulnerable, fixed collators.
        /// </summary>
        public static string InvulnerablesParams()
        {
            return RequestGenerator.GetStorage("CollatorSelection", "Invulnerables", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> InvulnerablesDefault
        /// Default value as hex string
        /// </summary>
        public static string InvulnerablesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Invulnerables
        ///  The invulnerable, fixed collators.
        /// </summary>
        public async Task<Substrate.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18> Invulnerables(string blockhash, CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.InvulnerablesParams();
            var result = await _client.GetStorageAsync<Substrate.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> LicenseDepositOfParams
        ///  The (community) collation license holders.
        /// </summary>
        public static string LicenseDepositOfParams(Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("CollatorSelection", "LicenseDepositOf", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> LicenseDepositOfDefault
        /// Default value as hex string
        /// </summary>
        public static string LicenseDepositOfDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> LicenseDepositOf
        ///  The (community) collation license holders.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> LicenseDepositOf(Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.LicenseDepositOfParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CandidatesParams
        ///  The (community, limited) collation candidates.
        /// </summary>
        public static string CandidatesParams()
        {
            return RequestGenerator.GetStorage("CollatorSelection", "Candidates", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CandidatesDefault
        /// Default value as hex string
        /// </summary>
        public static string CandidatesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Candidates
        ///  The (community, limited) collation candidates.
        /// </summary>
        public async Task<Substrate.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18> Candidates(string blockhash, CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.CandidatesParams();
            var result = await _client.GetStorageAsync<Substrate.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> LastAuthoredBlockParams
        ///  Last block authored by collator.
        /// </summary>
        public static string LastAuthoredBlockParams(Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("CollatorSelection", "LastAuthoredBlock", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> LastAuthoredBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string LastAuthoredBlockDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> LastAuthoredBlock
        ///  Last block authored by collator.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> LastAuthoredBlock(Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = CollatorSelectionStorage.LastAuthoredBlockParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> CollatorSelectionCalls
    /// </summary>
    public sealed class CollatorSelectionCalls
    {
        
        /// <summary>
        /// >> add_invulnerable
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method AddInvulnerable(Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(23, "CollatorSelection", 0, "add_invulnerable", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_invulnerable
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RemoveInvulnerable(Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(23, "CollatorSelection", 1, "remove_invulnerable", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> get_license
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method GetLicense()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(23, "CollatorSelection", 2, "get_license", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> onboard
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Onboard()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(23, "CollatorSelection", 3, "onboard", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> offboard
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Offboard()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(23, "CollatorSelection", 4, "offboard", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> release_license
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ReleaseLicense()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(23, "CollatorSelection", 5, "release_license", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_release_license
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ForceReleaseLicense(Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(23, "CollatorSelection", 6, "force_release_license", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> CollatorSelectionConstants
    /// </summary>
    public sealed class CollatorSelectionConstants
    {
    }
    
    /// <summary>
    /// >> CollatorSelectionErrors
    /// </summary>
    public enum CollatorSelectionErrors
    {
        
        /// <summary>
        /// >> TooManyCandidates
        /// Too many candidates
        /// </summary>
        TooManyCandidates,
        
        /// <summary>
        /// >> Unknown
        /// Unknown error
        /// </summary>
        Unknown,
        
        /// <summary>
        /// >> Permission
        /// Permission issue
        /// </summary>
        Permission,
        
        /// <summary>
        /// >> AlreadyHoldingLicense
        /// User already holds license to collate
        /// </summary>
        AlreadyHoldingLicense,
        
        /// <summary>
        /// >> NoLicense
        /// User does not hold a license to collate
        /// </summary>
        NoLicense,
        
        /// <summary>
        /// >> AlreadyCandidate
        /// User is already a candidate
        /// </summary>
        AlreadyCandidate,
        
        /// <summary>
        /// >> NotCandidate
        /// User is not a candidate
        /// </summary>
        NotCandidate,
        
        /// <summary>
        /// >> TooManyInvulnerables
        /// Too many invulnerables
        /// </summary>
        TooManyInvulnerables,
        
        /// <summary>
        /// >> TooFewInvulnerables
        /// Too few invulnerables
        /// </summary>
        TooFewInvulnerables,
        
        /// <summary>
        /// >> AlreadyInvulnerable
        /// User is already an Invulnerable
        /// </summary>
        AlreadyInvulnerable,
        
        /// <summary>
        /// >> NotInvulnerable
        /// User is not an Invulnerable
        /// </summary>
        NotInvulnerable,
        
        /// <summary>
        /// >> NoAssociatedValidatorId
        /// Account has no associated validator ID
        /// </summary>
        NoAssociatedValidatorId,
        
        /// <summary>
        /// >> ValidatorNotRegistered
        /// Validator ID is not yet registered
        /// </summary>
        ValidatorNotRegistered,
    }
}
