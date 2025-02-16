// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The ListCredentialResponseProperties. </summary>
    internal partial class ListCredentialResponseProperties
    {
        /// <summary> Initializes a new instance of <see cref="ListCredentialResponseProperties"/>. </summary>
        internal ListCredentialResponseProperties()
        {
            Kubeconfigs = new ChangeTrackingList<HybridContainerServiceCredential>();
        }

        /// <summary> Initializes a new instance of <see cref="ListCredentialResponseProperties"/>. </summary>
        /// <param name="kubeconfigs"> Base64-encoded Kubernetes configuration file. </param>
        internal ListCredentialResponseProperties(IReadOnlyList<HybridContainerServiceCredential> kubeconfigs)
        {
            Kubeconfigs = kubeconfigs;
        }

        /// <summary> Base64-encoded Kubernetes configuration file. </summary>
        public IReadOnlyList<HybridContainerServiceCredential> Kubeconfigs { get; }
    }
}
