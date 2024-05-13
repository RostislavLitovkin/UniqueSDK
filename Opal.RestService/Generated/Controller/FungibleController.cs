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
    /// FungibleController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class FungibleController : ControllerBase
    {
        
        private IFungibleStorage _fungibleStorage;
        
        /// <summary>
        /// FungibleController constructor.
        /// </summary>
        public FungibleController(IFungibleStorage fungibleStorage)
        {
            _fungibleStorage = fungibleStorage;
        }
        
        /// <summary>
        /// >> TotalSupply
        ///  Total amount of fungible tokens inside a collection.
        /// </summary>
        [HttpGet("TotalSupply")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.FungibleStorage), "TotalSupplyParams", typeof(Opal.NetApiExt.Generated.Model.up_data_structs.CollectionId))]
        public IActionResult GetTotalSupply(string key)
        {
            return this.Ok(_fungibleStorage.GetTotalSupply(key));
        }
        
        /// <summary>
        /// >> Balance
        ///  Amount of tokens owned by an account inside a collection.
        /// </summary>
        [HttpGet("Balance")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.FungibleStorage), "BalanceParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.up_data_structs.CollectionId, Opal.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>))]
        public IActionResult GetBalance(string key)
        {
            return this.Ok(_fungibleStorage.GetBalance(key));
        }
        
        /// <summary>
        /// >> Allowance
        ///  Storage for assets delegated to a limited extent to other users.
        /// </summary>
        [HttpGet("Allowance")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.FungibleStorage), "AllowanceParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.up_data_structs.CollectionId, Opal.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Opal.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>))]
        public IActionResult GetAllowance(string key)
        {
            return this.Ok(_fungibleStorage.GetAllowance(key));
        }
    }
}
