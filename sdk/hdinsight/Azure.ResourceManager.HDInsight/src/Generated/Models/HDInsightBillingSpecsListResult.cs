// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The response for the operation to get regional billingSpecs for a subscription. </summary>
    public partial class HDInsightBillingSpecsListResult
    {
        /// <summary> Initializes a new instance of <see cref="HDInsightBillingSpecsListResult"/>. </summary>
        internal HDInsightBillingSpecsListResult()
        {
            VmSizes = new ChangeTrackingList<string>();
            VmSizesWithEncryptionAtHost = new ChangeTrackingList<string>();
            VmSizeFilters = new ChangeTrackingList<HDInsightVmSizeCompatibilityFilterV2>();
            VmSizeProperties = new ChangeTrackingList<HDInsightVmSizeProperty>();
            BillingResources = new ChangeTrackingList<HDInsightBillingResources>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightBillingSpecsListResult"/>. </summary>
        /// <param name="vmSizes"> The virtual machine sizes to include or exclude. </param>
        /// <param name="vmSizesWithEncryptionAtHost"> The vm sizes which enable encryption at host. </param>
        /// <param name="vmSizeFilters"> The virtual machine filtering mode. Effectively this can enabling or disabling the virtual machine sizes in a particular set. </param>
        /// <param name="vmSizeProperties"> The vm size properties. </param>
        /// <param name="billingResources"> The billing and managed disk billing resources for a region. </param>
        internal HDInsightBillingSpecsListResult(IReadOnlyList<string> vmSizes, IReadOnlyList<string> vmSizesWithEncryptionAtHost, IReadOnlyList<HDInsightVmSizeCompatibilityFilterV2> vmSizeFilters, IReadOnlyList<HDInsightVmSizeProperty> vmSizeProperties, IReadOnlyList<HDInsightBillingResources> billingResources)
        {
            VmSizes = vmSizes;
            VmSizesWithEncryptionAtHost = vmSizesWithEncryptionAtHost;
            VmSizeFilters = vmSizeFilters;
            VmSizeProperties = vmSizeProperties;
            BillingResources = billingResources;
        }

        /// <summary> The virtual machine sizes to include or exclude. </summary>
        public IReadOnlyList<string> VmSizes { get; }
        /// <summary> The vm sizes which enable encryption at host. </summary>
        public IReadOnlyList<string> VmSizesWithEncryptionAtHost { get; }
        /// <summary> The virtual machine filtering mode. Effectively this can enabling or disabling the virtual machine sizes in a particular set. </summary>
        public IReadOnlyList<HDInsightVmSizeCompatibilityFilterV2> VmSizeFilters { get; }
        /// <summary> The vm size properties. </summary>
        public IReadOnlyList<HDInsightVmSizeProperty> VmSizeProperties { get; }
        /// <summary> The billing and managed disk billing resources for a region. </summary>
        public IReadOnlyList<HDInsightBillingResources> BillingResources { get; }
    }
}
