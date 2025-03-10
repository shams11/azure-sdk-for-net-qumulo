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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseServerBlobAuditingPolicyResource" /> and their operations.
    /// Each <see cref="SynapseServerBlobAuditingPolicyResource" /> in the collection will belong to the same instance of <see cref="SynapseWorkspaceResource" />.
    /// To get a <see cref="SynapseServerBlobAuditingPolicyCollection" /> instance call the GetSynapseServerBlobAuditingPolicies method from an instance of <see cref="SynapseWorkspaceResource" />.
    /// </summary>
    public partial class SynapseServerBlobAuditingPolicyCollection : ArmCollection, IEnumerable<SynapseServerBlobAuditingPolicyResource>, IAsyncEnumerable<SynapseServerBlobAuditingPolicyResource>
    {
        private readonly ClientDiagnostics _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics;
        private readonly WorkspaceManagedSqlServerBlobAuditingPoliciesRestOperations _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseServerBlobAuditingPolicyCollection"/> class for mocking. </summary>
        protected SynapseServerBlobAuditingPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseServerBlobAuditingPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseServerBlobAuditingPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseServerBlobAuditingPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseServerBlobAuditingPolicyResource.ResourceType, out string synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesApiVersion);
            _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient = new WorkspaceManagedSqlServerBlobAuditingPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update a workspace managed sql server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: WorkspaceManagedSqlServerBlobAuditingPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="data"> Properties of extended blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseServerBlobAuditingPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SynapseBlobAuditingPolicyName blobAuditingPolicyName, SynapseServerBlobAuditingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseServerBlobAuditingPolicyResource>(new SynapseServerBlobAuditingPolicyOperationSource(Client), _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics, Pipeline, _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or Update a workspace managed sql server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: WorkspaceManagedSqlServerBlobAuditingPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="data"> Properties of extended blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseServerBlobAuditingPolicyResource> CreateOrUpdate(WaitUntil waitUntil, SynapseBlobAuditingPolicyName blobAuditingPolicyName, SynapseServerBlobAuditingPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseServerBlobAuditingPolicyResource>(new SynapseServerBlobAuditingPolicyOperationSource(Client), _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics, Pipeline, _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a workspace managed sql server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: WorkspaceManagedSqlServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseServerBlobAuditingPolicyResource>> GetAsync(SynapseBlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a workspace managed sql server&apos;s blob auditing policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: WorkspaceManagedSqlServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseServerBlobAuditingPolicyResource> Get(SynapseBlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseServerBlobAuditingPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List workspace managed sql server&apos;s blob auditing policies.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings
        /// Operation Id: WorkspaceManagedSqlServerBlobAuditingPolicies_ListByWorkspace
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseServerBlobAuditingPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseServerBlobAuditingPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SynapseServerBlobAuditingPolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.ListByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SynapseServerBlobAuditingPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SynapseServerBlobAuditingPolicyResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.ListByWorkspaceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SynapseServerBlobAuditingPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List workspace managed sql server&apos;s blob auditing policies.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings
        /// Operation Id: WorkspaceManagedSqlServerBlobAuditingPolicies_ListByWorkspace
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseServerBlobAuditingPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseServerBlobAuditingPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SynapseServerBlobAuditingPolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.ListByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SynapseServerBlobAuditingPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SynapseServerBlobAuditingPolicyResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.ListByWorkspaceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SynapseServerBlobAuditingPolicyResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: WorkspaceManagedSqlServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SynapseBlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/auditingSettings/{blobAuditingPolicyName}
        /// Operation Id: WorkspaceManagedSqlServerBlobAuditingPolicies_Get
        /// </summary>
        /// <param name="blobAuditingPolicyName"> The name of the blob auditing policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SynapseBlobAuditingPolicyName blobAuditingPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesClientDiagnostics.CreateScope("SynapseServerBlobAuditingPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseServerBlobAuditingPolicyWorkspaceManagedSqlServerBlobAuditingPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobAuditingPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseServerBlobAuditingPolicyResource> IEnumerable<SynapseServerBlobAuditingPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseServerBlobAuditingPolicyResource> IAsyncEnumerable<SynapseServerBlobAuditingPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
