// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="VaultSettingResource" /> and their operations.
    /// Each <see cref="VaultSettingResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="VaultSettingCollection" /> instance call the GetVaultSettings method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class VaultSettingCollection : ArmCollection, IEnumerable<VaultSettingResource>, IAsyncEnumerable<VaultSettingResource>
    {
        private readonly ClientDiagnostics _vaultSettingReplicationVaultSettingClientDiagnostics;
        private readonly ReplicationVaultSettingRestOperations _vaultSettingReplicationVaultSettingRestClient;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="VaultSettingCollection"/> class for mocking. </summary>
        protected VaultSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VaultSettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal VaultSettingCollection(ArmClient client, ResourceIdentifier id, string resourceName) : base(client, id)
        {
            _resourceName = resourceName;
            _vaultSettingReplicationVaultSettingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", VaultSettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VaultSettingResource.ResourceType, out string vaultSettingReplicationVaultSettingApiVersion);
            _vaultSettingReplicationVaultSettingRestClient = new ReplicationVaultSettingRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vaultSettingReplicationVaultSettingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to configure vault setting.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationVaultSettings/{vaultSettingName}
        /// Operation Id: ReplicationVaultSetting_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultSettingName"> Vault setting name. </param>
        /// <param name="content"> Vault setting creation input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultSettingName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<VaultSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vaultSettingName, VaultSettingCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultSettingName, nameof(vaultSettingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _vaultSettingReplicationVaultSettingClientDiagnostics.CreateScope("VaultSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vaultSettingReplicationVaultSettingRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, vaultSettingName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<VaultSettingResource>(new VaultSettingOperationSource(Client), _vaultSettingReplicationVaultSettingClientDiagnostics, Pipeline, _vaultSettingReplicationVaultSettingRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, vaultSettingName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to configure vault setting.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationVaultSettings/{vaultSettingName}
        /// Operation Id: ReplicationVaultSetting_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultSettingName"> Vault setting name. </param>
        /// <param name="content"> Vault setting creation input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultSettingName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<VaultSettingResource> CreateOrUpdate(WaitUntil waitUntil, string vaultSettingName, VaultSettingCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultSettingName, nameof(vaultSettingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _vaultSettingReplicationVaultSettingClientDiagnostics.CreateScope("VaultSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vaultSettingReplicationVaultSettingRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, vaultSettingName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<VaultSettingResource>(new VaultSettingOperationSource(Client), _vaultSettingReplicationVaultSettingClientDiagnostics, Pipeline, _vaultSettingReplicationVaultSettingRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, vaultSettingName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the vault setting. This includes the Migration Hub connection settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationVaultSettings/{vaultSettingName}
        /// Operation Id: ReplicationVaultSetting_Get
        /// </summary>
        /// <param name="vaultSettingName"> Vault setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultSettingName"/> is null. </exception>
        public virtual async Task<Response<VaultSettingResource>> GetAsync(string vaultSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultSettingName, nameof(vaultSettingName));

            using var scope = _vaultSettingReplicationVaultSettingClientDiagnostics.CreateScope("VaultSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _vaultSettingReplicationVaultSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, vaultSettingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VaultSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the vault setting. This includes the Migration Hub connection settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationVaultSettings/{vaultSettingName}
        /// Operation Id: ReplicationVaultSetting_Get
        /// </summary>
        /// <param name="vaultSettingName"> Vault setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultSettingName"/> is null. </exception>
        public virtual Response<VaultSettingResource> Get(string vaultSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultSettingName, nameof(vaultSettingName));

            using var scope = _vaultSettingReplicationVaultSettingClientDiagnostics.CreateScope("VaultSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _vaultSettingReplicationVaultSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, vaultSettingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VaultSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of vault setting. This includes the Migration Hub connection settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationVaultSettings
        /// Operation Id: ReplicationVaultSetting_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VaultSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VaultSettingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VaultSettingResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vaultSettingReplicationVaultSettingClientDiagnostics.CreateScope("VaultSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vaultSettingReplicationVaultSettingRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultSettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VaultSettingResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vaultSettingReplicationVaultSettingClientDiagnostics.CreateScope("VaultSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vaultSettingReplicationVaultSettingRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultSettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets the list of vault setting. This includes the Migration Hub connection settings.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationVaultSettings
        /// Operation Id: ReplicationVaultSetting_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VaultSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VaultSettingResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VaultSettingResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vaultSettingReplicationVaultSettingClientDiagnostics.CreateScope("VaultSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vaultSettingReplicationVaultSettingRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultSettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VaultSettingResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vaultSettingReplicationVaultSettingClientDiagnostics.CreateScope("VaultSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vaultSettingReplicationVaultSettingRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VaultSettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationVaultSettings/{vaultSettingName}
        /// Operation Id: ReplicationVaultSetting_Get
        /// </summary>
        /// <param name="vaultSettingName"> Vault setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultSettingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vaultSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultSettingName, nameof(vaultSettingName));

            using var scope = _vaultSettingReplicationVaultSettingClientDiagnostics.CreateScope("VaultSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vaultSettingReplicationVaultSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, vaultSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationVaultSettings/{vaultSettingName}
        /// Operation Id: ReplicationVaultSetting_Get
        /// </summary>
        /// <param name="vaultSettingName"> Vault setting name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultSettingName"/> is null. </exception>
        public virtual Response<bool> Exists(string vaultSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vaultSettingName, nameof(vaultSettingName));

            using var scope = _vaultSettingReplicationVaultSettingClientDiagnostics.CreateScope("VaultSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _vaultSettingReplicationVaultSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, vaultSettingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VaultSettingResource> IEnumerable<VaultSettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VaultSettingResource> IAsyncEnumerable<VaultSettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
