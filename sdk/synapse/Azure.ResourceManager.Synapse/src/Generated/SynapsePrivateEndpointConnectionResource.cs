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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SynapsePrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SynapsePrivateEndpointConnectionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSynapsePrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseWorkspaceResource" /> using the GetSynapsePrivateEndpointConnection method.
    /// </summary>
    public partial class SynapsePrivateEndpointConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapsePrivateEndpointConnectionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapsePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics;
        private readonly PrivateEndpointConnectionsRestOperations _synapsePrivateEndpointConnectionPrivateEndpointConnectionsRestClient;
        private readonly SynapsePrivateEndpointConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="SynapsePrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected SynapsePrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SynapsePrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapsePrivateEndpointConnectionResource(ArmClient client, SynapsePrivateEndpointConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapsePrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapsePrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapsePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapsePrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
            _synapsePrivateEndpointConnectionPrivateEndpointConnectionsRestClient = new PrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapsePrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/privateEndpointConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapsePrivateEndpointConnectionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a private endpoint connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapsePrivateEndpointConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _synapsePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("SynapsePrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _synapsePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapsePrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a private endpoint connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapsePrivateEndpointConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _synapsePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("SynapsePrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _synapsePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapsePrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a private endpoint connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnections_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _synapsePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("SynapsePrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _synapsePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation(_synapsePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _synapsePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a private endpoint connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnections_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _synapsePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("SynapsePrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _synapsePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SynapseArmOperation(_synapsePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _synapsePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Approve or reject a private endpoint connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnections_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request body of private endpoint connection to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapsePrivateEndpointConnectionResource>> UpdateAsync(WaitUntil waitUntil, SynapsePrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapsePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("SynapsePrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _synapsePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapsePrivateEndpointConnectionResource>(new SynapsePrivateEndpointConnectionOperationSource(Client), _synapsePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _synapsePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Approve or reject a private endpoint connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: PrivateEndpointConnections_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request body of private endpoint connection to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapsePrivateEndpointConnectionResource> Update(WaitUntil waitUntil, SynapsePrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapsePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("SynapsePrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _synapsePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapsePrivateEndpointConnectionResource>(new SynapsePrivateEndpointConnectionOperationSource(Client), _synapsePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, _synapsePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
