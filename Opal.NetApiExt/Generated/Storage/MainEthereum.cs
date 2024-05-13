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
    /// >> EthereumStorage
    /// </summary>
    public sealed class EthereumStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> EthereumStorage Constructor
        /// </summary>
        public EthereumStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Ethereum", "Pending"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionV2, Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus, Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Ethereum", "CurrentBlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Opal.NetApiExt.Generated.Model.ethereum.block.Block)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Ethereum", "CurrentReceipts"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Ethereum", "CurrentTransactionStatuses"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Ethereum", "BlockHash"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Opal.NetApiExt.Generated.Model.primitive_types.U256), typeof(Opal.NetApiExt.Generated.Model.primitive_types.H256)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Ethereum", "InjectedNonce"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Opal.NetApiExt.Generated.Model.primitive_types.U256)));
        }
        
        /// <summary>
        /// >> PendingParams
        ///  Current building block's transactions and receipts.
        /// </summary>
        public static string PendingParams()
        {
            return RequestGenerator.GetStorage("Ethereum", "Pending", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> PendingDefault
        /// Default value as hex string
        /// </summary>
        public static string PendingDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Pending
        ///  Current building block's transactions and receipts.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionV2, Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus, Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>>> Pending(string blockhash, CancellationToken token)
        {
            string parameters = EthereumStorage.PendingParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionV2, Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus, Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CurrentBlockParams
        ///  The current Ethereum block.
        /// </summary>
        public static string CurrentBlockParams()
        {
            return RequestGenerator.GetStorage("Ethereum", "CurrentBlock", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CurrentBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string CurrentBlockDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CurrentBlock
        ///  The current Ethereum block.
        /// </summary>
        public async Task<Opal.NetApiExt.Generated.Model.ethereum.block.Block> CurrentBlock(string blockhash, CancellationToken token)
        {
            string parameters = EthereumStorage.CurrentBlockParams();
            var result = await _client.GetStorageAsync<Opal.NetApiExt.Generated.Model.ethereum.block.Block>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CurrentReceiptsParams
        ///  The current Ethereum receipts.
        /// </summary>
        public static string CurrentReceiptsParams()
        {
            return RequestGenerator.GetStorage("Ethereum", "CurrentReceipts", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CurrentReceiptsDefault
        /// Default value as hex string
        /// </summary>
        public static string CurrentReceiptsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CurrentReceipts
        ///  The current Ethereum receipts.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>> CurrentReceipts(string blockhash, CancellationToken token)
        {
            string parameters = EthereumStorage.CurrentReceiptsParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CurrentTransactionStatusesParams
        ///  The current transaction statuses.
        /// </summary>
        public static string CurrentTransactionStatusesParams()
        {
            return RequestGenerator.GetStorage("Ethereum", "CurrentTransactionStatuses", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CurrentTransactionStatusesDefault
        /// Default value as hex string
        /// </summary>
        public static string CurrentTransactionStatusesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CurrentTransactionStatuses
        ///  The current transaction statuses.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus>> CurrentTransactionStatuses(string blockhash, CancellationToken token)
        {
            string parameters = EthereumStorage.CurrentTransactionStatusesParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> BlockHashParams
        /// </summary>
        public static string BlockHashParams(Opal.NetApiExt.Generated.Model.primitive_types.U256 key)
        {
            return RequestGenerator.GetStorage("Ethereum", "BlockHash", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> BlockHashDefault
        /// Default value as hex string
        /// </summary>
        public static string BlockHashDefault()
        {
            return "0x0000000000000000000000000000000000000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> BlockHash
        /// </summary>
        public async Task<Opal.NetApiExt.Generated.Model.primitive_types.H256> BlockHash(Opal.NetApiExt.Generated.Model.primitive_types.U256 key, string blockhash, CancellationToken token)
        {
            string parameters = EthereumStorage.BlockHashParams(key);
            var result = await _client.GetStorageAsync<Opal.NetApiExt.Generated.Model.primitive_types.H256>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> InjectedNonceParams
        ///  Injected transactions should have unique nonce, here we store current
        /// </summary>
        public static string InjectedNonceParams()
        {
            return RequestGenerator.GetStorage("Ethereum", "InjectedNonce", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> InjectedNonceDefault
        /// Default value as hex string
        /// </summary>
        public static string InjectedNonceDefault()
        {
            return "0x0000000000000000000000000000000000000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> InjectedNonce
        ///  Injected transactions should have unique nonce, here we store current
        /// </summary>
        public async Task<Opal.NetApiExt.Generated.Model.primitive_types.U256> InjectedNonce(string blockhash, CancellationToken token)
        {
            string parameters = EthereumStorage.InjectedNonceParams();
            var result = await _client.GetStorageAsync<Opal.NetApiExt.Generated.Model.primitive_types.U256>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> EthereumCalls
    /// </summary>
    public sealed class EthereumCalls
    {
        
        /// <summary>
        /// >> transact
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Transact(Opal.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionV2 transaction)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(transaction.Encode());
            return new Method(101, "Ethereum", 0, "transact", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> EthereumConstants
    /// </summary>
    public sealed class EthereumConstants
    {
    }
    
    /// <summary>
    /// >> EthereumErrors
    /// </summary>
    public enum EthereumErrors
    {
        
        /// <summary>
        /// >> InvalidSignature
        /// Signature is invalid.
        /// </summary>
        InvalidSignature,
        
        /// <summary>
        /// >> PreLogExists
        /// Pre-log is present, therefore transact is not allowed.
        /// </summary>
        PreLogExists,
    }
}