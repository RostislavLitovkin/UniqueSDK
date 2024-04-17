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
    /// >> EvmContractHelpersStorage
    /// </summary>
    public sealed class EvmContractHelpersStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> EvmContractHelpersStorage Constructor
        /// </summary>
        public EvmContractHelpersStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("EvmContractHelpers", "Owner"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, typeof(Substrate.NetApiExt.Generated.Model.primitive_types.H160), typeof(Substrate.NetApiExt.Generated.Model.primitive_types.H160)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("EvmContractHelpers", "SelfSponsoring"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, typeof(Substrate.NetApiExt.Generated.Model.primitive_types.H160), typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("EvmContractHelpers", "Sponsoring"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApiExt.Generated.Model.primitive_types.H160), typeof(Substrate.NetApiExt.Generated.Model.up_data_structs.EnumSponsorshipState)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("EvmContractHelpers", "SponsoringMode"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, typeof(Substrate.NetApiExt.Generated.Model.primitive_types.H160), typeof(Substrate.NetApiExt.Generated.Model.pallet_evm_contract_helpers.EnumSponsoringModeT)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("EvmContractHelpers", "SponsoringRateLimit"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, typeof(Substrate.NetApiExt.Generated.Model.primitive_types.H160), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("EvmContractHelpers", "SponsoringFeeLimit"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, typeof(Substrate.NetApiExt.Generated.Model.primitive_types.H160), typeof(Substrate.NetApiExt.Generated.Model.bounded_collections.bounded_btree_map.BoundedBTreeMapT4)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("EvmContractHelpers", "SponsorBasket"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApiExt.Generated.Model.primitive_types.H160, Substrate.NetApiExt.Generated.Model.primitive_types.H160>), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("EvmContractHelpers", "AllowlistEnabled"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, typeof(Substrate.NetApiExt.Generated.Model.primitive_types.H160), typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("EvmContractHelpers", "Allowlist"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApiExt.Generated.Model.primitive_types.H160, Substrate.NetApiExt.Generated.Model.primitive_types.H160>), typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
        }
        
        /// <summary>
        /// >> OwnerParams
        ///  Store owner for contract.
        /// 
        ///  * **Key** - contract address.
        ///  * **Value** - owner for contract.
        /// </summary>
        public static string OwnerParams(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key)
        {
            return RequestGenerator.GetStorage("EvmContractHelpers", "Owner", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> OwnerDefault
        /// Default value as hex string
        /// </summary>
        public static string OwnerDefault()
        {
            return "0x0000000000000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> Owner
        ///  Store owner for contract.
        /// 
        ///  * **Key** - contract address.
        ///  * **Value** - owner for contract.
        /// </summary>
        public async Task<Substrate.NetApiExt.Generated.Model.primitive_types.H160> Owner(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key, string blockhash, CancellationToken token)
        {
            string parameters = EvmContractHelpersStorage.OwnerParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApiExt.Generated.Model.primitive_types.H160>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SelfSponsoringParams
        ///  Deprecated: this storage is deprecated
        /// </summary>
        public static string SelfSponsoringParams(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key)
        {
            return RequestGenerator.GetStorage("EvmContractHelpers", "SelfSponsoring", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SelfSponsoringDefault
        /// Default value as hex string
        /// </summary>
        public static string SelfSponsoringDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> SelfSponsoring
        ///  Deprecated: this storage is deprecated
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> SelfSponsoring(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key, string blockhash, CancellationToken token)
        {
            string parameters = EvmContractHelpersStorage.SelfSponsoringParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SponsoringParams
        ///  Store for contract sponsorship state.
        /// 
        ///  * **Key** - contract address.
        ///  * **Value** - sponsorship state.
        /// </summary>
        public static string SponsoringParams(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key)
        {
            return RequestGenerator.GetStorage("EvmContractHelpers", "Sponsoring", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SponsoringDefault
        /// Default value as hex string
        /// </summary>
        public static string SponsoringDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Sponsoring
        ///  Store for contract sponsorship state.
        /// 
        ///  * **Key** - contract address.
        ///  * **Value** - sponsorship state.
        /// </summary>
        public async Task<Substrate.NetApiExt.Generated.Model.up_data_structs.EnumSponsorshipState> Sponsoring(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key, string blockhash, CancellationToken token)
        {
            string parameters = EvmContractHelpersStorage.SponsoringParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApiExt.Generated.Model.up_data_structs.EnumSponsorshipState>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SponsoringModeParams
        ///  Store for sponsoring mode.
        /// 
        ///  ### Usage
        ///  Prefer to delete collection from storage if mode chaged to [`Disabled`](SponsoringModeT::Disabled).
        /// 
        ///  * **Key** - contract address.
        ///  * **Value** - [`sponsoring mode`](SponsoringModeT).
        /// </summary>
        public static string SponsoringModeParams(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key)
        {
            return RequestGenerator.GetStorage("EvmContractHelpers", "SponsoringMode", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SponsoringModeDefault
        /// Default value as hex string
        /// </summary>
        public static string SponsoringModeDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> SponsoringMode
        ///  Store for sponsoring mode.
        /// 
        ///  ### Usage
        ///  Prefer to delete collection from storage if mode chaged to [`Disabled`](SponsoringModeT::Disabled).
        /// 
        ///  * **Key** - contract address.
        ///  * **Value** - [`sponsoring mode`](SponsoringModeT).
        /// </summary>
        public async Task<Substrate.NetApiExt.Generated.Model.pallet_evm_contract_helpers.EnumSponsoringModeT> SponsoringMode(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key, string blockhash, CancellationToken token)
        {
            string parameters = EvmContractHelpersStorage.SponsoringModeParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApiExt.Generated.Model.pallet_evm_contract_helpers.EnumSponsoringModeT>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SponsoringRateLimitParams
        ///  Storage for sponsoring rate limit in blocks.
        /// 
        ///  * **Key** - contract address.
        ///  * **Value** - amount of sponsored blocks.
        /// </summary>
        public static string SponsoringRateLimitParams(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key)
        {
            return RequestGenerator.GetStorage("EvmContractHelpers", "SponsoringRateLimit", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SponsoringRateLimitDefault
        /// Default value as hex string
        /// </summary>
        public static string SponsoringRateLimitDefault()
        {
            return "0x201C0000";
        }
        
        /// <summary>
        /// >> SponsoringRateLimit
        ///  Storage for sponsoring rate limit in blocks.
        /// 
        ///  * **Key** - contract address.
        ///  * **Value** - amount of sponsored blocks.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> SponsoringRateLimit(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key, string blockhash, CancellationToken token)
        {
            string parameters = EvmContractHelpersStorage.SponsoringRateLimitParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SponsoringFeeLimitParams
        ///  Storage for last sponsored block.
        /// 
        ///  * **Key1** - contract address.
        ///  * **Key2** - sponsored user address.
        ///  * **Value** - last sponsored block number.
        /// </summary>
        public static string SponsoringFeeLimitParams(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key)
        {
            return RequestGenerator.GetStorage("EvmContractHelpers", "SponsoringFeeLimit", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SponsoringFeeLimitDefault
        /// Default value as hex string
        /// </summary>
        public static string SponsoringFeeLimitDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> SponsoringFeeLimit
        ///  Storage for last sponsored block.
        /// 
        ///  * **Key1** - contract address.
        ///  * **Key2** - sponsored user address.
        ///  * **Value** - last sponsored block number.
        /// </summary>
        public async Task<Substrate.NetApiExt.Generated.Model.bounded_collections.bounded_btree_map.BoundedBTreeMapT4> SponsoringFeeLimit(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key, string blockhash, CancellationToken token)
        {
            string parameters = EvmContractHelpersStorage.SponsoringFeeLimitParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApiExt.Generated.Model.bounded_collections.bounded_btree_map.BoundedBTreeMapT4>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SponsorBasketParams
        /// </summary>
        public static string SponsorBasketParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApiExt.Generated.Model.primitive_types.H160, Substrate.NetApiExt.Generated.Model.primitive_types.H160> key)
        {
            return RequestGenerator.GetStorage("EvmContractHelpers", "SponsorBasket", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, key.Value);
        }
        
        /// <summary>
        /// >> SponsorBasketDefault
        /// Default value as hex string
        /// </summary>
        public static string SponsorBasketDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> SponsorBasket
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> SponsorBasket(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApiExt.Generated.Model.primitive_types.H160, Substrate.NetApiExt.Generated.Model.primitive_types.H160> key, string blockhash, CancellationToken token)
        {
            string parameters = EvmContractHelpersStorage.SponsorBasketParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> AllowlistEnabledParams
        ///  Storege for contracts with [`Allowlisted`](SponsoringModeT::Allowlisted) sponsoring mode.
        /// 
        ///  ### Usage
        ///  Prefer to delete collection from storage if mode chaged to non `Allowlisted`, than set **Value** to **false**.
        /// 
        ///  * **Key** - contract address.
        ///  * **Value** - is contract in [`Allowlisted`](SponsoringModeT::Allowlisted) mode.
        /// </summary>
        public static string AllowlistEnabledParams(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key)
        {
            return RequestGenerator.GetStorage("EvmContractHelpers", "AllowlistEnabled", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AllowlistEnabledDefault
        /// Default value as hex string
        /// </summary>
        public static string AllowlistEnabledDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> AllowlistEnabled
        ///  Storege for contracts with [`Allowlisted`](SponsoringModeT::Allowlisted) sponsoring mode.
        /// 
        ///  ### Usage
        ///  Prefer to delete collection from storage if mode chaged to non `Allowlisted`, than set **Value** to **false**.
        /// 
        ///  * **Key** - contract address.
        ///  * **Value** - is contract in [`Allowlisted`](SponsoringModeT::Allowlisted) mode.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> AllowlistEnabled(Substrate.NetApiExt.Generated.Model.primitive_types.H160 key, string blockhash, CancellationToken token)
        {
            string parameters = EvmContractHelpersStorage.AllowlistEnabledParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> AllowlistParams
        ///  Storage for users that allowed for sponsorship.
        /// 
        ///  ### Usage
        ///  Prefer to delete record from storage if user no more allowed for sponsorship.
        /// 
        ///  * **Key1** - contract address.
        ///  * **Key2** - user that allowed for sponsorship.
        ///  * **Value** - allowance for sponsorship.
        /// </summary>
        public static string AllowlistParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApiExt.Generated.Model.primitive_types.H160, Substrate.NetApiExt.Generated.Model.primitive_types.H160> key)
        {
            return RequestGenerator.GetStorage("EvmContractHelpers", "Allowlist", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox128}, key.Value);
        }
        
        /// <summary>
        /// >> AllowlistDefault
        /// Default value as hex string
        /// </summary>
        public static string AllowlistDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Allowlist
        ///  Storage for users that allowed for sponsorship.
        /// 
        ///  ### Usage
        ///  Prefer to delete record from storage if user no more allowed for sponsorship.
        /// 
        ///  * **Key1** - contract address.
        ///  * **Key2** - user that allowed for sponsorship.
        ///  * **Value** - allowance for sponsorship.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> Allowlist(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApiExt.Generated.Model.primitive_types.H160, Substrate.NetApiExt.Generated.Model.primitive_types.H160> key, string blockhash, CancellationToken token)
        {
            string parameters = EvmContractHelpersStorage.AllowlistParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> EvmContractHelpersCalls
    /// </summary>
    public sealed class EvmContractHelpersCalls
    {
        
        /// <summary>
        /// >> migrate_from_self_sponsoring
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method MigrateFromSelfSponsoring(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApiExt.Generated.Model.primitive_types.H160> addresses)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(addresses.Encode());
            return new Method(151, "EvmContractHelpers", 0, "migrate_from_self_sponsoring", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> EvmContractHelpersConstants
    /// </summary>
    public sealed class EvmContractHelpersConstants
    {
        
        /// <summary>
        /// >> ContractAddress
        ///  Address, under which magic contract will be available
        /// </summary>
        public Substrate.NetApiExt.Generated.Model.primitive_types.H160 ContractAddress()
        {
            var result = new Substrate.NetApiExt.Generated.Model.primitive_types.H160();
            result.Create("0x842899ECF380553E8A4DE75BF534CDF6FBF64049");
            return result;
        }
    }
    
    /// <summary>
    /// >> EvmContractHelpersErrors
    /// </summary>
    public enum EvmContractHelpersErrors
    {
        
        /// <summary>
        /// >> NoPermission
        /// This method is only executable by contract owner
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> NoPendingSponsor
        /// No pending sponsor for contract.
        /// </summary>
        NoPendingSponsor,
        
        /// <summary>
        /// >> TooManyMethodsHaveSponsoredLimit
        /// Number of methods that sponsored limit is defined for exceeds maximum.
        /// </summary>
        TooManyMethodsHaveSponsoredLimit,
    }
}
