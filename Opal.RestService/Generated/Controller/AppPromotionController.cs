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
    /// AppPromotionController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class AppPromotionController : ControllerBase
    {
        
        private IAppPromotionStorage _appPromotionStorage;
        
        /// <summary>
        /// AppPromotionController constructor.
        /// </summary>
        public AppPromotionController(IAppPromotionStorage appPromotionStorage)
        {
            _appPromotionStorage = appPromotionStorage;
        }
        
        /// <summary>
        /// >> TotalStaked
        ///  Stores the total staked amount.
        /// </summary>
        [HttpGet("TotalStaked")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.AppPromotionStorage), "TotalStakedParams")]
        public IActionResult GetTotalStaked()
        {
            return this.Ok(_appPromotionStorage.GetTotalStaked());
        }
        
        /// <summary>
        /// >> Admin
        ///  Stores the `admin` account. Some extrinsics can only be executed if they were signed by `admin`.
        /// </summary>
        [HttpGet("Admin")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.AppPromotionStorage), "AdminParams")]
        public IActionResult GetAdmin()
        {
            return this.Ok(_appPromotionStorage.GetAdmin());
        }
        
        /// <summary>
        /// >> Staked
        ///  Stores the amount of tokens staked by account in the blocknumber.
        /// 
        ///  * **Key1** - Staker account.
        ///  * **Key2** - Relay block number when the stake was made.
        ///  * **(Balance, BlockNumber)** - Balance of the stake.
        ///  The number of the relay block in which we must perform the interest recalculation
        /// </summary>
        [HttpGet("Staked")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.AppPromotionStorage), "StakedParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetStaked(string key)
        {
            return this.Ok(_appPromotionStorage.GetStaked(key));
        }
        
        /// <summary>
        /// >> StakesPerAccount
        ///  Stores number of stake records for an `Account`.
        /// 
        ///  * **Key** - Staker account.
        ///  * **Value** - Amount of stakes.
        /// </summary>
        [HttpGet("StakesPerAccount")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U8), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.AppPromotionStorage), "StakesPerAccountParams", typeof(Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetStakesPerAccount(string key)
        {
            return this.Ok(_appPromotionStorage.GetStakesPerAccount(key));
        }
        
        /// <summary>
        /// >> PendingUnstake
        ///  Pending unstake records for an `Account`.
        /// 
        ///  * **Key** - Staker account.
        ///  * **Value** - Amount of stakes.
        /// </summary>
        [HttpGet("PendingUnstake")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT42), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.AppPromotionStorage), "PendingUnstakeParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetPendingUnstake(string key)
        {
            return this.Ok(_appPromotionStorage.GetPendingUnstake(key));
        }
        
        /// <summary>
        /// >> PreviousCalculatedRecord
        ///  Stores a key for record for which the revenue recalculation was performed.
        ///  If `None`, then recalculation has not yet been performed or calculations have been completed for all stakers.
        /// </summary>
        [HttpGet("PreviousCalculatedRecord")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.AppPromotionStorage), "PreviousCalculatedRecordParams")]
        public IActionResult GetPreviousCalculatedRecord()
        {
            return this.Ok(_appPromotionStorage.GetPreviousCalculatedRecord());
        }
    }
}
