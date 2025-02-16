// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Raw failure information if DNS verification fails. </summary>
    public partial class ContainerAppCustomDomainVerificationFailureInfo
    {
        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomDomainVerificationFailureInfo"/>. </summary>
        internal ContainerAppCustomDomainVerificationFailureInfo()
        {
            Details = new ChangeTrackingList<ContainerAppCustomDomainVerificationFailureInfoDetailsItem>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomDomainVerificationFailureInfo"/>. </summary>
        /// <param name="code"> Standardized string to programmatically identify the error. </param>
        /// <param name="message"> Detailed error description and debugging information. </param>
        /// <param name="target"> Detailed error description and debugging information. </param>
        /// <param name="details"> Details or the error. </param>
        internal ContainerAppCustomDomainVerificationFailureInfo(string code, string message, string target, IReadOnlyList<ContainerAppCustomDomainVerificationFailureInfoDetailsItem> details)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
        }

        /// <summary> Standardized string to programmatically identify the error. </summary>
        public string Code { get; }
        /// <summary> Detailed error description and debugging information. </summary>
        public string Message { get; }
        /// <summary> Detailed error description and debugging information. </summary>
        public string Target { get; }
        /// <summary> Details or the error. </summary>
        public IReadOnlyList<ContainerAppCustomDomainVerificationFailureInfoDetailsItem> Details { get; }
    }
}
