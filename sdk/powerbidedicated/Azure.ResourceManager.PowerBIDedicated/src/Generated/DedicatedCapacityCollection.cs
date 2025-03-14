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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PowerBIDedicated
{
    /// <summary>
    /// A class representing a collection of <see cref="DedicatedCapacityResource" /> and their operations.
    /// Each <see cref="DedicatedCapacityResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DedicatedCapacityCollection" /> instance call the GetDedicatedCapacities method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DedicatedCapacityCollection : ArmCollection, IEnumerable<DedicatedCapacityResource>, IAsyncEnumerable<DedicatedCapacityResource>
    {
        private readonly ClientDiagnostics _dedicatedCapacityCapacitiesClientDiagnostics;
        private readonly CapacitiesRestOperations _dedicatedCapacityCapacitiesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DedicatedCapacityCollection"/> class for mocking. </summary>
        protected DedicatedCapacityCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DedicatedCapacityCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DedicatedCapacityCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dedicatedCapacityCapacitiesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PowerBIDedicated", DedicatedCapacityResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DedicatedCapacityResource.ResourceType, out string dedicatedCapacityCapacitiesApiVersion);
            _dedicatedCapacityCapacitiesRestClient = new CapacitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dedicatedCapacityCapacitiesApiVersion);
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
        /// Provisions the specified Dedicated capacity based on the configuration specified in the request.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/capacities/{dedicatedCapacityName}
        /// Operation Id: Capacities_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dedicatedCapacityName"> The name of the Dedicated capacity. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="data"> Contains the information used to provision the Dedicated capacity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dedicatedCapacityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dedicatedCapacityName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DedicatedCapacityResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dedicatedCapacityName, DedicatedCapacityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dedicatedCapacityName, nameof(dedicatedCapacityName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dedicatedCapacityCapacitiesClientDiagnostics.CreateScope("DedicatedCapacityCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dedicatedCapacityCapacitiesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, dedicatedCapacityName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PowerBIDedicatedArmOperation<DedicatedCapacityResource>(new DedicatedCapacityOperationSource(Client), _dedicatedCapacityCapacitiesClientDiagnostics, Pipeline, _dedicatedCapacityCapacitiesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, dedicatedCapacityName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Provisions the specified Dedicated capacity based on the configuration specified in the request.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/capacities/{dedicatedCapacityName}
        /// Operation Id: Capacities_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dedicatedCapacityName"> The name of the Dedicated capacity. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="data"> Contains the information used to provision the Dedicated capacity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dedicatedCapacityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dedicatedCapacityName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DedicatedCapacityResource> CreateOrUpdate(WaitUntil waitUntil, string dedicatedCapacityName, DedicatedCapacityData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dedicatedCapacityName, nameof(dedicatedCapacityName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dedicatedCapacityCapacitiesClientDiagnostics.CreateScope("DedicatedCapacityCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dedicatedCapacityCapacitiesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, dedicatedCapacityName, data, cancellationToken);
                var operation = new PowerBIDedicatedArmOperation<DedicatedCapacityResource>(new DedicatedCapacityOperationSource(Client), _dedicatedCapacityCapacitiesClientDiagnostics, Pipeline, _dedicatedCapacityCapacitiesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, dedicatedCapacityName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets details about the specified dedicated capacity.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/capacities/{dedicatedCapacityName}
        /// Operation Id: Capacities_GetDetails
        /// </summary>
        /// <param name="dedicatedCapacityName"> The name of the dedicated capacity. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dedicatedCapacityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dedicatedCapacityName"/> is null. </exception>
        public virtual async Task<Response<DedicatedCapacityResource>> GetAsync(string dedicatedCapacityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dedicatedCapacityName, nameof(dedicatedCapacityName));

            using var scope = _dedicatedCapacityCapacitiesClientDiagnostics.CreateScope("DedicatedCapacityCollection.Get");
            scope.Start();
            try
            {
                var response = await _dedicatedCapacityCapacitiesRestClient.GetDetailsAsync(Id.SubscriptionId, Id.ResourceGroupName, dedicatedCapacityName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DedicatedCapacityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details about the specified dedicated capacity.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/capacities/{dedicatedCapacityName}
        /// Operation Id: Capacities_GetDetails
        /// </summary>
        /// <param name="dedicatedCapacityName"> The name of the dedicated capacity. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dedicatedCapacityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dedicatedCapacityName"/> is null. </exception>
        public virtual Response<DedicatedCapacityResource> Get(string dedicatedCapacityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dedicatedCapacityName, nameof(dedicatedCapacityName));

            using var scope = _dedicatedCapacityCapacitiesClientDiagnostics.CreateScope("DedicatedCapacityCollection.Get");
            scope.Start();
            try
            {
                var response = _dedicatedCapacityCapacitiesRestClient.GetDetails(Id.SubscriptionId, Id.ResourceGroupName, dedicatedCapacityName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DedicatedCapacityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the Dedicated capacities for the given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/capacities
        /// Operation Id: Capacities_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DedicatedCapacityResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DedicatedCapacityResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DedicatedCapacityResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dedicatedCapacityCapacitiesClientDiagnostics.CreateScope("DedicatedCapacityCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dedicatedCapacityCapacitiesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedCapacityResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Gets all the Dedicated capacities for the given resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/capacities
        /// Operation Id: Capacities_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DedicatedCapacityResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DedicatedCapacityResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DedicatedCapacityResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dedicatedCapacityCapacitiesClientDiagnostics.CreateScope("DedicatedCapacityCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dedicatedCapacityCapacitiesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedCapacityResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/capacities/{dedicatedCapacityName}
        /// Operation Id: Capacities_GetDetails
        /// </summary>
        /// <param name="dedicatedCapacityName"> The name of the dedicated capacity. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dedicatedCapacityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dedicatedCapacityName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dedicatedCapacityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dedicatedCapacityName, nameof(dedicatedCapacityName));

            using var scope = _dedicatedCapacityCapacitiesClientDiagnostics.CreateScope("DedicatedCapacityCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dedicatedCapacityCapacitiesRestClient.GetDetailsAsync(Id.SubscriptionId, Id.ResourceGroupName, dedicatedCapacityName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.PowerBIDedicated/capacities/{dedicatedCapacityName}
        /// Operation Id: Capacities_GetDetails
        /// </summary>
        /// <param name="dedicatedCapacityName"> The name of the dedicated capacity. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dedicatedCapacityName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dedicatedCapacityName"/> is null. </exception>
        public virtual Response<bool> Exists(string dedicatedCapacityName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dedicatedCapacityName, nameof(dedicatedCapacityName));

            using var scope = _dedicatedCapacityCapacitiesClientDiagnostics.CreateScope("DedicatedCapacityCollection.Exists");
            scope.Start();
            try
            {
                var response = _dedicatedCapacityCapacitiesRestClient.GetDetails(Id.SubscriptionId, Id.ResourceGroupName, dedicatedCapacityName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DedicatedCapacityResource> IEnumerable<DedicatedCapacityResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DedicatedCapacityResource> IAsyncEnumerable<DedicatedCapacityResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
