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


namespace Opal.NetApiExt.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> 607 - Composite[up_data_structs.RpcCollection]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class RpcCollection : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        public Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Owner { get; set; }
        /// <summary>
        /// >> mode
        /// </summary>
        public Opal.NetApiExt.Generated.Model.up_data_structs.EnumCollectionMode Mode { get; set; }
        /// <summary>
        /// >> name
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U16> Name { get; set; }
        /// <summary>
        /// >> description
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U16> Description { get; set; }
        /// <summary>
        /// >> token_prefix
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> TokenPrefix { get; set; }
        /// <summary>
        /// >> sponsorship
        /// </summary>
        public Opal.NetApiExt.Generated.Model.up_data_structs.EnumSponsorshipState Sponsorship { get; set; }
        /// <summary>
        /// >> limits
        /// </summary>
        public Opal.NetApiExt.Generated.Model.up_data_structs.CollectionLimits Limits { get; set; }
        /// <summary>
        /// >> permissions
        /// </summary>
        public Opal.NetApiExt.Generated.Model.up_data_structs.CollectionPermissions Permissions { get; set; }
        /// <summary>
        /// >> token_property_permissions
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.up_data_structs.PropertyKeyPermission> TokenPropertyPermissions { get; set; }
        /// <summary>
        /// >> properties
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.up_data_structs.Property> Properties { get; set; }
        /// <summary>
        /// >> read_only
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool ReadOnly { get; set; }
        /// <summary>
        /// >> flags
        /// </summary>
        public Opal.NetApiExt.Generated.Model.up_data_structs.RpcCollectionFlags Flags { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "RpcCollection";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            result.AddRange(Mode.Encode());
            result.AddRange(Name.Encode());
            result.AddRange(Description.Encode());
            result.AddRange(TokenPrefix.Encode());
            result.AddRange(Sponsorship.Encode());
            result.AddRange(Limits.Encode());
            result.AddRange(Permissions.Encode());
            result.AddRange(TokenPropertyPermissions.Encode());
            result.AddRange(Properties.Encode());
            result.AddRange(ReadOnly.Encode());
            result.AddRange(Flags.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new Opal.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Owner.Decode(byteArray, ref p);
            Mode = new Opal.NetApiExt.Generated.Model.up_data_structs.EnumCollectionMode();
            Mode.Decode(byteArray, ref p);
            Name = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U16>();
            Name.Decode(byteArray, ref p);
            Description = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U16>();
            Description.Decode(byteArray, ref p);
            TokenPrefix = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            TokenPrefix.Decode(byteArray, ref p);
            Sponsorship = new Opal.NetApiExt.Generated.Model.up_data_structs.EnumSponsorshipState();
            Sponsorship.Decode(byteArray, ref p);
            Limits = new Opal.NetApiExt.Generated.Model.up_data_structs.CollectionLimits();
            Limits.Decode(byteArray, ref p);
            Permissions = new Opal.NetApiExt.Generated.Model.up_data_structs.CollectionPermissions();
            Permissions.Decode(byteArray, ref p);
            TokenPropertyPermissions = new Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.up_data_structs.PropertyKeyPermission>();
            TokenPropertyPermissions.Decode(byteArray, ref p);
            Properties = new Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApiExt.Generated.Model.up_data_structs.Property>();
            Properties.Decode(byteArray, ref p);
            ReadOnly = new Substrate.NetApi.Model.Types.Primitive.Bool();
            ReadOnly.Decode(byteArray, ref p);
            Flags = new Opal.NetApiExt.Generated.Model.up_data_structs.RpcCollectionFlags();
            Flags.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
