//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Opal.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IEthereumStorage interface definition.
    /// </summary>
    public interface IEthereumStorage : IStorage
    {
        
        /// <summary>
        /// >> Pending
        ///  Current building block's transactions and receipts.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionV2, Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus, Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>> GetPending();
        
        /// <summary>
        /// >> CurrentBlock
        ///  The current Ethereum block.
        /// </summary>
        Opal.NetApiExt.Generated.Model.ethereum.block.Block GetCurrentBlock();
        
        /// <summary>
        /// >> CurrentReceipts
        ///  The current Ethereum receipts.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3> GetCurrentReceipts();
        
        /// <summary>
        /// >> CurrentTransactionStatuses
        ///  The current transaction statuses.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus> GetCurrentTransactionStatuses();
        
        /// <summary>
        /// >> BlockHash
        /// </summary>
        Opal.NetApiExt.Generated.Model.primitive_types.H256 GetBlockHash(string key);
        
        /// <summary>
        /// >> InjectedNonce
        ///  Injected transactions should have unique nonce, here we store current
        /// </summary>
        Opal.NetApiExt.Generated.Model.primitive_types.U256 GetInjectedNonce();
    }
    
    /// <summary>
    /// EthereumStorage class definition.
    /// </summary>
    public sealed class EthereumStorage : IEthereumStorage
    {
        
        /// <summary>
        /// _pendingTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionV2, Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus, Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>>> _pendingTypedStorage;
        
        /// <summary>
        /// _currentBlockTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Opal.NetApiExt.Generated.Model.ethereum.block.Block> _currentBlockTypedStorage;
        
        /// <summary>
        /// _currentReceiptsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>> _currentReceiptsTypedStorage;
        
        /// <summary>
        /// _currentTransactionStatusesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus>> _currentTransactionStatusesTypedStorage;
        
        /// <summary>
        /// _blockHashTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Opal.NetApiExt.Generated.Model.primitive_types.H256> _blockHashTypedStorage;
        
        /// <summary>
        /// _injectedNonceTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Opal.NetApiExt.Generated.Model.primitive_types.U256> _injectedNonceTypedStorage;
        
        /// <summary>
        /// EthereumStorage constructor.
        /// </summary>
        public EthereumStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.PendingTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionV2, Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus, Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>>>("Ethereum.Pending", storageDataProvider, storageChangeDelegates);
            this.CurrentBlockTypedStorage = new TypedStorage<Opal.NetApiExt.Generated.Model.ethereum.block.Block>("Ethereum.CurrentBlock", storageDataProvider, storageChangeDelegates);
            this.CurrentReceiptsTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>>("Ethereum.CurrentReceipts", storageDataProvider, storageChangeDelegates);
            this.CurrentTransactionStatusesTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus>>("Ethereum.CurrentTransactionStatuses", storageDataProvider, storageChangeDelegates);
            this.BlockHashTypedStorage = new TypedMapStorage<Opal.NetApiExt.Generated.Model.primitive_types.H256>("Ethereum.BlockHash", storageDataProvider, storageChangeDelegates);
            this.InjectedNonceTypedStorage = new TypedStorage<Opal.NetApiExt.Generated.Model.primitive_types.U256>("Ethereum.InjectedNonce", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _pendingTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionV2, Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus, Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>>> PendingTypedStorage
        {
            get
            {
                return _pendingTypedStorage;
            }
            set
            {
                _pendingTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _currentBlockTypedStorage property
        /// </summary>
        public TypedStorage<Opal.NetApiExt.Generated.Model.ethereum.block.Block> CurrentBlockTypedStorage
        {
            get
            {
                return _currentBlockTypedStorage;
            }
            set
            {
                _currentBlockTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _currentReceiptsTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>> CurrentReceiptsTypedStorage
        {
            get
            {
                return _currentReceiptsTypedStorage;
            }
            set
            {
                _currentReceiptsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _currentTransactionStatusesTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus>> CurrentTransactionStatusesTypedStorage
        {
            get
            {
                return _currentTransactionStatusesTypedStorage;
            }
            set
            {
                _currentTransactionStatusesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _blockHashTypedStorage property
        /// </summary>
        public TypedMapStorage<Opal.NetApiExt.Generated.Model.primitive_types.H256> BlockHashTypedStorage
        {
            get
            {
                return _blockHashTypedStorage;
            }
            set
            {
                _blockHashTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _injectedNonceTypedStorage property
        /// </summary>
        public TypedStorage<Opal.NetApiExt.Generated.Model.primitive_types.U256> InjectedNonceTypedStorage
        {
            get
            {
                return _injectedNonceTypedStorage;
            }
            set
            {
                _injectedNonceTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await PendingTypedStorage.InitializeAsync("Ethereum", "Pending");
            await CurrentBlockTypedStorage.InitializeAsync("Ethereum", "CurrentBlock");
            await CurrentReceiptsTypedStorage.InitializeAsync("Ethereum", "CurrentReceipts");
            await CurrentTransactionStatusesTypedStorage.InitializeAsync("Ethereum", "CurrentTransactionStatuses");
            await BlockHashTypedStorage.InitializeAsync("Ethereum", "BlockHash");
            await InjectedNonceTypedStorage.InitializeAsync("Ethereum", "InjectedNonce");
        }
        
        /// <summary>
        /// Implements any storage change for Ethereum.Pending
        /// </summary>
        [StorageChange("Ethereum", "Pending")]
        public void OnUpdatePending(string data)
        {
            PendingTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Pending
        ///  Current building block's transactions and receipts.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionV2, Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus, Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3>> GetPending()
        {
            return PendingTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Ethereum.CurrentBlock
        /// </summary>
        [StorageChange("Ethereum", "CurrentBlock")]
        public void OnUpdateCurrentBlock(string data)
        {
            CurrentBlockTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CurrentBlock
        ///  The current Ethereum block.
        /// </summary>
        public Opal.NetApiExt.Generated.Model.ethereum.block.Block GetCurrentBlock()
        {
            return CurrentBlockTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Ethereum.CurrentReceipts
        /// </summary>
        [StorageChange("Ethereum", "CurrentReceipts")]
        public void OnUpdateCurrentReceipts(string data)
        {
            CurrentReceiptsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CurrentReceipts
        ///  The current Ethereum receipts.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.ethereum.receipt.EnumReceiptV3> GetCurrentReceipts()
        {
            return CurrentReceiptsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Ethereum.CurrentTransactionStatuses
        /// </summary>
        [StorageChange("Ethereum", "CurrentTransactionStatuses")]
        public void OnUpdateCurrentTransactionStatuses(string data)
        {
            CurrentTransactionStatusesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CurrentTransactionStatuses
        ///  The current transaction statuses.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.fp_rpc.TransactionStatus> GetCurrentTransactionStatuses()
        {
            return CurrentTransactionStatusesTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Ethereum.BlockHash
        /// </summary>
        [StorageChange("Ethereum", "BlockHash")]
        public void OnUpdateBlockHash(string key, string data)
        {
            BlockHashTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> BlockHash
        /// </summary>
        public Opal.NetApiExt.Generated.Model.primitive_types.H256 GetBlockHash(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (BlockHashTypedStorage.Dictionary.TryGetValue(key, out Opal.NetApiExt.Generated.Model.primitive_types.H256 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Ethereum.InjectedNonce
        /// </summary>
        [StorageChange("Ethereum", "InjectedNonce")]
        public void OnUpdateInjectedNonce(string data)
        {
            InjectedNonceTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> InjectedNonce
        ///  Injected transactions should have unique nonce, here we store current
        /// </summary>
        public Opal.NetApiExt.Generated.Model.primitive_types.U256 GetInjectedNonce()
        {
            return InjectedNonceTypedStorage.Get();
        }
    }
}