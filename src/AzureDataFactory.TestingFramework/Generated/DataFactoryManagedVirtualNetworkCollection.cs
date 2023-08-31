// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections;
using System.Globalization;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing a collection of <see cref="DataFactoryManagedVirtualNetworkResource" /> and their operations.
    /// Each <see cref="DataFactoryManagedVirtualNetworkResource" /> in the collection will belong to the same instance of <see cref="DataFactoryResource" />.
    /// To get a <see cref="DataFactoryManagedVirtualNetworkCollection" /> instance call the GetDataFactoryManagedVirtualNetworks method from an instance of <see cref="DataFactoryResource" />.
    /// </summary>
    public partial class DataFactoryManagedVirtualNetworkCollection : ArmCollection, IEnumerable<DataFactoryManagedVirtualNetworkResource>, IAsyncEnumerable<DataFactoryManagedVirtualNetworkResource>
    {
        private readonly ClientDiagnostics _dataFactoryManagedVirtualNetworkManagedVirtualNetworksClientDiagnostics;
        private readonly ManagedVirtualNetworksRestOperations _dataFactoryManagedVirtualNetworkManagedVirtualNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataFactoryManagedVirtualNetworkCollection"/> class for mocking. </summary>
        protected DataFactoryManagedVirtualNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataFactoryManagedVirtualNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataFactoryManagedVirtualNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataFactoryManagedVirtualNetworkManagedVirtualNetworksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", DataFactoryManagedVirtualNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataFactoryManagedVirtualNetworkResource.ResourceType, out string dataFactoryManagedVirtualNetworkManagedVirtualNetworksApiVersion);
            _dataFactoryManagedVirtualNetworkManagedVirtualNetworksRestClient = new ManagedVirtualNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataFactoryManagedVirtualNetworkManagedVirtualNetworksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataFactoryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataFactoryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a managed Virtual Network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedVirtualNetworks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="data"> Managed Virtual Network resource definition. </param>
        /// <param name="ifMatch"> ETag of the managed Virtual Network entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedVirtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataFactoryManagedVirtualNetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string managedVirtualNetworkName, DataFactoryManagedVirtualNetworkData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedVirtualNetworkName, nameof(managedVirtualNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryManagedVirtualNetworkManagedVirtualNetworksClientDiagnostics.CreateScope("DataFactoryManagedVirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataFactoryManagedVirtualNetworkManagedVirtualNetworksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedVirtualNetworkName, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation<DataFactoryManagedVirtualNetworkResource>(Response.FromValue(new DataFactoryManagedVirtualNetworkResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a managed Virtual Network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedVirtualNetworks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="data"> Managed Virtual Network resource definition. </param>
        /// <param name="ifMatch"> ETag of the managed Virtual Network entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedVirtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataFactoryManagedVirtualNetworkResource> CreateOrUpdate(WaitUntil waitUntil, string managedVirtualNetworkName, DataFactoryManagedVirtualNetworkData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedVirtualNetworkName, nameof(managedVirtualNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryManagedVirtualNetworkManagedVirtualNetworksClientDiagnostics.CreateScope("DataFactoryManagedVirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataFactoryManagedVirtualNetworkManagedVirtualNetworksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedVirtualNetworkName, data, ifMatch, cancellationToken);
                var operation = new DataFactoryArmOperation<DataFactoryManagedVirtualNetworkResource>(Response.FromValue(new DataFactoryManagedVirtualNetworkResource(Client, response), response.GetRawResponse()));
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
        /// Gets a managed Virtual Network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedVirtualNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="ifNoneMatch"> ETag of the managed Virtual Network entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedVirtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public virtual async Task<Response<DataFactoryManagedVirtualNetworkResource>> GetAsync(string managedVirtualNetworkName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedVirtualNetworkName, nameof(managedVirtualNetworkName));

            using var scope = _dataFactoryManagedVirtualNetworkManagedVirtualNetworksClientDiagnostics.CreateScope("DataFactoryManagedVirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataFactoryManagedVirtualNetworkManagedVirtualNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedVirtualNetworkName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryManagedVirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed Virtual Network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedVirtualNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="ifNoneMatch"> ETag of the managed Virtual Network entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedVirtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public virtual Response<DataFactoryManagedVirtualNetworkResource> Get(string managedVirtualNetworkName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedVirtualNetworkName, nameof(managedVirtualNetworkName));

            using var scope = _dataFactoryManagedVirtualNetworkManagedVirtualNetworksClientDiagnostics.CreateScope("DataFactoryManagedVirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _dataFactoryManagedVirtualNetworkManagedVirtualNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedVirtualNetworkName, ifNoneMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryManagedVirtualNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists managed Virtual Networks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedVirtualNetworks_ListByFactory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataFactoryManagedVirtualNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataFactoryManagedVirtualNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryManagedVirtualNetworkManagedVirtualNetworksRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryManagedVirtualNetworkManagedVirtualNetworksRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataFactoryManagedVirtualNetworkResource(Client, DataFactoryManagedVirtualNetworkData.DeserializeDataFactoryManagedVirtualNetworkData(e)), _dataFactoryManagedVirtualNetworkManagedVirtualNetworksClientDiagnostics, Pipeline, "DataFactoryManagedVirtualNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists managed Virtual Networks.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedVirtualNetworks_ListByFactory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataFactoryManagedVirtualNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataFactoryManagedVirtualNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryManagedVirtualNetworkManagedVirtualNetworksRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryManagedVirtualNetworkManagedVirtualNetworksRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataFactoryManagedVirtualNetworkResource(Client, DataFactoryManagedVirtualNetworkData.DeserializeDataFactoryManagedVirtualNetworkData(e)), _dataFactoryManagedVirtualNetworkManagedVirtualNetworksClientDiagnostics, Pipeline, "DataFactoryManagedVirtualNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedVirtualNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="ifNoneMatch"> ETag of the managed Virtual Network entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedVirtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string managedVirtualNetworkName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedVirtualNetworkName, nameof(managedVirtualNetworkName));

            using var scope = _dataFactoryManagedVirtualNetworkManagedVirtualNetworksClientDiagnostics.CreateScope("DataFactoryManagedVirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataFactoryManagedVirtualNetworkManagedVirtualNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedVirtualNetworkName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/managedVirtualNetworks/{managedVirtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedVirtualNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="managedVirtualNetworkName"> Managed virtual network name. </param>
        /// <param name="ifNoneMatch"> ETag of the managed Virtual Network entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="managedVirtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="managedVirtualNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string managedVirtualNetworkName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(managedVirtualNetworkName, nameof(managedVirtualNetworkName));

            using var scope = _dataFactoryManagedVirtualNetworkManagedVirtualNetworksClientDiagnostics.CreateScope("DataFactoryManagedVirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataFactoryManagedVirtualNetworkManagedVirtualNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managedVirtualNetworkName, ifNoneMatch, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataFactoryManagedVirtualNetworkResource> IEnumerable<DataFactoryManagedVirtualNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataFactoryManagedVirtualNetworkResource> IAsyncEnumerable<DataFactoryManagedVirtualNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}