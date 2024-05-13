//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Opal.NetApiExt.Generated.Storage;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Opal.NetApiExt.Generated
{
    
    
    /// <summary>
    /// >> Substrate Client Extension, including all Storage classes direct access.
    /// </summary>
    public sealed class SubstrateClientExt : Substrate.NetApi.SubstrateClient
    {
        
        /// <summary>
        /// StorageKeyDict for key definition informations.
        /// </summary>
        public System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>> StorageKeyDict;
        
        /// <summary>
        /// SystemStorage storage calls.
        /// </summary>
        public SystemStorage SystemStorage;
        
        /// <summary>
        /// StateTrieMigrationStorage storage calls.
        /// </summary>
        public StateTrieMigrationStorage StateTrieMigrationStorage;
        
        /// <summary>
        /// ParachainSystemStorage storage calls.
        /// </summary>
        public ParachainSystemStorage ParachainSystemStorage;
        
        /// <summary>
        /// ParachainInfoStorage storage calls.
        /// </summary>
        public ParachainInfoStorage ParachainInfoStorage;
        
        /// <summary>
        /// AuthorshipStorage storage calls.
        /// </summary>
        public AuthorshipStorage AuthorshipStorage;
        
        /// <summary>
        /// CollatorSelectionStorage storage calls.
        /// </summary>
        public CollatorSelectionStorage CollatorSelectionStorage;
        
        /// <summary>
        /// SessionStorage storage calls.
        /// </summary>
        public SessionStorage SessionStorage;
        
        /// <summary>
        /// AuraStorage storage calls.
        /// </summary>
        public AuraStorage AuraStorage;
        
        /// <summary>
        /// AuraExtStorage storage calls.
        /// </summary>
        public AuraExtStorage AuraExtStorage;
        
        /// <summary>
        /// BalancesStorage storage calls.
        /// </summary>
        public BalancesStorage BalancesStorage;
        
        /// <summary>
        /// TimestampStorage storage calls.
        /// </summary>
        public TimestampStorage TimestampStorage;
        
        /// <summary>
        /// TransactionPaymentStorage storage calls.
        /// </summary>
        public TransactionPaymentStorage TransactionPaymentStorage;
        
        /// <summary>
        /// TreasuryStorage storage calls.
        /// </summary>
        public TreasuryStorage TreasuryStorage;
        
        /// <summary>
        /// SudoStorage storage calls.
        /// </summary>
        public SudoStorage SudoStorage;
        
        /// <summary>
        /// VestingStorage storage calls.
        /// </summary>
        public VestingStorage VestingStorage;
        
        /// <summary>
        /// XTokensStorage storage calls.
        /// </summary>
        public XTokensStorage XTokensStorage;
        
        /// <summary>
        /// IdentityStorage storage calls.
        /// </summary>
        public IdentityStorage IdentityStorage;
        
        /// <summary>
        /// PreimageStorage storage calls.
        /// </summary>
        public PreimageStorage PreimageStorage;
        
        /// <summary>
        /// DemocracyStorage storage calls.
        /// </summary>
        public DemocracyStorage DemocracyStorage;
        
        /// <summary>
        /// CouncilStorage storage calls.
        /// </summary>
        public CouncilStorage CouncilStorage;
        
        /// <summary>
        /// TechnicalCommitteeStorage storage calls.
        /// </summary>
        public TechnicalCommitteeStorage TechnicalCommitteeStorage;
        
        /// <summary>
        /// CouncilMembershipStorage storage calls.
        /// </summary>
        public CouncilMembershipStorage CouncilMembershipStorage;
        
        /// <summary>
        /// TechnicalCommitteeMembershipStorage storage calls.
        /// </summary>
        public TechnicalCommitteeMembershipStorage TechnicalCommitteeMembershipStorage;
        
        /// <summary>
        /// FellowshipCollectiveStorage storage calls.
        /// </summary>
        public FellowshipCollectiveStorage FellowshipCollectiveStorage;
        
        /// <summary>
        /// FellowshipReferendaStorage storage calls.
        /// </summary>
        public FellowshipReferendaStorage FellowshipReferendaStorage;
        
        /// <summary>
        /// SchedulerStorage storage calls.
        /// </summary>
        public SchedulerStorage SchedulerStorage;
        
        /// <summary>
        /// OriginsStorage storage calls.
        /// </summary>
        public OriginsStorage OriginsStorage;
        
        /// <summary>
        /// XcmpQueueStorage storage calls.
        /// </summary>
        public XcmpQueueStorage XcmpQueueStorage;
        
        /// <summary>
        /// PolkadotXcmStorage storage calls.
        /// </summary>
        public PolkadotXcmStorage PolkadotXcmStorage;
        
        /// <summary>
        /// CumulusXcmStorage storage calls.
        /// </summary>
        public CumulusXcmStorage CumulusXcmStorage;
        
        /// <summary>
        /// DmpQueueStorage storage calls.
        /// </summary>
        public DmpQueueStorage DmpQueueStorage;
        
        /// <summary>
        /// InflationStorage storage calls.
        /// </summary>
        public InflationStorage InflationStorage;
        
        /// <summary>
        /// UniqueStorage storage calls.
        /// </summary>
        public UniqueStorage UniqueStorage;
        
        /// <summary>
        /// ConfigurationStorage storage calls.
        /// </summary>
        public ConfigurationStorage ConfigurationStorage;
        
        /// <summary>
        /// ChargingStorage storage calls.
        /// </summary>
        public ChargingStorage ChargingStorage;
        
        /// <summary>
        /// CommonStorage storage calls.
        /// </summary>
        public CommonStorage CommonStorage;
        
        /// <summary>
        /// FungibleStorage storage calls.
        /// </summary>
        public FungibleStorage FungibleStorage;
        
        /// <summary>
        /// RefungibleStorage storage calls.
        /// </summary>
        public RefungibleStorage RefungibleStorage;
        
        /// <summary>
        /// NonfungibleStorage storage calls.
        /// </summary>
        public NonfungibleStorage NonfungibleStorage;
        
        /// <summary>
        /// StructureStorage storage calls.
        /// </summary>
        public StructureStorage StructureStorage;
        
        /// <summary>
        /// AppPromotionStorage storage calls.
        /// </summary>
        public AppPromotionStorage AppPromotionStorage;
        
        /// <summary>
        /// ForeignAssetsStorage storage calls.
        /// </summary>
        public ForeignAssetsStorage ForeignAssetsStorage;
        
        /// <summary>
        /// EVMStorage storage calls.
        /// </summary>
        public EVMStorage EVMStorage;
        
        /// <summary>
        /// EthereumStorage storage calls.
        /// </summary>
        public EthereumStorage EthereumStorage;
        
        /// <summary>
        /// EvmCoderSubstrateStorage storage calls.
        /// </summary>
        public EvmCoderSubstrateStorage EvmCoderSubstrateStorage;
        
        /// <summary>
        /// EvmContractHelpersStorage storage calls.
        /// </summary>
        public EvmContractHelpersStorage EvmContractHelpersStorage;
        
        /// <summary>
        /// EvmTransactionPaymentStorage storage calls.
        /// </summary>
        public EvmTransactionPaymentStorage EvmTransactionPaymentStorage;
        
        /// <summary>
        /// EvmMigrationStorage storage calls.
        /// </summary>
        public EvmMigrationStorage EvmMigrationStorage;
        
        /// <summary>
        /// MaintenanceStorage storage calls.
        /// </summary>
        public MaintenanceStorage MaintenanceStorage;
        
        /// <summary>
        /// BalancesAdapterStorage storage calls.
        /// </summary>
        public BalancesAdapterStorage BalancesAdapterStorage;
        
        /// <summary>
        /// UtilityStorage storage calls.
        /// </summary>
        public UtilityStorage UtilityStorage;
        
        /// <summary>
        /// TestUtilsStorage storage calls.
        /// </summary>
        public TestUtilsStorage TestUtilsStorage;
        
        public SubstrateClientExt(System.Uri uri, Substrate.NetApi.Model.Extrinsics.ChargeType chargeType) : 
                base(uri, chargeType)
        {
            StorageKeyDict = new System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>>();
            this.SystemStorage = new SystemStorage(this);
            this.StateTrieMigrationStorage = new StateTrieMigrationStorage(this);
            this.ParachainSystemStorage = new ParachainSystemStorage(this);
            this.ParachainInfoStorage = new ParachainInfoStorage(this);
            this.AuthorshipStorage = new AuthorshipStorage(this);
            this.CollatorSelectionStorage = new CollatorSelectionStorage(this);
            this.SessionStorage = new SessionStorage(this);
            this.AuraStorage = new AuraStorage(this);
            this.AuraExtStorage = new AuraExtStorage(this);
            this.BalancesStorage = new BalancesStorage(this);
            this.TimestampStorage = new TimestampStorage(this);
            this.TransactionPaymentStorage = new TransactionPaymentStorage(this);
            this.TreasuryStorage = new TreasuryStorage(this);
            this.SudoStorage = new SudoStorage(this);
            this.VestingStorage = new VestingStorage(this);
            this.XTokensStorage = new XTokensStorage(this);
            this.IdentityStorage = new IdentityStorage(this);
            this.PreimageStorage = new PreimageStorage(this);
            this.DemocracyStorage = new DemocracyStorage(this);
            this.CouncilStorage = new CouncilStorage(this);
            this.TechnicalCommitteeStorage = new TechnicalCommitteeStorage(this);
            this.CouncilMembershipStorage = new CouncilMembershipStorage(this);
            this.TechnicalCommitteeMembershipStorage = new TechnicalCommitteeMembershipStorage(this);
            this.FellowshipCollectiveStorage = new FellowshipCollectiveStorage(this);
            this.FellowshipReferendaStorage = new FellowshipReferendaStorage(this);
            this.SchedulerStorage = new SchedulerStorage(this);
            this.OriginsStorage = new OriginsStorage(this);
            this.XcmpQueueStorage = new XcmpQueueStorage(this);
            this.PolkadotXcmStorage = new PolkadotXcmStorage(this);
            this.CumulusXcmStorage = new CumulusXcmStorage(this);
            this.DmpQueueStorage = new DmpQueueStorage(this);
            this.InflationStorage = new InflationStorage(this);
            this.UniqueStorage = new UniqueStorage(this);
            this.ConfigurationStorage = new ConfigurationStorage(this);
            this.ChargingStorage = new ChargingStorage(this);
            this.CommonStorage = new CommonStorage(this);
            this.FungibleStorage = new FungibleStorage(this);
            this.RefungibleStorage = new RefungibleStorage(this);
            this.NonfungibleStorage = new NonfungibleStorage(this);
            this.StructureStorage = new StructureStorage(this);
            this.AppPromotionStorage = new AppPromotionStorage(this);
            this.ForeignAssetsStorage = new ForeignAssetsStorage(this);
            this.EVMStorage = new EVMStorage(this);
            this.EthereumStorage = new EthereumStorage(this);
            this.EvmCoderSubstrateStorage = new EvmCoderSubstrateStorage(this);
            this.EvmContractHelpersStorage = new EvmContractHelpersStorage(this);
            this.EvmTransactionPaymentStorage = new EvmTransactionPaymentStorage(this);
            this.EvmMigrationStorage = new EvmMigrationStorage(this);
            this.MaintenanceStorage = new MaintenanceStorage(this);
            this.BalancesAdapterStorage = new BalancesAdapterStorage(this);
            this.UtilityStorage = new UtilityStorage(this);
            this.TestUtilsStorage = new TestUtilsStorage(this);
        }
    }
}