﻿using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Rpc;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Primitive;

namespace UniqueSDK
{
    public static class EventsModel
    {
        /// <summary>
        /// Gets all extrinsic events in the block
        /// </summary>
        /// <param name="substrateClient"></param>
        /// <param name="blockHash"></param>
        /// <param name="unCheckedExtrinsic"></param>
        /// <returns>all events for the given extrinsic</returns>
        /// <exception cref="ExtrinsicIndexNotFoundException"></exception>
        public static async Task<IEnumerable<Substrate.Opal.NET.NetApiExt.Generated.Model.frame_system.EventRecord>> GetExtrinsicEventsAsync(
            this Substrate.Opal.NET.NetApiExt.Generated.SubstrateClientExt substrateClient,
            Hash blockHash,
            UnCheckedExtrinsic unCheckedExtrinsic
        )
        {
            var events = await substrateClient.SystemStorage.Events(blockHash.Value, CancellationToken.None);

            BlockData block = await substrateClient.Chain.GetBlockAsync(blockHash, CancellationToken.None);

            int? extrinsicIndex = null;
            for (int i = 0; i < block.Block.Extrinsics.Count(); i++)
            {
                var extrinsic = block.Block.Extrinsics[i];

                if (Utils.Bytes2HexString(extrinsic.Encode()).Equals(Utils.Bytes2HexString(unCheckedExtrinsic.Encode())))
                {
                    extrinsicIndex = i;
                    break;
                }
            };

            if (extrinsicIndex is null)
            {
                throw new ExtrinsicIndexNotFoundException();
            }

            return events.Value.Where(p => p.Phase.Value == Substrate.Opal.NET.NetApiExt.Generated.Model.frame_system.Phase.ApplyExtrinsic && ((U32)p.Phase.Value2).Value == extrinsicIndex);
        }

        /// <summary>
        /// Gets all extrinsic events in the block
        /// </summary>
        /// <param name="substrateClient"></param>
        /// <param name="blockHash"></param>
        /// <param name="unCheckedExtrinsic"></param>
        /// <returns>all events for the given extrinsic</returns>
        /// <exception cref="ExtrinsicIndexNotFoundException"></exception>
        public static async Task<IEnumerable<Substrate.Unique.NET.NetApiExt.Generated.Model.frame_system.EventRecord>> GetExtrinsicEventsAsync(
            this Substrate.Unique.NET.NetApiExt.Generated.SubstrateClientExt substrateClient,
            Hash blockHash,
            UnCheckedExtrinsic unCheckedExtrinsic
        )
        {
            var events = await substrateClient.SystemStorage.Events(blockHash.Value, CancellationToken.None);

            BlockData block = await substrateClient.Chain.GetBlockAsync(blockHash, CancellationToken.None);

            int? extrinsicIndex = null;
            for (int i = 0; i < block.Block.Extrinsics.Count(); i++)
            {
                var extrinsic = block.Block.Extrinsics[i];

                if (Utils.Bytes2HexString(extrinsic.Encode()).Equals(Utils.Bytes2HexString(unCheckedExtrinsic.Encode())))
                {
                    extrinsicIndex = i;
                    break;
                }
            };

            if (extrinsicIndex is null)
            {
                throw new ExtrinsicIndexNotFoundException();
            }

            return events.Value.Where(p => p.Phase.Value == Substrate.Unique.NET.NetApiExt.Generated.Model.frame_system.Phase.ApplyExtrinsic && ((U32)p.Phase.Value2).Value == extrinsicIndex);
        }
    }
}

