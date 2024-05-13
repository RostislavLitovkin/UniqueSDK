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
    /// FellowshipCollectiveController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class FellowshipCollectiveController : ControllerBase
    {
        
        private IFellowshipCollectiveStorage _fellowshipCollectiveStorage;
        
        /// <summary>
        /// FellowshipCollectiveController constructor.
        /// </summary>
        public FellowshipCollectiveController(IFellowshipCollectiveStorage fellowshipCollectiveStorage)
        {
            _fellowshipCollectiveStorage = fellowshipCollectiveStorage;
        }
        
        /// <summary>
        /// >> MemberCount
        ///  The number of members in the collective who have at least the rank according to the index
        ///  of the vec.
        /// </summary>
        [HttpGet("MemberCount")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.FellowshipCollectiveStorage), "MemberCountParams", typeof(Substrate.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetMemberCount(string key)
        {
            return this.Ok(_fellowshipCollectiveStorage.GetMemberCount(key));
        }
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective.
        /// </summary>
        [HttpGet("Members")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.pallet_ranked_collective.MemberRecord), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.FellowshipCollectiveStorage), "MembersParams", typeof(Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetMembers(string key)
        {
            return this.Ok(_fellowshipCollectiveStorage.GetMembers(key));
        }
        
        /// <summary>
        /// >> IdToIndex
        ///  The index of each ranks's member into the group of members who have at least that rank.
        /// </summary>
        [HttpGet("IdToIndex")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.FellowshipCollectiveStorage), "IdToIndexParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>))]
        public IActionResult GetIdToIndex(string key)
        {
            return this.Ok(_fellowshipCollectiveStorage.GetIdToIndex(key));
        }
        
        /// <summary>
        /// >> IndexToId
        ///  The members in the collective by index. All indices in the range `0..MemberCount` will
        ///  return `Some`, however a member's index is not guaranteed to remain unchanged over time.
        /// </summary>
        [HttpGet("IndexToId")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.FellowshipCollectiveStorage), "IndexToIdParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetIndexToId(string key)
        {
            return this.Ok(_fellowshipCollectiveStorage.GetIndexToId(key));
        }
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        [HttpGet("Voting")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.pallet_ranked_collective.EnumVoteRecord), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.FellowshipCollectiveStorage), "VotingParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>))]
        public IActionResult GetVoting(string key)
        {
            return this.Ok(_fellowshipCollectiveStorage.GetVoting(key));
        }
        
        /// <summary>
        /// >> VotingCleanup
        /// </summary>
        [HttpGet("VotingCleanup")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.FellowshipCollectiveStorage), "VotingCleanupParams", typeof(Substrate.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetVotingCleanup(string key)
        {
            return this.Ok(_fellowshipCollectiveStorage.GetVotingCleanup(key));
        }
    }
}
