// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Cloud endpoint AFS file share metadata signing certificate public keys. </summary>
    public partial class CloudEndpointAfsShareMetadataCertificatePublicKeys
    {
        /// <summary> Initializes a new instance of CloudEndpointAfsShareMetadataCertificatePublicKeys. </summary>
        internal CloudEndpointAfsShareMetadataCertificatePublicKeys()
        {
        }

        /// <summary> Initializes a new instance of CloudEndpointAfsShareMetadataCertificatePublicKeys. </summary>
        /// <param name="firstKey"> The first public key. </param>
        /// <param name="secondKey"> The second public key. </param>
        internal CloudEndpointAfsShareMetadataCertificatePublicKeys(string firstKey, string secondKey)
        {
            FirstKey = firstKey;
            SecondKey = secondKey;
        }

        /// <summary> The first public key. </summary>
        public string FirstKey { get; }
        /// <summary> The second public key. </summary>
        public string SecondKey { get; }
    }
}
