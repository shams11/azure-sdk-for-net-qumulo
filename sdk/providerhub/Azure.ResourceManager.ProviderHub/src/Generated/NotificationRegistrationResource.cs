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

namespace Azure.ResourceManager.ProviderHub
{
    /// <summary>
    /// A Class representing a NotificationRegistration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NotificationRegistrationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNotificationRegistrationResource method.
    /// Otherwise you can get one from its parent resource <see cref="ProviderRegistrationResource" /> using the GetNotificationRegistration method.
    /// </summary>
    public partial class NotificationRegistrationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NotificationRegistrationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string providerNamespace, string notificationRegistrationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _notificationRegistrationClientDiagnostics;
        private readonly NotificationRegistrationsRestOperations _notificationRegistrationRestClient;
        private readonly NotificationRegistrationData _data;

        /// <summary> Initializes a new instance of the <see cref="NotificationRegistrationResource"/> class for mocking. </summary>
        protected NotificationRegistrationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NotificationRegistrationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NotificationRegistrationResource(ArmClient client, NotificationRegistrationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NotificationRegistrationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NotificationRegistrationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _notificationRegistrationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ProviderHub", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string notificationRegistrationApiVersion);
            _notificationRegistrationRestClient = new NotificationRegistrationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, notificationRegistrationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ProviderHub/providerRegistrations/notificationRegistrations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NotificationRegistrationData Data
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
        /// Gets the notification registration details.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}
        /// Operation Id: NotificationRegistrations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NotificationRegistrationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationResource.Get");
            scope.Start();
            try
            {
                var response = await _notificationRegistrationRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NotificationRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the notification registration details.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}
        /// Operation Id: NotificationRegistrations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NotificationRegistrationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationResource.Get");
            scope.Start();
            try
            {
                var response = _notificationRegistrationRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NotificationRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a notification registration.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}
        /// Operation Id: NotificationRegistrations_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationResource.Delete");
            scope.Start();
            try
            {
                var response = await _notificationRegistrationRestClient.DeleteAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation(response);
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
        /// Deletes a notification registration.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}
        /// Operation Id: NotificationRegistrations_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationResource.Delete");
            scope.Start();
            try
            {
                var response = _notificationRegistrationRestClient.Delete(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ProviderHubArmOperation(response);
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
        /// Creates or updates a notification registration.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}
        /// Operation Id: NotificationRegistrations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required body parameters supplied to the notification registration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NotificationRegistrationResource>> UpdateAsync(WaitUntil waitUntil, NotificationRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationResource.Update");
            scope.Start();
            try
            {
                var response = await _notificationRegistrationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ProviderHubArmOperation<NotificationRegistrationResource>(Response.FromValue(new NotificationRegistrationResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a notification registration.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ProviderHub/providerRegistrations/{providerNamespace}/notificationRegistrations/{notificationRegistrationName}
        /// Operation Id: NotificationRegistrations_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required body parameters supplied to the notification registration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NotificationRegistrationResource> Update(WaitUntil waitUntil, NotificationRegistrationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _notificationRegistrationClientDiagnostics.CreateScope("NotificationRegistrationResource.Update");
            scope.Start();
            try
            {
                var response = _notificationRegistrationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ProviderHubArmOperation<NotificationRegistrationResource>(Response.FromValue(new NotificationRegistrationResource(Client, response), response.GetRawResponse()));
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
