// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster pool profile. </summary>
    internal partial class ClusterPoolProfile
    {
        /// <summary> Initializes a new instance of <see cref="ClusterPoolProfile"/>. </summary>
        /// <param name="clusterPoolVersion"> Cluster pool version is a 2-part version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolVersion"/> is null. </exception>
        public ClusterPoolProfile(string clusterPoolVersion)
        {
            Argument.AssertNotNull(clusterPoolVersion, nameof(clusterPoolVersion));

            ClusterPoolVersion = clusterPoolVersion;
        }

        /// <summary> Cluster pool version is a 2-part version. </summary>
        public string ClusterPoolVersion { get; set; }
    }
}
