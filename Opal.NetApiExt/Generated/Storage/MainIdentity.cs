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


namespace Substrate.Opal.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> IdentityStorage
    /// </summary>
    public sealed class IdentityStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> IdentityStorage Constructor
        /// </summary>
        public IdentityStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Identity", "IdentityOf"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Identity", "SuperOf"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Identity", "SubsOf"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT25>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Identity", "Registrars"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT26)));
        }
        
        /// <summary>
        /// >> IdentityOfParams
        ///  Information that is pertinent to identify the entity behind an account.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        public static string IdentityOfParams(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Identity", "IdentityOf", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> IdentityOfDefault
        /// Default value as hex string
        /// </summary>
        public static string IdentityOfDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> IdentityOf
        ///  Information that is pertinent to identify the entity behind an account.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        public async Task<Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration> IdentityOf(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = IdentityStorage.IdentityOfParams(key);
            var result = await _client.GetStorageAsync<Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SuperOfParams
        ///  The super-identity of an alternative "sub" identity together with its name, within that
        ///  context. If the account is not some other account's sub-identity, then just `None`.
        /// </summary>
        public static string SuperOfParams(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Identity", "SuperOf", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SuperOfDefault
        /// Default value as hex string
        /// </summary>
        public static string SuperOfDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> SuperOf
        ///  The super-identity of an alternative "sub" identity together with its name, within that
        ///  context. If the account is not some other account's sub-identity, then just `None`.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData>> SuperOf(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = IdentityStorage.SuperOfParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SubsOfParams
        ///  Alternative "sub" identities of this account.
        /// 
        ///  The first item is the deposit, the second is a vector of the accounts.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        public static string SubsOfParams(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Identity", "SubsOf", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SubsOfDefault
        /// Default value as hex string
        /// </summary>
        public static string SubsOfDefault()
        {
            return "0x0000000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> SubsOf
        ///  Alternative "sub" identities of this account.
        /// 
        ///  The first item is the deposit, the second is a vector of the accounts.
        /// 
        ///  TWOX-NOTE: OK ��� `AccountId` is a secure hash.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT25>> SubsOf(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = IdentityStorage.SubsOfParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT25>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> RegistrarsParams
        ///  The set of registrars. Not expected to get very big as can only be added through a
        ///  special origin (likely a council motion).
        /// 
        ///  The index into this can be cast to `RegistrarIndex` to get a valid value.
        /// </summary>
        public static string RegistrarsParams()
        {
            return RequestGenerator.GetStorage("Identity", "Registrars", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> RegistrarsDefault
        /// Default value as hex string
        /// </summary>
        public static string RegistrarsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Registrars
        ///  The set of registrars. Not expected to get very big as can only be added through a
        ///  special origin (likely a council motion).
        /// 
        ///  The index into this can be cast to `RegistrarIndex` to get a valid value.
        /// </summary>
        public async Task<Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT26> Registrars(string blockhash, CancellationToken token)
        {
            string parameters = IdentityStorage.RegistrarsParams();
            var result = await _client.GetStorageAsync<Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT26>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> IdentityCalls
    /// </summary>
    public sealed class IdentityCalls
    {
        
        /// <summary>
        /// >> add_registrar
        /// Identity pallet declaration.
        /// </summary>
        public static Method AddRegistrar(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress account)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(account.Encode());
            return new Method(40, "Identity", 0, "add_registrar", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_identity
        /// Identity pallet declaration.
        /// </summary>
        public static Method SetIdentity(Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.IdentityInfo info)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(info.Encode());
            return new Method(40, "Identity", 1, "set_identity", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_subs
        /// Identity pallet declaration.
        /// </summary>
        public static Method SetSubs(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData>> subs)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(subs.Encode());
            return new Method(40, "Identity", 2, "set_subs", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> clear_identity
        /// Identity pallet declaration.
        /// </summary>
        public static Method ClearIdentity()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(40, "Identity", 3, "clear_identity", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> request_judgement
        /// Identity pallet declaration.
        /// </summary>
        public static Method RequestJudgement(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> reg_index, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> max_fee)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(reg_index.Encode());
            byteArray.AddRange(max_fee.Encode());
            return new Method(40, "Identity", 4, "request_judgement", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cancel_request
        /// Identity pallet declaration.
        /// </summary>
        public static Method CancelRequest(Substrate.NetApi.Model.Types.Primitive.U32 reg_index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(reg_index.Encode());
            return new Method(40, "Identity", 5, "cancel_request", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_fee
        /// Identity pallet declaration.
        /// </summary>
        public static Method SetFee(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> index, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> fee)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(fee.Encode());
            return new Method(40, "Identity", 6, "set_fee", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_account_id
        /// Identity pallet declaration.
        /// </summary>
        public static Method SetAccountId(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> index, Substrate.Opal.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(@new.Encode());
            return new Method(40, "Identity", 7, "set_account_id", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_fields
        /// Identity pallet declaration.
        /// </summary>
        public static Method SetFields(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> index, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.BitFlags fields)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(fields.Encode());
            return new Method(40, "Identity", 8, "set_fields", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> provide_judgement
        /// Identity pallet declaration.
        /// </summary>
        public static Method ProvideJudgement(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> reg_index, Substrate.Opal.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress target, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumJudgement judgement, Substrate.Opal.NET.NetApiExt.Generated.Model.primitive_types.H256 identity)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(reg_index.Encode());
            byteArray.AddRange(target.Encode());
            byteArray.AddRange(judgement.Encode());
            byteArray.AddRange(identity.Encode());
            return new Method(40, "Identity", 9, "provide_judgement", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> kill_identity
        /// Identity pallet declaration.
        /// </summary>
        public static Method KillIdentity(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress target)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(target.Encode());
            return new Method(40, "Identity", 10, "kill_identity", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> add_sub
        /// Identity pallet declaration.
        /// </summary>
        public static Method AddSub(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress sub, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData data)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(sub.Encode());
            byteArray.AddRange(data.Encode());
            return new Method(40, "Identity", 11, "add_sub", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> rename_sub
        /// Identity pallet declaration.
        /// </summary>
        public static Method RenameSub(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress sub, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.EnumData data)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(sub.Encode());
            byteArray.AddRange(data.Encode());
            return new Method(40, "Identity", 12, "rename_sub", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_sub
        /// Identity pallet declaration.
        /// </summary>
        public static Method RemoveSub(Substrate.Opal.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress sub)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(sub.Encode());
            return new Method(40, "Identity", 13, "remove_sub", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> quit_sub
        /// Identity pallet declaration.
        /// </summary>
        public static Method QuitSub()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(40, "Identity", 14, "quit_sub", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_insert_identities
        /// Identity pallet declaration.
        /// </summary>
        public static Method ForceInsertIdentities(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Opal.NET.NetApiExt.Generated.Model.pallet_identity.types.Registration>> identities)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(identities.Encode());
            return new Method(40, "Identity", 15, "force_insert_identities", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_remove_identities
        /// Identity pallet declaration.
        /// </summary>
        public static Method ForceRemoveIdentities(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> identities)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(identities.Encode());
            return new Method(40, "Identity", 16, "force_remove_identities", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_set_subs
        /// Identity pallet declaration.
        /// </summary>
        public static Method ForceSetSubs(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Opal.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4>>> subs)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(subs.Encode());
            return new Method(40, "Identity", 17, "force_set_subs", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> IdentityConstants
    /// </summary>
    public sealed class IdentityConstants
    {
        
        /// <summary>
        /// >> BasicDeposit
        ///  The amount held on deposit for a registered identity
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 BasicDeposit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x0000E8890423C78A0000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> FieldDeposit
        ///  The amount held on deposit per additional field for a registered identity.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 FieldDeposit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x008062175ED158000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> SubAccountDeposit
        ///  The amount held on deposit for a registered subaccount. This should account for the fact
        ///  that one storage item's value will increase by the size of an account ID, and there will
        ///  be another trie item whose value is the size of an account ID plus 32 bytes.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 SubAccountDeposit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x0000C84E676DC11B0000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxSubAccounts
        ///  The maximum number of sub-accounts allowed per identified account.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxSubAccounts()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxAdditionalFields
        ///  Maximum number of additional fields that may be stored in an ID. Needed to bound the I/O
        ///  required to access an identity, but can be pretty high.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxAdditionalFields()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxRegistrars
        ///  Maxmimum number of registrars allowed in the system. Needed to bound the complexity
        ///  of, e.g., updating judgements.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxRegistrars()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x14000000");
            return result;
        }
    }
    
    /// <summary>
    /// >> IdentityErrors
    /// </summary>
    public enum IdentityErrors
    {
        
        /// <summary>
        /// >> TooManySubAccounts
        /// Too many subs-accounts.
        /// </summary>
        TooManySubAccounts,
        
        /// <summary>
        /// >> NotFound
        /// Account isn't found.
        /// </summary>
        NotFound,
        
        /// <summary>
        /// >> NotNamed
        /// Account isn't named.
        /// </summary>
        NotNamed,
        
        /// <summary>
        /// >> EmptyIndex
        /// Empty index.
        /// </summary>
        EmptyIndex,
        
        /// <summary>
        /// >> FeeChanged
        /// Fee is changed.
        /// </summary>
        FeeChanged,
        
        /// <summary>
        /// >> NoIdentity
        /// No identity found.
        /// </summary>
        NoIdentity,
        
        /// <summary>
        /// >> StickyJudgement
        /// Sticky judgement.
        /// </summary>
        StickyJudgement,
        
        /// <summary>
        /// >> JudgementGiven
        /// Judgement given.
        /// </summary>
        JudgementGiven,
        
        /// <summary>
        /// >> InvalidJudgement
        /// Invalid judgement.
        /// </summary>
        InvalidJudgement,
        
        /// <summary>
        /// >> InvalidIndex
        /// The index is invalid.
        /// </summary>
        InvalidIndex,
        
        /// <summary>
        /// >> InvalidTarget
        /// The target is invalid.
        /// </summary>
        InvalidTarget,
        
        /// <summary>
        /// >> TooManyFields
        /// Too many additional fields.
        /// </summary>
        TooManyFields,
        
        /// <summary>
        /// >> TooManyRegistrars
        /// Maximum amount of registrars reached. Cannot add any more.
        /// </summary>
        TooManyRegistrars,
        
        /// <summary>
        /// >> AlreadyClaimed
        /// Account ID is already named.
        /// </summary>
        AlreadyClaimed,
        
        /// <summary>
        /// >> NotSub
        /// Sender is not a sub-account.
        /// </summary>
        NotSub,
        
        /// <summary>
        /// >> NotOwned
        /// Sub-account isn't owned by sender.
        /// </summary>
        NotOwned,
        
        /// <summary>
        /// >> JudgementForDifferentIdentity
        /// The provided judgement was for a different identity.
        /// </summary>
        JudgementForDifferentIdentity,
        
        /// <summary>
        /// >> JudgementPaymentFailed
        /// Error that occurs when there is an issue paying for judgement.
        /// </summary>
        JudgementPaymentFailed,
    }
}
