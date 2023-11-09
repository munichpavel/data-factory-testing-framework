// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class TriggerFilterContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ContinuationToken))
            {
                writer.WritePropertyName("continuationToken"u8);
                writer.WriteStringValue(ContinuationToken);
            }
            if (Optional.IsDefined(ParentTriggerName))
            {
                writer.WritePropertyName("parentTriggerName"u8);
                writer.WriteStringValue(ParentTriggerName);
            }
            writer.WriteEndObject();
        }
    }
}