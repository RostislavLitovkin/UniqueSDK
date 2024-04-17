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


namespace Substrate.NetApiExt.Generated.Model.ethereum.transaction
{
    
    
    /// <summary>
    /// >> TransactionV2
    /// </summary>
    public enum TransactionV2
    {
        
        /// <summary>
        /// >> Legacy
        /// </summary>
        Legacy = 0,
        
        /// <summary>
        /// >> EIP2930
        /// </summary>
        EIP2930 = 1,
        
        /// <summary>
        /// >> EIP1559
        /// </summary>
        EIP1559 = 2,
    }
    
    /// <summary>
    /// >> 340 - Variant[ethereum.transaction.TransactionV2]
    /// </summary>
    public sealed class EnumTransactionV2 : BaseEnumExt<TransactionV2, Substrate.NetApiExt.Generated.Model.ethereum.transaction.LegacyTransaction, Substrate.NetApiExt.Generated.Model.ethereum.transaction.EIP2930Transaction, Substrate.NetApiExt.Generated.Model.ethereum.transaction.EIP1559Transaction>
    {
    }
}
