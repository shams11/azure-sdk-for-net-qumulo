// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningDiagnoseResult
    {
        internal static MachineLearningDiagnoseResult DeserializeMachineLearningDiagnoseResult(JsonElement element)
        {
            Optional<string> code = default;
            Optional<MachineLearningDiagnoseResultLevel> level = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    level = new MachineLearningDiagnoseResultLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new MachineLearningDiagnoseResult(code.Value, Optional.ToNullable(level), message.Value);
        }
    }
}
