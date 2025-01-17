// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetwork;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    /// <summary> Result of the request to list Managed Network Peering Policies. It contains a list of policies and a URL link to get the next set of results. </summary>
    internal partial class ManagedNetworkPeeringPolicyListResult
    {
        /// <summary> Initializes a new instance of ManagedNetworkPeeringPolicyListResult. </summary>
        internal ManagedNetworkPeeringPolicyListResult()
        {
            Value = new ChangeTrackingList<ManagedNetworkPeeringPolicyData>();
        }

        /// <summary> Initializes a new instance of ManagedNetworkPeeringPolicyListResult. </summary>
        /// <param name="value"> Gets a page of Peering Policies. </param>
        /// <param name="nextLink"> Gets the URL to get the next page of results. </param>
        internal ManagedNetworkPeeringPolicyListResult(IReadOnlyList<ManagedNetworkPeeringPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets a page of Peering Policies. </summary>
        public IReadOnlyList<ManagedNetworkPeeringPolicyData> Value { get; }
        /// <summary> Gets the URL to get the next page of results. </summary>
        public string NextLink { get; }
    }
}
