// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The UpdateTranscriptionRequest. </summary>
    internal partial class UpdateTranscriptionRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="UpdateTranscriptionRequestInternal"/>. </summary>
        /// <param name="locale"> Defines new locale for transcription. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locale"/> is null. </exception>
        public UpdateTranscriptionRequestInternal(string locale)
        {
            Argument.AssertNotNull(locale, nameof(locale));

            Locale = locale;
        }

        /// <summary> Initializes a new instance of <see cref="UpdateTranscriptionRequestInternal"/>. </summary>
        /// <param name="locale"> Defines new locale for transcription. </param>
        /// <param name="speechRecognitionModelEndpointId"> Sets Endpoint id where the custom model was deployed. </param>
        /// <param name="operationContext"> The value to identify context of the operation. </param>
        /// <param name="operationCallbackUri">
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </param>
        internal UpdateTranscriptionRequestInternal(string locale, string speechRecognitionModelEndpointId, string operationContext, string operationCallbackUri)
        {
            Locale = locale;
            SpeechRecognitionModelEndpointId = speechRecognitionModelEndpointId;
            OperationContext = operationContext;
            OperationCallbackUri = operationCallbackUri;
        }

        /// <summary> Defines new locale for transcription. </summary>
        public string Locale { get; }
        /// <summary> Sets Endpoint id where the custom model was deployed. </summary>
        public string SpeechRecognitionModelEndpointId { get; set; }
        /// <summary> The value to identify context of the operation. </summary>
        public string OperationContext { get; set; }
        /// <summary>
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </summary>
        public string OperationCallbackUri { get; set; }
    }
}
