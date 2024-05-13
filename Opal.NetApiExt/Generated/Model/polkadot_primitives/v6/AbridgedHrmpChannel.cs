//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Opal.NetApiExt.Generated.Model.polkadot_primitives.v6
{
    
    
    /// <summary>
    /// >> 419 - Composite[polkadot_primitives.v6.AbridgedHrmpChannel]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AbridgedHrmpChannel : BaseType
    {
        
        /// <summary>
        /// >> max_capacity
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxCapacity { get; set; }
        /// <summary>
        /// >> max_total_size
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxTotalSize { get; set; }
        /// <summary>
        /// >> max_message_size
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxMessageSize { get; set; }
        /// <summary>
        /// >> msg_count
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MsgCount { get; set; }
        /// <summary>
        /// >> total_size
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 TotalSize { get; set; }
        /// <summary>
        /// >> mqc_head
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApiExt.Generated.Model.primitive_types.H256> MqcHead { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "AbridgedHrmpChannel";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaxCapacity.Encode());
            result.AddRange(MaxTotalSize.Encode());
            result.AddRange(MaxMessageSize.Encode());
            result.AddRange(MsgCount.Encode());
            result.AddRange(TotalSize.Encode());
            result.AddRange(MqcHead.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaxCapacity = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxCapacity.Decode(byteArray, ref p);
            MaxTotalSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxTotalSize.Decode(byteArray, ref p);
            MaxMessageSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxMessageSize.Decode(byteArray, ref p);
            MsgCount = new Substrate.NetApi.Model.Types.Primitive.U32();
            MsgCount.Decode(byteArray, ref p);
            TotalSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            TotalSize.Decode(byteArray, ref p);
            MqcHead = new Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApiExt.Generated.Model.primitive_types.H256>();
            MqcHead.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
