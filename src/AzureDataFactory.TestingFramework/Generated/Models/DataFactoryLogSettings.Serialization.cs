// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class DataFactoryLogSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnableCopyActivityLog))
            {
                writer.WritePropertyName("enableCopyActivityLog"u8);
                JsonSerializer.Serialize(writer, EnableCopyActivityLog);
            }
            if (Optional.IsDefined(CopyActivityLogSettings))
            {
                writer.WritePropertyName("copyActivityLogSettings"u8);
                writer.WriteObjectValue(CopyActivityLogSettings);
            }
            writer.WritePropertyName("logLocationSettings"u8);
            writer.WriteObjectValue(LogLocationSettings);
            writer.WriteEndObject();
        }

        internal static DataFactoryLogSettings DeserializeDataFactoryLogSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<bool>> enableCopyActivityLog = default;
            Optional<CopyActivityLogSettings> copyActivityLogSettings = default;
            LogLocationSettings logLocationSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableCopyActivityLog"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCopyActivityLog = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("copyActivityLogSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyActivityLogSettings = CopyActivityLogSettings.DeserializeCopyActivityLogSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("logLocationSettings"u8))
                {
                    logLocationSettings = LogLocationSettings.DeserializeLogLocationSettings(property.Value);
                    continue;
                }
            }
            return new DataFactoryLogSettings(enableCopyActivityLog.Value, copyActivityLogSettings.Value, logLocationSettings);
        }
    }
}