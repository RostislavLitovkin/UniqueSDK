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


namespace Substrate.Opal.NET.NetApiExt.Generated.Types.Base
{
    
    
    /// <summary>
    /// >> 617 - Array
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Array)]
    public sealed class Arr0BaseTuple : BaseType
    {
        
        /// <summary>
        /// >> Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.TokenData, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.RpcCollection, Substrate.Opal.NET.NetApiExt.Generated.Model.up_pov_estimate_rpc.PovInfo>[]
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.TokenData, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.RpcCollection, Substrate.Opal.NET.NetApiExt.Generated.Model.up_pov_estimate_rpc.PovInfo>[] Value { get; set; }
        
        /// <inheritdoc/>
        public override int TypeSize
        {
            get
            {
                return 0;
            }
        }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return string.Format("[{0}; {1}]", new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.TokenData, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.RpcCollection, Substrate.Opal.NET.NetApiExt.Generated.Model.up_pov_estimate_rpc.PovInfo>().TypeName(), this.TypeSize);
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            foreach (var v in Value){result.AddRange(v.Encode());};
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            var array = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.TokenData, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.RpcCollection, Substrate.Opal.NET.NetApiExt.Generated.Model.up_pov_estimate_rpc.PovInfo>[TypeSize];
            for (var i = 0; i < array.Length; i++) {var t = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.TokenData, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.RpcCollection, Substrate.Opal.NET.NetApiExt.Generated.Model.up_pov_estimate_rpc.PovInfo>();t.Decode(byteArray, ref p);array[i] = t;};
            var bytesLength = p - start;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
            Value = array;
        }
        
        /// <inheritdoc/>
        public void Create(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.TokenData, Substrate.Opal.NET.NetApiExt.Generated.Model.up_data_structs.RpcCollection, Substrate.Opal.NET.NetApiExt.Generated.Model.up_pov_estimate_rpc.PovInfo>[] array)
        {
            Value = array;
            Bytes = Encode();
        }
    }
}
