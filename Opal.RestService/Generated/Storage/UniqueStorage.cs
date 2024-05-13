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
    /// IUniqueStorage interface definition.
    /// </summary>
    public interface IUniqueStorage : IStorage
    {
        
        /// <summary>
        /// >> ChainVersion
        ///  Used for migrations
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U64 GetChainVersion();
        
        /// <summary>
        /// >> CreateItemBasket
        ///  (Collection id (controlled?2), who created (real))
        ///  TODO: Off chain worker should remove from this map when collection gets removed
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetCreateItemBasket(string key);
        
        /// <summary>
        /// >> NftTransferBasket
        ///  Collection id (controlled?2), token id (controlled?2)
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetNftTransferBasket(string key);
        
        /// <summary>
        /// >> FungibleTransferBasket
        ///  Collection id (controlled?2), owning user (real)
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetFungibleTransferBasket(string key);
        
        /// <summary>
        /// >> ReFungibleTransferBasket
        ///  Collection id (controlled?2), token id (controlled?2)
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetReFungibleTransferBasket(string key);
        
        /// <summary>
        /// >> TokenPropertyBasket
        ///  Last sponsoring of token property setting // todo:doc rephrase this and the following
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetTokenPropertyBasket(string key);
        
        /// <summary>
        /// >> NftApproveBasket
        ///  Last sponsoring of NFT approval in a collection
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetNftApproveBasket(string key);
        
        /// <summary>
        /// >> FungibleApproveBasket
        ///  Last sponsoring of fungible tokens approval in a collection
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetFungibleApproveBasket(string key);
        
        /// <summary>
        /// >> RefungibleApproveBasket
        ///  Last sponsoring of RFT approval in a collection
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetRefungibleApproveBasket(string key);
    }
    
    /// <summary>
    /// UniqueStorage class definition.
    /// </summary>
    public sealed class UniqueStorage : IUniqueStorage
    {
        
        /// <summary>
        /// _chainVersionTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U64> _chainVersionTypedStorage;
        
        /// <summary>
        /// _createItemBasketTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _createItemBasketTypedStorage;
        
        /// <summary>
        /// _nftTransferBasketTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _nftTransferBasketTypedStorage;
        
        /// <summary>
        /// _fungibleTransferBasketTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _fungibleTransferBasketTypedStorage;
        
        /// <summary>
        /// _reFungibleTransferBasketTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _reFungibleTransferBasketTypedStorage;
        
        /// <summary>
        /// _tokenPropertyBasketTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _tokenPropertyBasketTypedStorage;
        
        /// <summary>
        /// _nftApproveBasketTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _nftApproveBasketTypedStorage;
        
        /// <summary>
        /// _fungibleApproveBasketTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _fungibleApproveBasketTypedStorage;
        
        /// <summary>
        /// _refungibleApproveBasketTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> _refungibleApproveBasketTypedStorage;
        
        /// <summary>
        /// UniqueStorage constructor.
        /// </summary>
        public UniqueStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.ChainVersionTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U64>("Unique.ChainVersion", storageDataProvider, storageChangeDelegates);
            this.CreateItemBasketTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Unique.CreateItemBasket", storageDataProvider, storageChangeDelegates);
            this.NftTransferBasketTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Unique.NftTransferBasket", storageDataProvider, storageChangeDelegates);
            this.FungibleTransferBasketTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Unique.FungibleTransferBasket", storageDataProvider, storageChangeDelegates);
            this.ReFungibleTransferBasketTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Unique.ReFungibleTransferBasket", storageDataProvider, storageChangeDelegates);
            this.TokenPropertyBasketTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Unique.TokenPropertyBasket", storageDataProvider, storageChangeDelegates);
            this.NftApproveBasketTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Unique.NftApproveBasket", storageDataProvider, storageChangeDelegates);
            this.FungibleApproveBasketTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Unique.FungibleApproveBasket", storageDataProvider, storageChangeDelegates);
            this.RefungibleApproveBasketTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Unique.RefungibleApproveBasket", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _chainVersionTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U64> ChainVersionTypedStorage
        {
            get
            {
                return _chainVersionTypedStorage;
            }
            set
            {
                _chainVersionTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _createItemBasketTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> CreateItemBasketTypedStorage
        {
            get
            {
                return _createItemBasketTypedStorage;
            }
            set
            {
                _createItemBasketTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nftTransferBasketTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> NftTransferBasketTypedStorage
        {
            get
            {
                return _nftTransferBasketTypedStorage;
            }
            set
            {
                _nftTransferBasketTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _fungibleTransferBasketTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> FungibleTransferBasketTypedStorage
        {
            get
            {
                return _fungibleTransferBasketTypedStorage;
            }
            set
            {
                _fungibleTransferBasketTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _reFungibleTransferBasketTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> ReFungibleTransferBasketTypedStorage
        {
            get
            {
                return _reFungibleTransferBasketTypedStorage;
            }
            set
            {
                _reFungibleTransferBasketTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _tokenPropertyBasketTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> TokenPropertyBasketTypedStorage
        {
            get
            {
                return _tokenPropertyBasketTypedStorage;
            }
            set
            {
                _tokenPropertyBasketTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nftApproveBasketTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> NftApproveBasketTypedStorage
        {
            get
            {
                return _nftApproveBasketTypedStorage;
            }
            set
            {
                _nftApproveBasketTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _fungibleApproveBasketTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> FungibleApproveBasketTypedStorage
        {
            get
            {
                return _fungibleApproveBasketTypedStorage;
            }
            set
            {
                _fungibleApproveBasketTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _refungibleApproveBasketTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Primitive.U32> RefungibleApproveBasketTypedStorage
        {
            get
            {
                return _refungibleApproveBasketTypedStorage;
            }
            set
            {
                _refungibleApproveBasketTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ChainVersionTypedStorage.InitializeAsync("Unique", "ChainVersion");
            await CreateItemBasketTypedStorage.InitializeAsync("Unique", "CreateItemBasket");
            await NftTransferBasketTypedStorage.InitializeAsync("Unique", "NftTransferBasket");
            await FungibleTransferBasketTypedStorage.InitializeAsync("Unique", "FungibleTransferBasket");
            await ReFungibleTransferBasketTypedStorage.InitializeAsync("Unique", "ReFungibleTransferBasket");
            await TokenPropertyBasketTypedStorage.InitializeAsync("Unique", "TokenPropertyBasket");
            await NftApproveBasketTypedStorage.InitializeAsync("Unique", "NftApproveBasket");
            await FungibleApproveBasketTypedStorage.InitializeAsync("Unique", "FungibleApproveBasket");
            await RefungibleApproveBasketTypedStorage.InitializeAsync("Unique", "RefungibleApproveBasket");
        }
        
        /// <summary>
        /// Implements any storage change for Unique.ChainVersion
        /// </summary>
        [StorageChange("Unique", "ChainVersion")]
        public void OnUpdateChainVersion(string data)
        {
            ChainVersionTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ChainVersion
        ///  Used for migrations
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 GetChainVersion()
        {
            return ChainVersionTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Unique.CreateItemBasket
        /// </summary>
        [StorageChange("Unique", "CreateItemBasket")]
        public void OnUpdateCreateItemBasket(string key, string data)
        {
            CreateItemBasketTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> CreateItemBasket
        ///  (Collection id (controlled?2), who created (real))
        ///  TODO: Off chain worker should remove from this map when collection gets removed
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetCreateItemBasket(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CreateItemBasketTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Unique.NftTransferBasket
        /// </summary>
        [StorageChange("Unique", "NftTransferBasket")]
        public void OnUpdateNftTransferBasket(string key, string data)
        {
            NftTransferBasketTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> NftTransferBasket
        ///  Collection id (controlled?2), token id (controlled?2)
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetNftTransferBasket(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (NftTransferBasketTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Unique.FungibleTransferBasket
        /// </summary>
        [StorageChange("Unique", "FungibleTransferBasket")]
        public void OnUpdateFungibleTransferBasket(string key, string data)
        {
            FungibleTransferBasketTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> FungibleTransferBasket
        ///  Collection id (controlled?2), owning user (real)
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetFungibleTransferBasket(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (FungibleTransferBasketTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Unique.ReFungibleTransferBasket
        /// </summary>
        [StorageChange("Unique", "ReFungibleTransferBasket")]
        public void OnUpdateReFungibleTransferBasket(string key, string data)
        {
            ReFungibleTransferBasketTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ReFungibleTransferBasket
        ///  Collection id (controlled?2), token id (controlled?2)
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetReFungibleTransferBasket(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ReFungibleTransferBasketTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Unique.TokenPropertyBasket
        /// </summary>
        [StorageChange("Unique", "TokenPropertyBasket")]
        public void OnUpdateTokenPropertyBasket(string key, string data)
        {
            TokenPropertyBasketTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> TokenPropertyBasket
        ///  Last sponsoring of token property setting // todo:doc rephrase this and the following
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetTokenPropertyBasket(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (TokenPropertyBasketTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Unique.NftApproveBasket
        /// </summary>
        [StorageChange("Unique", "NftApproveBasket")]
        public void OnUpdateNftApproveBasket(string key, string data)
        {
            NftApproveBasketTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> NftApproveBasket
        ///  Last sponsoring of NFT approval in a collection
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetNftApproveBasket(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (NftApproveBasketTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Unique.FungibleApproveBasket
        /// </summary>
        [StorageChange("Unique", "FungibleApproveBasket")]
        public void OnUpdateFungibleApproveBasket(string key, string data)
        {
            FungibleApproveBasketTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> FungibleApproveBasket
        ///  Last sponsoring of fungible tokens approval in a collection
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetFungibleApproveBasket(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (FungibleApproveBasketTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Unique.RefungibleApproveBasket
        /// </summary>
        [StorageChange("Unique", "RefungibleApproveBasket")]
        public void OnUpdateRefungibleApproveBasket(string key, string data)
        {
            RefungibleApproveBasketTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> RefungibleApproveBasket
        ///  Last sponsoring of RFT approval in a collection
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetRefungibleApproveBasket(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (RefungibleApproveBasketTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Primitive.U32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
