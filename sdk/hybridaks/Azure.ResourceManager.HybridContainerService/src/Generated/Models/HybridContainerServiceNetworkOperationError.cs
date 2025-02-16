// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The HybridContainerServiceNetworkOperationError. </summary>
    public partial class HybridContainerServiceNetworkOperationError
    {
        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceNetworkOperationError"/>. </summary>
        internal HybridContainerServiceNetworkOperationError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceNetworkOperationError"/>. </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        internal HybridContainerServiceNetworkOperationError(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary> Gets the message. </summary>
        public string Message { get; }
    }
}
