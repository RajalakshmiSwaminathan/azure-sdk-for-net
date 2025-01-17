// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AnalysisServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AnalysisServices
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.AnalysisServices. </summary>
    public static partial class AnalysisServicesExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Lists all the Analysis Services servers for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/servers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AnalysisServicesServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AnalysisServicesServerResource> GetAnalysisServicesServersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAnalysisServicesServersAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the Analysis Services servers for the given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/servers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AnalysisServicesServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AnalysisServicesServerResource> GetAnalysisServicesServers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAnalysisServicesServers(cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for Analysis Services resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/skus
        /// Operation Id: Servers_ListSkusForNew
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceSku" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceSku> GetSkusForNewServersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSkusForNewServersAsync(cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for Analysis Services resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/skus
        /// Operation Id: Servers_ListSkusForNew
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceSku" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceSku> GetSkusForNewServers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSkusForNewServers(cancellationToken);
        }

        /// <summary>
        /// Check the name availability in the target location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/locations/{location}/checkNameAvailability
        /// Operation Id: Servers_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="content"> Contains the information used to provision the Analysis Services server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<CheckServerNameAvailabilityResult>> CheckNameAvailabilityServerAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CheckServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckNameAvailabilityServerAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the name availability in the target location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/locations/{location}/checkNameAvailability
        /// Operation Id: Servers_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="content"> Contains the information used to provision the Analysis Services server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<CheckServerNameAvailabilityResult> CheckNameAvailabilityServer(this SubscriptionResource subscriptionResource, AzureLocation location, CheckServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckNameAvailabilityServer(location, content, cancellationToken);
        }

        /// <summary>
        /// List the result of the specified operation.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/locations/{location}/operationresults/{operationId}
        /// Operation Id: Servers_ListOperationResults
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="operationId"> The target operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static async Task<Response> GetOperationResultsServerAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return await GetExtensionClient(subscriptionResource).GetOperationResultsServerAsync(location, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// List the result of the specified operation.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/locations/{location}/operationresults/{operationId}
        /// Operation Id: Servers_ListOperationResults
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="operationId"> The target operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static Response GetOperationResultsServer(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(subscriptionResource).GetOperationResultsServer(location, operationId, cancellationToken);
        }

        /// <summary>
        /// List the status of operation.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/locations/{location}/operationstatuses/{operationId}
        /// Operation Id: Servers_ListOperationStatuses
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="operationId"> The target operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static async Task<Response<OperationStatus>> GetOperationStatusesServerAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return await GetExtensionClient(subscriptionResource).GetOperationStatusesServerAsync(location, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// List the status of operation.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AnalysisServices/locations/{location}/operationstatuses/{operationId}
        /// Operation Id: Servers_ListOperationStatuses
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The region name which the operation will lookup into. </param>
        /// <param name="operationId"> The target operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static Response<OperationStatus> GetOperationStatusesServer(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(subscriptionResource).GetOperationStatusesServer(location, operationId, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of AnalysisServicesServerResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AnalysisServicesServerResources and their operations over a AnalysisServicesServerResource. </returns>
        public static AnalysisServicesServerCollection GetAnalysisServicesServers(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetAnalysisServicesServers();
        }

        /// <summary>
        /// Gets details about the specified Analysis Services server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AnalysisServices/servers/{serverName}
        /// Operation Id: Servers_GetDetails
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the Analysis Services server. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AnalysisServicesServerResource>> GetAnalysisServicesServerAsync(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetAnalysisServicesServers().GetAsync(serverName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets details about the specified Analysis Services server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AnalysisServices/servers/{serverName}
        /// Operation Id: Servers_GetDetails
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the Analysis Services server. It must be a minimum of 3 characters, and a maximum of 63. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<AnalysisServicesServerResource> GetAnalysisServicesServer(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetAnalysisServicesServers().Get(serverName, cancellationToken);
        }

        #region AnalysisServicesServerResource
        /// <summary>
        /// Gets an object representing an <see cref="AnalysisServicesServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AnalysisServicesServerResource.CreateResourceIdentifier" /> to create an <see cref="AnalysisServicesServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AnalysisServicesServerResource" /> object. </returns>
        public static AnalysisServicesServerResource GetAnalysisServicesServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AnalysisServicesServerResource.ValidateResourceId(id);
                return new AnalysisServicesServerResource(client, id);
            }
            );
        }
        #endregion
    }
}
