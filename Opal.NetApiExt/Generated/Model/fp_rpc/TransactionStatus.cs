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


namespace Opal.NetApiExt.Generated.Model.fp_rpc
{
    
    
    /// <summary>
    /// >> 645 - Composite[fp_rpc.TransactionStatus]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class TransactionStatus : BaseType
    {
        
        /// <summary>
        /// >> transaction_hash
        /// </summary>
        public Opal.NetApiExt.Generated.Model.primitive_types.H256 TransactionHash { get; set; }
        /// <summary>
        /// >> transaction_index
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 TransactionIndex { get; set; }
        /// <summary>
        /// >> from
        /// </summary>
        public Opal.NetApiExt.Generated.Model.primitive_types.H160 From { get; set; }
        /// <summary>
        /// >> to
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApiExt.Generated.Model.primitive_types.H160> To { get; set; }
        /// <summary>
        /// >> contract_address
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApiExt.Generated.Model.primitive_types.H160> ContractAddress { get; set; }
        /// <summary>
        /// >> logs
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.ethereum.log.Log> Logs { get; set; }
        /// <summary>
        /// >> logs_bloom
        /// </summary>
        public Opal.NetApiExt.Generated.Model.ethbloom.Bloom LogsBloom { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "TransactionStatus";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(TransactionHash.Encode());
            result.AddRange(TransactionIndex.Encode());
            result.AddRange(From.Encode());
            result.AddRange(To.Encode());
            result.AddRange(ContractAddress.Encode());
            result.AddRange(Logs.Encode());
            result.AddRange(LogsBloom.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TransactionHash = new Opal.NetApiExt.Generated.Model.primitive_types.H256();
            TransactionHash.Decode(byteArray, ref p);
            TransactionIndex = new Substrate.NetApi.Model.Types.Primitive.U32();
            TransactionIndex.Decode(byteArray, ref p);
            From = new Opal.NetApiExt.Generated.Model.primitive_types.H160();
            From.Decode(byteArray, ref p);
            To = new Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApiExt.Generated.Model.primitive_types.H160>();
            To.Decode(byteArray, ref p);
            ContractAddress = new Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApiExt.Generated.Model.primitive_types.H160>();
            ContractAddress.Decode(byteArray, ref p);
            Logs = new Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.ethereum.log.Log>();
            Logs.Decode(byteArray, ref p);
            LogsBloom = new Opal.NetApiExt.Generated.Model.ethbloom.Bloom();
            LogsBloom.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
