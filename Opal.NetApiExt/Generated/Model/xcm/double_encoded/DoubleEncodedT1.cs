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


namespace Opal.NetApiExt.Generated.Model.xcm.double_encoded
{
    
    
    /// <summary>
    /// >> 232 - Composite[xcm.double_encoded.DoubleEncodedT1]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DoubleEncodedT1 : BaseType
    {
        
        /// <summary>
        /// >> encoded
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> Encoded { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "DoubleEncodedT1";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Encoded.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Encoded = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            Encoded.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
