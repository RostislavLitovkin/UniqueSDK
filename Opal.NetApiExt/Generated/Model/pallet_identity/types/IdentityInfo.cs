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


namespace Opal.NetApiExt.Generated.Model.pallet_identity.types
{
    
    
    /// <summary>
    /// >> 147 - Composite[pallet_identity.types.IdentityInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class IdentityInfo : BaseType
    {
        
        /// <summary>
        /// >> additional
        /// </summary>
        public Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2 Additional { get; set; }
        /// <summary>
        /// >> display
        /// </summary>
        public Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData Display { get; set; }
        /// <summary>
        /// >> legal
        /// </summary>
        public Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData Legal { get; set; }
        /// <summary>
        /// >> web
        /// </summary>
        public Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData Web { get; set; }
        /// <summary>
        /// >> riot
        /// </summary>
        public Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData Riot { get; set; }
        /// <summary>
        /// >> email
        /// </summary>
        public Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData Email { get; set; }
        /// <summary>
        /// >> pgp_fingerprint
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApiExt.Generated.Types.Base.Arr20U8> PgpFingerprint { get; set; }
        /// <summary>
        /// >> image
        /// </summary>
        public Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData Image { get; set; }
        /// <summary>
        /// >> twitter
        /// </summary>
        public Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData Twitter { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "IdentityInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Additional.Encode());
            result.AddRange(Display.Encode());
            result.AddRange(Legal.Encode());
            result.AddRange(Web.Encode());
            result.AddRange(Riot.Encode());
            result.AddRange(Email.Encode());
            result.AddRange(PgpFingerprint.Encode());
            result.AddRange(Image.Encode());
            result.AddRange(Twitter.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Additional = new Opal.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2();
            Additional.Decode(byteArray, ref p);
            Display = new Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
            Display.Decode(byteArray, ref p);
            Legal = new Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
            Legal.Decode(byteArray, ref p);
            Web = new Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
            Web.Decode(byteArray, ref p);
            Riot = new Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
            Riot.Decode(byteArray, ref p);
            Email = new Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
            Email.Decode(byteArray, ref p);
            PgpFingerprint = new Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApiExt.Generated.Types.Base.Arr20U8>();
            PgpFingerprint.Decode(byteArray, ref p);
            Image = new Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
            Image.Decode(byteArray, ref p);
            Twitter = new Opal.NetApiExt.Generated.Model.pallet_identity.types.EnumData();
            Twitter.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
