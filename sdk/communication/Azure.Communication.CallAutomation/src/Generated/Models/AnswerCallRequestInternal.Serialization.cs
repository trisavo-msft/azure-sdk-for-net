// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class AnswerCallRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("incomingCallContext"u8);
            writer.WriteStringValue(IncomingCallContext);
            writer.WritePropertyName("callbackUri"u8);
            writer.WriteStringValue(CallbackUri);
            if (Optional.IsDefined(CustomCallingContext))
            {
                writer.WritePropertyName("customCallingContext"u8);
                writer.WriteObjectValue(CustomCallingContext);
            }
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            if (Optional.IsDefined(CallIntelligenceOptions))
            {
                writer.WritePropertyName("callIntelligenceOptions"u8);
                writer.WriteObjectValue(CallIntelligenceOptions);
            }
            if (Optional.IsDefined(AnsweredBy))
            {
                writer.WritePropertyName("answeredBy"u8);
                writer.WriteObjectValue(AnsweredBy);
            }
            if (Optional.IsDefined(MediaStreamingOptions))
            {
                writer.WritePropertyName("mediaStreamingOptions"u8);
                writer.WriteObjectValue(MediaStreamingOptions);
            }
            if (Optional.IsDefined(TranscriptionOptions))
            {
                writer.WritePropertyName("transcriptionOptions"u8);
                writer.WriteObjectValue(TranscriptionOptions);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
