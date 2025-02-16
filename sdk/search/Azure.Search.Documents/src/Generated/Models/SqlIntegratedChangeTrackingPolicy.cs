// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines a data change detection policy that captures changes using the Integrated Change Tracking feature of Azure SQL Database. </summary>
    public partial class SqlIntegratedChangeTrackingPolicy : DataChangeDetectionPolicy
    {
        /// <summary> Initializes a new instance of <see cref="SqlIntegratedChangeTrackingPolicy"/>. </summary>
        public SqlIntegratedChangeTrackingPolicy()
        {
            ODataType = "#Microsoft.Azure.Search.SqlIntegratedChangeTrackingPolicy";
        }

        /// <summary> Initializes a new instance of <see cref="SqlIntegratedChangeTrackingPolicy"/>. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the data change detection policy. </param>
        internal SqlIntegratedChangeTrackingPolicy(string oDataType) : base(oDataType)
        {
            ODataType = oDataType ?? "#Microsoft.Azure.Search.SqlIntegratedChangeTrackingPolicy";
        }
    }
}
