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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningBatchEndpointResource" /> and their operations.
    /// Each <see cref="MachineLearningBatchEndpointResource" /> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource" />.
    /// To get a <see cref="MachineLearningBatchEndpointCollection" /> instance call the GetMachineLearningBatchEndpoints method from an instance of <see cref="MachineLearningWorkspaceResource" />.
    /// </summary>
    public partial class MachineLearningBatchEndpointCollection : ArmCollection, IEnumerable<MachineLearningBatchEndpointResource>, IAsyncEnumerable<MachineLearningBatchEndpointResource>
    {
        private readonly ClientDiagnostics _machineLearningBatchEndpointBatchEndpointsClientDiagnostics;
        private readonly BatchEndpointsRestOperations _machineLearningBatchEndpointBatchEndpointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningBatchEndpointCollection"/> class for mocking. </summary>
        protected MachineLearningBatchEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningBatchEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningBatchEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningBatchEndpointBatchEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningBatchEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningBatchEndpointResource.ResourceType, out string machineLearningBatchEndpointBatchEndpointsApiVersion);
            _machineLearningBatchEndpointBatchEndpointsRestClient = new BatchEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningBatchEndpointBatchEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a batch inference endpoint (asynchronous).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}
        /// Operation Id: BatchEndpoints_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> Name for the Batch inference endpoint. </param>
        /// <param name="data"> Batch inference endpoint definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningBatchEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string endpointName, MachineLearningBatchEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningBatchEndpointBatchEndpointsClientDiagnostics.CreateScope("MachineLearningBatchEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningBatchEndpointBatchEndpointsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningBatchEndpointResource>(new MachineLearningBatchEndpointOperationSource(Client), _machineLearningBatchEndpointBatchEndpointsClientDiagnostics, Pipeline, _machineLearningBatchEndpointBatchEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a batch inference endpoint (asynchronous).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}
        /// Operation Id: BatchEndpoints_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> Name for the Batch inference endpoint. </param>
        /// <param name="data"> Batch inference endpoint definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningBatchEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string endpointName, MachineLearningBatchEndpointData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningBatchEndpointBatchEndpointsClientDiagnostics.CreateScope("MachineLearningBatchEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningBatchEndpointBatchEndpointsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningBatchEndpointResource>(new MachineLearningBatchEndpointOperationSource(Client), _machineLearningBatchEndpointBatchEndpointsClientDiagnostics, Pipeline, _machineLearningBatchEndpointBatchEndpointsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a batch inference endpoint by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}
        /// Operation Id: BatchEndpoints_Get
        /// </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<MachineLearningBatchEndpointResource>> GetAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _machineLearningBatchEndpointBatchEndpointsClientDiagnostics.CreateScope("MachineLearningBatchEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningBatchEndpointBatchEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningBatchEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a batch inference endpoint by name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}
        /// Operation Id: BatchEndpoints_Get
        /// </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<MachineLearningBatchEndpointResource> Get(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _machineLearningBatchEndpointBatchEndpointsClientDiagnostics.CreateScope("MachineLearningBatchEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningBatchEndpointBatchEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningBatchEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists Batch inference endpoint in the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints
        /// Operation Id: BatchEndpoints_List
        /// </summary>
        /// <param name="count"> Number of endpoints to be retrieved in a page of results. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningBatchEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningBatchEndpointResource> GetAllAsync(int? count = null, string skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<MachineLearningBatchEndpointResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _machineLearningBatchEndpointBatchEndpointsClientDiagnostics.CreateScope("MachineLearningBatchEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _machineLearningBatchEndpointBatchEndpointsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, count, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineLearningBatchEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MachineLearningBatchEndpointResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _machineLearningBatchEndpointBatchEndpointsClientDiagnostics.CreateScope("MachineLearningBatchEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _machineLearningBatchEndpointBatchEndpointsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, count, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineLearningBatchEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists Batch inference endpoint in the workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints
        /// Operation Id: BatchEndpoints_List
        /// </summary>
        /// <param name="count"> Number of endpoints to be retrieved in a page of results. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningBatchEndpointResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningBatchEndpointResource> GetAll(int? count = null, string skip = null, CancellationToken cancellationToken = default)
        {
            Page<MachineLearningBatchEndpointResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _machineLearningBatchEndpointBatchEndpointsClientDiagnostics.CreateScope("MachineLearningBatchEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _machineLearningBatchEndpointBatchEndpointsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, count, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineLearningBatchEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MachineLearningBatchEndpointResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _machineLearningBatchEndpointBatchEndpointsClientDiagnostics.CreateScope("MachineLearningBatchEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _machineLearningBatchEndpointBatchEndpointsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, count, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MachineLearningBatchEndpointResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}
        /// Operation Id: BatchEndpoints_Get
        /// </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _machineLearningBatchEndpointBatchEndpointsClientDiagnostics.CreateScope("MachineLearningBatchEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningBatchEndpointBatchEndpointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}
        /// Operation Id: BatchEndpoints_Get
        /// </summary>
        /// <param name="endpointName"> Name for the Batch Endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _machineLearningBatchEndpointBatchEndpointsClientDiagnostics.CreateScope("MachineLearningBatchEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningBatchEndpointBatchEndpointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningBatchEndpointResource> IEnumerable<MachineLearningBatchEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningBatchEndpointResource> IAsyncEnumerable<MachineLearningBatchEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
