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

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing a collection of <see cref="AfdOriginResource" /> and their operations.
    /// Each <see cref="AfdOriginResource" /> in the collection will belong to the same instance of <see cref="AfdOriginGroupResource" />.
    /// To get an <see cref="AfdOriginCollection" /> instance call the GetAfdOrigins method from an instance of <see cref="AfdOriginGroupResource" />.
    /// </summary>
    public partial class AfdOriginCollection : ArmCollection, IEnumerable<AfdOriginResource>, IAsyncEnumerable<AfdOriginResource>
    {
        private readonly ClientDiagnostics _afdOriginClientDiagnostics;
        private readonly AfdOriginsRestOperations _afdOriginRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdOriginCollection"/> class for mocking. </summary>
        protected AfdOriginCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AfdOriginCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AfdOriginCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _afdOriginClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", AfdOriginResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AfdOriginResource.ResourceType, out string afdOriginApiVersion);
            _afdOriginRestClient = new AfdOriginsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, afdOriginApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AfdOriginGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AfdOriginGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new origin within the specified origin group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}
        /// Operation Id: AfdOrigins_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="originName"> Name of the origin that is unique within the profile. </param>
        /// <param name="data"> Origin properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AfdOriginResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string originName, AfdOriginData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _afdOriginClientDiagnostics.CreateScope("AfdOriginCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdOriginRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<AfdOriginResource>(new AfdOriginOperationSource(Client), _afdOriginClientDiagnostics, Pipeline, _afdOriginRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new origin within the specified origin group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}
        /// Operation Id: AfdOrigins_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="originName"> Name of the origin that is unique within the profile. </param>
        /// <param name="data"> Origin properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AfdOriginResource> CreateOrUpdate(WaitUntil waitUntil, string originName, AfdOriginData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _afdOriginClientDiagnostics.CreateScope("AfdOriginCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdOriginRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, data, cancellationToken);
                var operation = new CdnArmOperation<AfdOriginResource>(new AfdOriginOperationSource(Client), _afdOriginClientDiagnostics, Pipeline, _afdOriginRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets an existing origin within an origin group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}
        /// Operation Id: AfdOrigins_Get
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual async Task<Response<AfdOriginResource>> GetAsync(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _afdOriginClientDiagnostics.CreateScope("AfdOriginCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdOriginRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdOriginResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing origin within an origin group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}
        /// Operation Id: AfdOrigins_Get
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual Response<AfdOriginResource> Get(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _afdOriginClientDiagnostics.CreateScope("AfdOriginCollection.Get");
            scope.Start();
            try
            {
                var response = _afdOriginRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdOriginResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the existing origins within an origin group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins
        /// Operation Id: AfdOrigins_ListByOriginGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdOriginResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdOriginResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdOriginResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdOriginClientDiagnostics.CreateScope("AfdOriginCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdOriginRestClient.ListByOriginGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdOriginResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdOriginResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdOriginClientDiagnostics.CreateScope("AfdOriginCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdOriginRestClient.ListByOriginGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdOriginResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all of the existing origins within an origin group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins
        /// Operation Id: AfdOrigins_ListByOriginGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdOriginResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdOriginResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdOriginResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdOriginClientDiagnostics.CreateScope("AfdOriginCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdOriginRestClient.ListByOriginGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdOriginResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdOriginResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdOriginClientDiagnostics.CreateScope("AfdOriginCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdOriginRestClient.ListByOriginGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdOriginResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}
        /// Operation Id: AfdOrigins_Get
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _afdOriginClientDiagnostics.CreateScope("AfdOriginCollection.Exists");
            scope.Start();
            try
            {
                var response = await _afdOriginRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}/origins/{originName}
        /// Operation Id: AfdOrigins_Get
        /// </summary>
        /// <param name="originName"> Name of the origin which is unique within the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="originName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="originName"/> is null. </exception>
        public virtual Response<bool> Exists(string originName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(originName, nameof(originName));

            using var scope = _afdOriginClientDiagnostics.CreateScope("AfdOriginCollection.Exists");
            scope.Start();
            try
            {
                var response = _afdOriginRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, originName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AfdOriginResource> IEnumerable<AfdOriginResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AfdOriginResource> IAsyncEnumerable<AfdOriginResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
