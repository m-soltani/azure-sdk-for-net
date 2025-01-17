// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class JitApprover : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(JitApproverType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(JitApproverType.Value.ToString());
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            writer.WriteEndObject();
        }

        internal static JitApprover DeserializeJitApprover(JsonElement element)
        {
            string id = default;
            Optional<JitApproverType> type = default;
            Optional<string> displayName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new JitApproverType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
            }
            return new JitApprover(id, Optional.ToNullable(type), displayName.Value);
        }
    }
}
