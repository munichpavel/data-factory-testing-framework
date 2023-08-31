// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    internal partial class SsisObjectMetadataListResult
    {
        internal static SsisObjectMetadataListResult DeserializeSsisObjectMetadataListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SsisObjectMetadata>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SsisObjectMetadata> array = new List<SsisObjectMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SsisObjectMetadata.DeserializeSsisObjectMetadata(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SsisObjectMetadataListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}