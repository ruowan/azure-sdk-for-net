// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListAuthorizations API service call retrieves all authorizations that belongs to an ExpressRouteCircuit. </summary>
    internal partial class AuthorizationListResult
    {
        /// <summary> Initializes a new instance of <see cref="AuthorizationListResult"/>. </summary>
        internal AuthorizationListResult()
        {
            Value = new ChangeTrackingList<ExpressRouteCircuitAuthorizationData>();
        }

        /// <summary> Initializes a new instance of <see cref="AuthorizationListResult"/>. </summary>
        /// <param name="value"> The authorizations in an ExpressRoute Circuit. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal AuthorizationListResult(IReadOnlyList<ExpressRouteCircuitAuthorizationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The authorizations in an ExpressRoute Circuit. </summary>
        public IReadOnlyList<ExpressRouteCircuitAuthorizationData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
