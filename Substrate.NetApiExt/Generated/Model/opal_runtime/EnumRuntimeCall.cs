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


namespace Substrate.NetApiExt.Generated.Model.opal_runtime
{
    
    
    /// <summary>
    /// >> RuntimeCall
    /// </summary>
    public enum RuntimeCall
    {
        
        /// <summary>
        /// >> System
        /// </summary>
        System = 0,
        
        /// <summary>
        /// >> StateTrieMigration
        /// </summary>
        StateTrieMigration = 1,
        
        /// <summary>
        /// >> ParachainSystem
        /// </summary>
        ParachainSystem = 20,
        
        /// <summary>
        /// >> ParachainInfo
        /// </summary>
        ParachainInfo = 21,
        
        /// <summary>
        /// >> CollatorSelection
        /// </summary>
        CollatorSelection = 23,
        
        /// <summary>
        /// >> Session
        /// </summary>
        Session = 24,
        
        /// <summary>
        /// >> Balances
        /// </summary>
        Balances = 30,
        
        /// <summary>
        /// >> Timestamp
        /// </summary>
        Timestamp = 32,
        
        /// <summary>
        /// >> Treasury
        /// </summary>
        Treasury = 34,
        
        /// <summary>
        /// >> Sudo
        /// </summary>
        Sudo = 35,
        
        /// <summary>
        /// >> Vesting
        /// </summary>
        Vesting = 37,
        
        /// <summary>
        /// >> XTokens
        /// </summary>
        XTokens = 38,
        
        /// <summary>
        /// >> Identity
        /// </summary>
        Identity = 40,
        
        /// <summary>
        /// >> Preimage
        /// </summary>
        Preimage = 41,
        
        /// <summary>
        /// >> Democracy
        /// </summary>
        Democracy = 42,
        
        /// <summary>
        /// >> Council
        /// </summary>
        Council = 43,
        
        /// <summary>
        /// >> TechnicalCommittee
        /// </summary>
        TechnicalCommittee = 44,
        
        /// <summary>
        /// >> CouncilMembership
        /// </summary>
        CouncilMembership = 45,
        
        /// <summary>
        /// >> TechnicalCommitteeMembership
        /// </summary>
        TechnicalCommitteeMembership = 46,
        
        /// <summary>
        /// >> FellowshipCollective
        /// </summary>
        FellowshipCollective = 47,
        
        /// <summary>
        /// >> FellowshipReferenda
        /// </summary>
        FellowshipReferenda = 48,
        
        /// <summary>
        /// >> Scheduler
        /// </summary>
        Scheduler = 49,
        
        /// <summary>
        /// >> XcmpQueue
        /// </summary>
        XcmpQueue = 50,
        
        /// <summary>
        /// >> PolkadotXcm
        /// </summary>
        PolkadotXcm = 51,
        
        /// <summary>
        /// >> CumulusXcm
        /// </summary>
        CumulusXcm = 52,
        
        /// <summary>
        /// >> DmpQueue
        /// </summary>
        DmpQueue = 53,
        
        /// <summary>
        /// >> Inflation
        /// </summary>
        Inflation = 60,
        
        /// <summary>
        /// >> Unique
        /// </summary>
        Unique = 61,
        
        /// <summary>
        /// >> Configuration
        /// </summary>
        Configuration = 63,
        
        /// <summary>
        /// >> Structure
        /// </summary>
        Structure = 70,
        
        /// <summary>
        /// >> AppPromotion
        /// </summary>
        AppPromotion = 73,
        
        /// <summary>
        /// >> ForeignAssets
        /// </summary>
        ForeignAssets = 80,
        
        /// <summary>
        /// >> EVM
        /// </summary>
        EVM = 100,
        
        /// <summary>
        /// >> Ethereum
        /// </summary>
        Ethereum = 101,
        
        /// <summary>
        /// >> EvmContractHelpers
        /// </summary>
        EvmContractHelpers = 151,
        
        /// <summary>
        /// >> EvmMigration
        /// </summary>
        EvmMigration = 153,
        
        /// <summary>
        /// >> Maintenance
        /// </summary>
        Maintenance = 154,
        
        /// <summary>
        /// >> Utility
        /// </summary>
        Utility = 156,
        
        /// <summary>
        /// >> TestUtils
        /// </summary>
        TestUtils = 255,
    }
    
    /// <summary>
    /// >> 84 - Variant[opal_runtime.RuntimeCall]
    /// </summary>
    public sealed class EnumRuntimeCall : BaseEnumExt<RuntimeCall, Substrate.NetApiExt.Generated.Model.frame_system.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_state_trie_migration.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.NetApiExt.Generated.Model.cumulus_pallet_parachain_system.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.staging_parachain_info.pallet.EnumCall, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_collator_selection.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_session.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_balances.pallet.EnumCall, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_timestamp.pallet.EnumCall, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_treasury.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_sudo.pallet.EnumCall, BaseVoid, Substrate.NetApiExt.Generated.Model.orml_vesting.module.EnumCall, Substrate.NetApiExt.Generated.Model.orml_xtokens.module.EnumCall, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_identity.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_preimage.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_democracy.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_collective.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_collective.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_membership.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_membership.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_ranked_collective.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_referenda.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_scheduler.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_xcm.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.cumulus_pallet_xcm.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_inflation.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_unique.pallet.EnumCall, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_configuration.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_structure.pallet.EnumCall, BaseVoid, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_app_promotion.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_foreign_assets.module.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_evm.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_ethereum.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_evm_contract_helpers.pallet.EnumCall, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_evm_migration.pallet.EnumCall, Substrate.NetApiExt.Generated.Model.pallet_maintenance.pallet.EnumCall, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_utility.pallet.EnumCall, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Substrate.NetApiExt.Generated.Model.pallet_test_utils.pallet.EnumCall>
    {
    }
}
