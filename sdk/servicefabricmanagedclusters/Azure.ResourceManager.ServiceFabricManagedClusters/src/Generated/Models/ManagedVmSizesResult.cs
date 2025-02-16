// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes the result of the request to list Managed VM Sizes for Service Fabric Managed Clusters. </summary>
    internal partial class ManagedVmSizesResult
    {
        /// <summary> Initializes a new instance of <see cref="ManagedVmSizesResult"/>. </summary>
        internal ManagedVmSizesResult()
        {
            Value = new ChangeTrackingList<ServiceFabricManagedUnsupportedVmSize>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedVmSizesResult"/>. </summary>
        /// <param name="value"> List of Managed VM Sizes for Service Fabric Managed Clusters. </param>
        /// <param name="nextLink"> URL to get the next set of Managed VM Sizes if there are any. </param>
        internal ManagedVmSizesResult(IReadOnlyList<ServiceFabricManagedUnsupportedVmSize> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Managed VM Sizes for Service Fabric Managed Clusters. </summary>
        public IReadOnlyList<ServiceFabricManagedUnsupportedVmSize> Value { get; }
        /// <summary> URL to get the next set of Managed VM Sizes if there are any. </summary>
        public string NextLink { get; }
    }
}
