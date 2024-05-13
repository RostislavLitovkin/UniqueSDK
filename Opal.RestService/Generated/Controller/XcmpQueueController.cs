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
    /// XcmpQueueController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class XcmpQueueController : ControllerBase
    {
        
        private IXcmpQueueStorage _xcmpQueueStorage;
        
        /// <summary>
        /// XcmpQueueController constructor.
        /// </summary>
        public XcmpQueueController(IXcmpQueueStorage xcmpQueueStorage)
        {
            _xcmpQueueStorage = xcmpQueueStorage;
        }
        
        /// <summary>
        /// >> InboundXcmpStatus
        ///  Status of the inbound XCMP channels.
        /// </summary>
        [HttpGet("InboundXcmpStatus")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails>), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.XcmpQueueStorage), "InboundXcmpStatusParams")]
        public IActionResult GetInboundXcmpStatus()
        {
            return this.Ok(_xcmpQueueStorage.GetInboundXcmpStatus());
        }
        
        /// <summary>
        /// >> InboundXcmpMessages
        ///  Inbound aggregate XCMP messages. It can only be one per ParaId/block.
        /// </summary>
        [HttpGet("InboundXcmpMessages")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.XcmpQueueStorage), "InboundXcmpMessagesParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32>))]
        public IActionResult GetInboundXcmpMessages(string key)
        {
            return this.Ok(_xcmpQueueStorage.GetInboundXcmpMessages(key));
        }
        
        /// <summary>
        /// >> OutboundXcmpStatus
        ///  The non-empty XCMP channels in order of becoming non-empty, and the index of the first
        ///  and last outbound message. If the two indices are equal, then it indicates an empty
        ///  queue and there must be a non-`Ok` `OutboundStatus`. We assume queues grow no greater
        ///  than 65535 items. Queue indices for normal messages begin at one; zero is reserved in
        ///  case of the need to send a high-priority signal message this block.
        ///  The bool is true if there is a signal message waiting to be sent.
        /// </summary>
        [HttpGet("OutboundXcmpStatus")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails>), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.XcmpQueueStorage), "OutboundXcmpStatusParams")]
        public IActionResult GetOutboundXcmpStatus()
        {
            return this.Ok(_xcmpQueueStorage.GetOutboundXcmpStatus());
        }
        
        /// <summary>
        /// >> OutboundXcmpMessages
        ///  The messages outbound in a given XCMP channel.
        /// </summary>
        [HttpGet("OutboundXcmpMessages")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.XcmpQueueStorage), "OutboundXcmpMessagesParams", typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U16>))]
        public IActionResult GetOutboundXcmpMessages(string key)
        {
            return this.Ok(_xcmpQueueStorage.GetOutboundXcmpMessages(key));
        }
        
        /// <summary>
        /// >> SignalMessages
        ///  Any signal messages waiting to be sent.
        /// </summary>
        [HttpGet("SignalMessages")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.XcmpQueueStorage), "SignalMessagesParams", typeof(Opal.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id))]
        public IActionResult GetSignalMessages(string key)
        {
            return this.Ok(_xcmpQueueStorage.GetSignalMessages(key));
        }
        
        /// <summary>
        /// >> QueueConfig
        ///  The configuration which controls the dynamics of the outbound queue.
        /// </summary>
        [HttpGet("QueueConfig")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.QueueConfigData), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.XcmpQueueStorage), "QueueConfigParams")]
        public IActionResult GetQueueConfig()
        {
            return this.Ok(_xcmpQueueStorage.GetQueueConfig());
        }
        
        /// <summary>
        /// >> Overweight
        ///  The messages that exceeded max individual message weight budget.
        /// 
        ///  These message stay in this storage map until they are manually dispatched via
        ///  `service_overweight`.
        /// </summary>
        [HttpGet("Overweight")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.XcmpQueueStorage), "OverweightParams", typeof(Substrate.NetApi.Model.Types.Primitive.U64))]
        public IActionResult GetOverweight(string key)
        {
            return this.Ok(_xcmpQueueStorage.GetOverweight(key));
        }
        
        /// <summary>
        /// >> CounterForOverweight
        /// Counter for the related counted storage map
        /// </summary>
        [HttpGet("CounterForOverweight")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.XcmpQueueStorage), "CounterForOverweightParams")]
        public IActionResult GetCounterForOverweight()
        {
            return this.Ok(_xcmpQueueStorage.GetCounterForOverweight());
        }
        
        /// <summary>
        /// >> OverweightCount
        ///  The number of overweight messages ever recorded in `Overweight`. Also doubles as the next
        ///  available free overweight index.
        /// </summary>
        [HttpGet("OverweightCount")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U64), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.XcmpQueueStorage), "OverweightCountParams")]
        public IActionResult GetOverweightCount()
        {
            return this.Ok(_xcmpQueueStorage.GetOverweightCount());
        }
        
        /// <summary>
        /// >> QueueSuspended
        ///  Whether or not the XCMP queue is suspended from executing incoming XCMs or not.
        /// </summary>
        [HttpGet("QueueSuspended")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.Bool), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.XcmpQueueStorage), "QueueSuspendedParams")]
        public IActionResult GetQueueSuspended()
        {
            return this.Ok(_xcmpQueueStorage.GetQueueSuspended());
        }
        
        /// <summary>
        /// >> DeliveryFeeFactor
        ///  The factor to multiply the base delivery fee by.
        /// </summary>
        [HttpGet("DeliveryFeeFactor")]
        [ProducesResponseType(typeof(Opal.NetApiExt.Generated.Model.sp_arithmetic.fixed_point.FixedU128), 200)]
        [StorageKeyBuilder(typeof(Opal.NetApiExt.Generated.Storage.XcmpQueueStorage), "DeliveryFeeFactorParams", typeof(Opal.NetApiExt.Generated.Model.polkadot_parachain_primitives.primitives.Id))]
        public IActionResult GetDeliveryFeeFactor(string key)
        {
            return this.Ok(_xcmpQueueStorage.GetDeliveryFeeFactor(key));
        }
    }
}
