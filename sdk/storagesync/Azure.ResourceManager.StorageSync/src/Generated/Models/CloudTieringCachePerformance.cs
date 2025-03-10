// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Server endpoint cloud tiering status object. </summary>
    public partial class CloudTieringCachePerformance
    {
        /// <summary> Initializes a new instance of CloudTieringCachePerformance. </summary>
        internal CloudTieringCachePerformance()
        {
        }

        /// <summary> Initializes a new instance of CloudTieringCachePerformance. </summary>
        /// <param name="lastUpdatedOn"> Last updated timestamp. </param>
        /// <param name="cacheHitBytes"> Count of bytes that were served from the local server. </param>
        /// <param name="cacheMissBytes"> Count of bytes that were served from the cloud. </param>
        /// <param name="cacheHitBytesPercent"> Percentage of total bytes (hit + miss) that were served from the local server. </param>
        internal CloudTieringCachePerformance(DateTimeOffset? lastUpdatedOn, long? cacheHitBytes, long? cacheMissBytes, int? cacheHitBytesPercent)
        {
            LastUpdatedOn = lastUpdatedOn;
            CacheHitBytes = cacheHitBytes;
            CacheMissBytes = cacheMissBytes;
            CacheHitBytesPercent = cacheHitBytesPercent;
        }

        /// <summary> Last updated timestamp. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> Count of bytes that were served from the local server. </summary>
        public long? CacheHitBytes { get; }
        /// <summary> Count of bytes that were served from the cloud. </summary>
        public long? CacheMissBytes { get; }
        /// <summary> Percentage of total bytes (hit + miss) that were served from the local server. </summary>
        public int? CacheHitBytesPercent { get; }
    }
}
