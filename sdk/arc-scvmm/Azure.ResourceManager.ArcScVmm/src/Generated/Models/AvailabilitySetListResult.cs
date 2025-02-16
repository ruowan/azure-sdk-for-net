// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> List of AvailabilitySets. </summary>
    internal partial class AvailabilitySetListResult
    {
        /// <summary> Initializes a new instance of <see cref="AvailabilitySetListResult"/>. </summary>
        internal AvailabilitySetListResult()
        {
            Value = new ChangeTrackingList<ScVmmAvailabilitySetData>();
        }

        /// <summary> Initializes a new instance of <see cref="AvailabilitySetListResult"/>. </summary>
        /// <param name="value"> List of AvailabilitySets. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal AvailabilitySetListResult(IReadOnlyList<ScVmmAvailabilitySetData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of AvailabilitySets. </summary>
        public IReadOnlyList<ScVmmAvailabilitySetData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
