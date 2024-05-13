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
    /// EVMController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class EVMController : ControllerBase
    {
        
        private IEVMStorage _eVMStorage;
        
        /// <summary>
        /// EVMController constructor.
        /// </summary>
        public EVMController(IEVMStorage eVMStorage)
        {
            _eVMStorage = eVMStorage;
        }
        
        /// <summary>
        /// >> AccountCodes
        /// </summary>
        [HttpGet("AccountCodes")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.EVMStorage), "AccountCodesParams", typeof(Opal.NetApiExt.Generated.Model.primitive_types.H160))]
        public IActionResult GetAccountCodes(string key)
        {
            return this.Ok(_eVMStorage.GetAccountCodes(key));
        }
        
        /// <summary>
        /// >> AccountCodesMetadata
        /// </summary>
        [HttpGet("AccountCodesMetadata")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.pallet_evm.CodeMetadata), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.EVMStorage), "AccountCodesMetadataParams", typeof(Opal.NetApiExt.Generated.Model.primitive_types.H160))]
        public IActionResult GetAccountCodesMetadata(string key)
        {
            return this.Ok(_eVMStorage.GetAccountCodesMetadata(key));
        }
        
        /// <summary>
        /// >> AccountStorages
        /// </summary>
        [HttpGet("AccountStorages")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.primitive_types.H256), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.EVMStorage), "AccountStoragesParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.primitive_types.H160, Opal.NetApiExt.Generated.Model.primitive_types.H256>))]
        public IActionResult GetAccountStorages(string key)
        {
            return this.Ok(_eVMStorage.GetAccountStorages(key));
        }
        
        /// <summary>
        /// >> CurrentLogs
        ///  Written on log, reset after transaction
        ///  Should be empty between transactions
        /// </summary>
        [HttpGet("CurrentLogs")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.ethereum.log.Log>), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.EVMStorage), "CurrentLogsParams")]
        public IActionResult GetCurrentLogs()
        {
            return this.Ok(_eVMStorage.GetCurrentLogs());
        }
    }
}
