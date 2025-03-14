﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.Identity
{
    /// <summary>
    /// Options to configure the <see cref="UsernamePasswordCredential"/>.
    /// </summary>
    public class UsernamePasswordCredentialOptions : TokenCredentialOptions, ITokenCacheOptions
    {
        /// <summary>
        /// Specifies the <see cref="TokenCachePersistenceOptions"/> to be used by the credential. If not options are specified, the token cache will not be persisted to disk.
        /// </summary>
        public TokenCachePersistenceOptions TokenCachePersistenceOptions { get; set; }

        /// <summary>
        /// For multi-tenant applications, specifies additional tenants for which the credential may acquire tokens. Add the wildcard value "*" to allow the credential to acquire tokens for any tenant in which the application is installed.
        /// </summary>
        public IList<string> AdditionallyAllowedTenants => AdditionallyAllowedTenantsCore;
    }
}
