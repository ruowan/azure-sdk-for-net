// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> The build stage (init-container and container) resources in build pod. </summary>
    public partial class AppPlatformBuildStageProperties
    {
        /// <summary> Initializes a new instance of <see cref="AppPlatformBuildStageProperties"/>. </summary>
        internal AppPlatformBuildStageProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuildStageProperties"/>. </summary>
        /// <param name="name"> The name of this build stage resource. </param>
        /// <param name="status"> The provisioning state of this build stage resource. </param>
        internal AppPlatformBuildStageProperties(string name, KPackBuildStageProvisioningState? status)
        {
            Name = name;
            Status = status;
        }

        /// <summary> The name of this build stage resource. </summary>
        public string Name { get; }
        /// <summary> The provisioning state of this build stage resource. </summary>
        public KPackBuildStageProvisioningState? Status { get; }
    }
}
