using Substrate.NetApi;
using Substrate.NetApi.Model.Types;

namespace UniqueSDK
{
	public static class GenericHelpers
	{
        /// <summary>
        /// Convert address string to public key
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static byte[] ToPublicKey(this string address)
        {
            return Utils.GetPublicKeyFrom(address);
        }

        /// <summary>
        /// Convert address string to AccountId32
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 ToOpalAccountId32(this string address)
        {
            var account32 = new Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            account32.Create(address.ToPublicKey());

            return account32;
        }

        /// <summary>
        /// Convert address string to AccountId32
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 ToUniqueAccountId32(this string address)
        {
            var account32 = new Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            account32.Create(address.ToPublicKey());

            return account32;
        }

        /// <summary>
        /// Convert Account to AccountId32
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 ToOpalAccountId32(this Account account)
        {
            var account32 = new Substrate.Opal.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            account32.Create(account.Bytes);

            return account32;
        }

        /// <summary>
        /// Convert Account to AccountId32
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 ToUniqueAccountId32(this Account account)
        {
            var account32 = new Substrate.Unique.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            account32.Create(account.Bytes);

            return account32;
        }
    }
}

