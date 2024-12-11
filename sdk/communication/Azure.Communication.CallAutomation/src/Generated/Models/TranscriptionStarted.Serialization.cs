// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    public partial class TranscriptionStarted
    {
        internal static TranscriptionStarted DeserializeTranscriptionStarted(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TranscriptionUpdate transcriptionUpdate = default;
            string callConnectionId = default;
            string serverCallId = default;
            string correlationId = default;
            string operationContext = default;
            ResultInformation resultInformation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transcriptionUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transcriptionUpdate = TranscriptionUpdate.DeserializeTranscriptionUpdate(property.Value);
                    continue;
                }
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultInformation = ResultInformation.DeserializeResultInformation(property.Value);
                    continue;
                }
            }
            return new TranscriptionStarted(
                transcriptionUpdate,
                callConnectionId,
                serverCallId,
                correlationId,
                operationContext,
                resultInformation);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TranscriptionStarted FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTranscriptionStarted(document.RootElement);
        }
    }
}
