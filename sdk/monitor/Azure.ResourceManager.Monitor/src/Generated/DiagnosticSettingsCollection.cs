// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="DiagnosticSettingsResource" /> and their operations.
    /// Each <see cref="DiagnosticSettingsResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="DiagnosticSettingsCollection" /> instance call the GetDiagnosticSettings method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class DiagnosticSettingsCollection : ArmCollection, IEnumerable<DiagnosticSettingsResource>, IAsyncEnumerable<DiagnosticSettingsResource>
    {
        private readonly ClientDiagnostics _diagnosticSettingsDiagnosticSettingsClientDiagnostics;
        private readonly DiagnosticSettingsRestOperations _diagnosticSettingsDiagnosticSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingsCollection"/> class for mocking. </summary>
        protected DiagnosticSettingsCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingsCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiagnosticSettingsCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diagnosticSettingsDiagnosticSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", DiagnosticSettingsResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DiagnosticSettingsResource.ResourceType, out string diagnosticSettingsDiagnosticSettingsApiVersion);
            _diagnosticSettingsDiagnosticSettingsRestClient = new DiagnosticSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diagnosticSettingsDiagnosticSettingsApiVersion);
        }

        /// <summary>
        /// Creates or updates diagnostic settings for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="data"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DiagnosticSettingsResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DiagnosticSettingsData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsDiagnosticSettingsRestClient.CreateOrUpdateAsync(Id, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation<DiagnosticSettingsResource>(Response.FromValue(new DiagnosticSettingsResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates diagnostic settings for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="data"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DiagnosticSettingsResource> CreateOrUpdate(WaitUntil waitUntil, string name, DiagnosticSettingsData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsDiagnosticSettingsRestClient.CreateOrUpdate(Id, name, data, cancellationToken);
                var operation = new MonitorArmOperation<DiagnosticSettingsResource>(Response.FromValue(new DiagnosticSettingsResource(Client, response), response.GetRawResponse()));
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
        /// Gets the active diagnostic settings for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Get
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DiagnosticSettingsResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsDiagnosticSettingsRestClient.GetAsync(Id, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the active diagnostic settings for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Get
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DiagnosticSettingsResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.Get");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsDiagnosticSettingsRestClient.Get(Id, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingsResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the active diagnostic settings list for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings
        /// Operation Id: DiagnosticSettings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiagnosticSettingsResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiagnosticSettingsResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DiagnosticSettingsResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticSettingsDiagnosticSettingsRestClient.ListAsync(Id, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiagnosticSettingsResource(Client, value)), null, response.GetRawResponse());
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
        /// Gets the active diagnostic settings list for the specified resource.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings
        /// Operation Id: DiagnosticSettings_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiagnosticSettingsResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiagnosticSettingsResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DiagnosticSettingsResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticSettingsDiagnosticSettingsRestClient.List(Id, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiagnosticSettingsResource(Client, value)), null, response.GetRawResponse());
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
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Get
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.Exists");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsDiagnosticSettingsRestClient.GetAsync(Id, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}
        /// Operation Id: DiagnosticSettings_Get
        /// </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _diagnosticSettingsDiagnosticSettingsClientDiagnostics.CreateScope("DiagnosticSettingsCollection.Exists");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsDiagnosticSettingsRestClient.Get(Id, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiagnosticSettingsResource> IEnumerable<DiagnosticSettingsResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiagnosticSettingsResource> IAsyncEnumerable<DiagnosticSettingsResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
