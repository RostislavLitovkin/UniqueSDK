//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Opal.RestService.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Opal.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// ForeignAssetsController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ForeignAssetsController : ControllerBase
    {
        
        private IForeignAssetsStorage _foreignAssetsStorage;
        
        /// <summary>
        /// ForeignAssetsController constructor.
        /// </summary>
        public ForeignAssetsController(IForeignAssetsStorage foreignAssetsStorage)
        {
            _foreignAssetsStorage = foreignAssetsStorage;
        }
        
        /// <summary>
        /// >> ForeignAssetToCollection
        ///  The corresponding collections of foreign assets.
        /// </summary>
        [HttpGet("ForeignAssetToCollection")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.up_data_structs.CollectionId), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.ForeignAssetsStorage), "ForeignAssetToCollectionParams", typeof(Opal.NetApiExt.Generated.Model.xcm.v3.multiasset.EnumAssetId))]
        public IActionResult GetForeignAssetToCollection(string key)
        {
            return this.Ok(_foreignAssetsStorage.GetForeignAssetToCollection(key));
        }
        
        /// <summary>
        /// >> CollectionToForeignAsset
        ///  The corresponding foreign assets of collections.
        /// </summary>
        [HttpGet("CollectionToForeignAsset")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.xcm.v3.multiasset.EnumAssetId), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.ForeignAssetsStorage), "CollectionToForeignAssetParams", typeof(Opal.NetApiExt.Generated.Model.up_data_structs.CollectionId))]
        public IActionResult GetCollectionToForeignAsset(string key)
        {
            return this.Ok(_foreignAssetsStorage.GetCollectionToForeignAsset(key));
        }
        
        /// <summary>
        /// >> ForeignReserveAssetInstanceToTokenId
        ///  The correponding NFT token id of reserve NFTs
        /// </summary>
        [HttpGet("ForeignReserveAssetInstanceToTokenId")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.up_data_structs.TokenId), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.ForeignAssetsStorage), "ForeignReserveAssetInstanceToTokenIdParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.up_data_structs.CollectionId, Opal.NetApiExt.Generated.Model.xcm.v3.multiasset.EnumAssetInstance>))]
        public IActionResult GetForeignReserveAssetInstanceToTokenId(string key)
        {
            return this.Ok(_foreignAssetsStorage.GetForeignReserveAssetInstanceToTokenId(key));
        }
        
        /// <summary>
        /// >> TokenIdToForeignReserveAssetInstance
        ///  The correponding reserve NFT of a token ID
        /// </summary>
        [HttpGet("TokenIdToForeignReserveAssetInstance")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.xcm.v3.multiasset.EnumAssetInstance), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.ForeignAssetsStorage), "TokenIdToForeignReserveAssetInstanceParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.up_data_structs.CollectionId, Opal.NetApiExt.Generated.Model.up_data_structs.TokenId>))]
        public IActionResult GetTokenIdToForeignReserveAssetInstance(string key)
        {
            return this.Ok(_foreignAssetsStorage.GetTokenIdToForeignReserveAssetInstance(key));
        }
    }
}
