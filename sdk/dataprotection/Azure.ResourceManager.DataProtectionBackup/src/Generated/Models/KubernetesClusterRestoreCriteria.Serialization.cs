// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class KubernetesClusterRestoreCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("includeClusterScopeResources"u8);
            writer.WriteBooleanValue(IsClusterScopeResourcesIncluded);
            if (Optional.IsCollectionDefined(IncludedNamespaces))
            {
                writer.WritePropertyName("includedNamespaces"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedNamespaces)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludedNamespaces))
            {
                writer.WritePropertyName("excludedNamespaces"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedNamespaces)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IncludedResourceTypes))
            {
                writer.WritePropertyName("includedResourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludedResourceTypes))
            {
                writer.WritePropertyName("excludedResourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedResourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LabelSelectors))
            {
                writer.WritePropertyName("labelSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in LabelSelectors)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PersistentVolumeRestoreMode))
            {
                writer.WritePropertyName("persistentVolumeRestoreMode"u8);
                writer.WriteStringValue(PersistentVolumeRestoreMode.Value.ToString());
            }
            if (Optional.IsDefined(ConflictPolicy))
            {
                writer.WritePropertyName("conflictPolicy"u8);
                writer.WriteStringValue(ConflictPolicy.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NamespaceMappings))
            {
                writer.WritePropertyName("namespaceMappings"u8);
                writer.WriteStartObject();
                foreach (var item in NamespaceMappings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(RestoreHookReferences))
            {
                writer.WritePropertyName("restoreHookReferences"u8);
                writer.WriteStartArray();
                foreach (var item in RestoreHookReferences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }
    }
}
