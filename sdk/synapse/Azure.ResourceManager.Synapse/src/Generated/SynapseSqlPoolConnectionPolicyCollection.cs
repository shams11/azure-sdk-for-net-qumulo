// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
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
    /// A class representing a collection of <see cref="SynapseSqlPoolConnectionPolicyResource" /> and their operations.
    /// Each <see cref="SynapseSqlPoolConnectionPolicyResource" /> in the collection will belong to the same instance of <see cref="SynapseSqlPoolResource" />.
    /// To get a <see cref="SynapseSqlPoolConnectionPolicyCollection" /> instance call the GetSynapseSqlPoolConnectionPolicies method from an instance of <see cref="SynapseSqlPoolResource" />.
    /// </summary>
    public partial class SynapseSqlPoolConnectionPolicyCollection : ArmCollection
    {
        private readonly ClientDiagnostics _synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesClientDiagnostics;
        private readonly SqlPoolConnectionPoliciesRestOperations _synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseSqlPoolConnectionPolicyCollection"/> class for mocking. </summary>
        protected SynapseSqlPoolConnectionPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseSqlPoolConnectionPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseSqlPoolConnectionPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseSqlPoolConnectionPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseSqlPoolConnectionPolicyResource.ResourceType, out string synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesApiVersion);
            _synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesRestClient = new SqlPoolConnectionPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseSqlPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseSqlPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a Sql pool&apos;s connection policy, which is used with table auditing.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/connectionPolicies/{connectionPolicyName}
        /// Operation Id: SqlPoolConnectionPolicies_Get
        /// </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseSqlPoolConnectionPolicyResource>> GetAsync(SqlPoolConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesClientDiagnostics.CreateScope("SynapseSqlPoolConnectionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolConnectionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Sql pool&apos;s connection policy, which is used with table auditing.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/connectionPolicies/{connectionPolicyName}
        /// Operation Id: SqlPoolConnectionPolicies_Get
        /// </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseSqlPoolConnectionPolicyResource> Get(SqlPoolConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesClientDiagnostics.CreateScope("SynapseSqlPoolConnectionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolConnectionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/connectionPolicies/{connectionPolicyName}
        /// Operation Id: SqlPoolConnectionPolicies_Get
        /// </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SqlPoolConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesClientDiagnostics.CreateScope("SynapseSqlPoolConnectionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/connectionPolicies/{connectionPolicyName}
        /// Operation Id: SqlPoolConnectionPolicies_Get
        /// </summary>
        /// <param name="connectionPolicyName"> The name of the connection policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SqlPoolConnectionPolicyName connectionPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesClientDiagnostics.CreateScope("SynapseSqlPoolConnectionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolConnectionPolicySqlPoolConnectionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connectionPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
