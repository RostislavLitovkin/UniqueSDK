//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.NetApiExt.Generated.Model.pallet_identity.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Identity pallet declaration.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> add_registrar
        /// See [`Pallet::add_registrar`].
        /// </summary>
        add_registrar = 0,
        
        /// <summary>
        /// >> set_identity
        /// See [`Pallet::set_identity`].
        /// </summary>
        set_identity = 1,
        
        /// <summary>
        /// >> set_subs
        /// See [`Pallet::set_subs`].
        /// </summary>
        set_subs = 2,
        
        /// <summary>
        /// >> clear_identity
        /// See [`Pallet::clear_identity`].
        /// </summary>
        clear_identity = 3,
        
        /// <summary>
        /// >> request_judgement
        /// See [`Pallet::request_judgement`].
        /// </summary>
        request_judgement = 4,
        
        /// <summary>
        /// >> cancel_request
        /// See [`Pallet::cancel_request`].
        /// </summary>
        cancel_request = 5,
        
        /// <summary>
        /// >> set_fee
        /// See [`Pallet::set_fee`].
        /// </summary>
        set_fee = 6,
        
        /// <summary>
        /// >> set_account_id
        /// See [`Pallet::set_account_id`].
        /// </summary>
        set_account_id = 7,
        
        /// <summary>
        /// >> set_fields
        /// See [`Pallet::set_fields`].
        /// </summary>
        set_fields = 8,
        
        /// <summary>
        /// >> provide_judgement
        /// See [`Pallet::provide_judgement`].
        /// </summary>
        provide_judgement = 9,
        
        /// <summary>
        /// >> kill_identity
        /// See [`Pallet::kill_identity`].
        /// </summary>
        kill_identity = 10,
        
        /// <summary>
        /// >> add_sub
        /// See [`Pallet::add_sub`].
        /// </summary>
        add_sub = 11,
        
        /// <summary>
        /// >> rename_sub
        /// See [`Pallet::rename_sub`].
        /// </summary>
        rename_sub = 12,
        
        /// <summary>
        /// >> remove_sub
        /// See [`Pallet::remove_sub`].
        /// </summary>
        remove_sub = 13,
        
        /// <summary>
        /// >> quit_sub
        /// See [`Pallet::quit_sub`].
        /// </summary>
        quit_sub = 14,
        
        /// <summary>
        /// >> force_insert_identities
        /// See [`Pallet::force_insert_identities`].
        /// </summary>
        force_insert_identities = 15,
        
        /// <summary>
        /// >> force_remove_identities
        /// See [`Pallet::force_remove_identities`].
        /// </summary>
        force_remove_identities = 16,
        
        /// <summary>
        /// >> force_set_subs
        /// See [`Pallet::force_set_subs`].
        /// </summary>
        force_set_subs = 17,
    }
    
    /// <summary>
    /// >> 146 - Variant[pallet_identity.pallet.Call]
    /// Identity pallet declaration.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApiExt.Generated.Model.pallet_identity.types.IdentityInfo, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApiExt.Generated.Model.pallet_identity.types.EnumData>>, BaseVoid, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApiExt.Generated.Model.pallet_identity.types.BitFlags>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApiExt.Generated.Model.pallet_identity.types.EnumJudgement, Substrate.NetApiExt.Generated.Model.primitive_types.H256>, Substrate.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseTuple<Substrate.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApiExt.Generated.Model.pallet_identity.types.EnumData>, BaseTuple<Substrate.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApiExt.Generated.Model.pallet_identity.types.EnumData>, Substrate.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseVoid, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApiExt.Generated.Model.pallet_identity.types.Registration>>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4>>>>
    {
    }
}
