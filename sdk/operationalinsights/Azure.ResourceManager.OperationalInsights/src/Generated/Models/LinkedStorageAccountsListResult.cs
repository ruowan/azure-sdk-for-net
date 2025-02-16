// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The list linked storage accounts service operation response. </summary>
    internal partial class LinkedStorageAccountsListResult
    {
        /// <summary> Initializes a new instance of <see cref="LinkedStorageAccountsListResult"/>. </summary>
        internal LinkedStorageAccountsListResult()
        {
            Value = new ChangeTrackingList<OperationalInsightsLinkedStorageAccountsData>();
        }

        /// <summary> Initializes a new instance of <see cref="LinkedStorageAccountsListResult"/>. </summary>
        /// <param name="value"> A list of linked storage accounts instances. </param>
        internal LinkedStorageAccountsListResult(IReadOnlyList<OperationalInsightsLinkedStorageAccountsData> value)
        {
            Value = value;
        }

        /// <summary> A list of linked storage accounts instances. </summary>
        public IReadOnlyList<OperationalInsightsLinkedStorageAccountsData> Value { get; }
    }
}
