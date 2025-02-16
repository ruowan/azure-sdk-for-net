// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The azure storage account container credential definition. </summary>
    public partial class AzureStorageAccountContainerCredential
    {
        /// <summary> Initializes a new instance of <see cref="AzureStorageAccountContainerCredential"/>. </summary>
        internal AzureStorageAccountContainerCredential()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureStorageAccountContainerCredential"/>. </summary>
        /// <param name="containerName"> The storage account container name. </param>
        /// <param name="containerSasUri"> The storage account container sas uri. </param>
        internal AzureStorageAccountContainerCredential(string containerName, Uri containerSasUri)
        {
            ContainerName = containerName;
            ContainerSasUri = containerSasUri;
        }

        /// <summary> The storage account container name. </summary>
        public string ContainerName { get; }
        /// <summary> The storage account container sas uri. </summary>
        public Uri ContainerSasUri { get; }
    }
}
