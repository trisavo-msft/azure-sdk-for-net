// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload for creating the call. </summary>
    internal partial class CreateCallRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="CreateCallRequestInternal"/>. </summary>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targets"/> or <paramref name="callbackUri"/> is null. </exception>
        public CreateCallRequestInternal(IEnumerable<CommunicationIdentifierModel> targets, string callbackUri)
        {
            Argument.AssertNotNull(targets, nameof(targets));
            Argument.AssertNotNull(callbackUri, nameof(callbackUri));

            Targets = targets.ToList();
            CallbackUri = callbackUri;
        }

        /// <summary> Initializes a new instance of <see cref="CreateCallRequestInternal"/>. </summary>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="sourceCallerIdNumber">
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Required only when calling a PSTN callee.
        /// </param>
        /// <param name="sourceDisplayName"> Display name of the call if dialing out to a pstn number. </param>
        /// <param name="source"> The identifier of the source of the call. </param>
        /// <param name="operationContext"> A customer set value used to track the answering of a call. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <param name="callIntelligenceOptions"> AI options for the call. </param>
        /// <param name="opsSource"> The identifier of the source in an OPS call. </param>
        /// <param name="customCallingContext"> Used by customer to send custom calling context to targets. </param>
        /// <param name="mediaStreamingOptions"> Media Streaming Options. </param>
        /// <param name="transcriptionOptions"> Transcription Options. </param>
        internal CreateCallRequestInternal(IList<CommunicationIdentifierModel> targets, PhoneNumberIdentifierModel sourceCallerIdNumber, string sourceDisplayName, CommunicationUserIdentifierModel source, string operationContext, string callbackUri, CallIntelligenceOptionsInternal callIntelligenceOptions, MicrosoftTeamsAppIdentifierModel opsSource, CustomCallingContextInternal customCallingContext, MediaStreamingOptionsInternal mediaStreamingOptions, TranscriptionOptionsInternal transcriptionOptions)
        {
            Targets = targets;
            SourceCallerIdNumber = sourceCallerIdNumber;
            SourceDisplayName = sourceDisplayName;
            Source = source;
            OperationContext = operationContext;
            CallbackUri = callbackUri;
            CallIntelligenceOptions = callIntelligenceOptions;
            OpsSource = opsSource;
            CustomCallingContext = customCallingContext;
            MediaStreamingOptions = mediaStreamingOptions;
            TranscriptionOptions = transcriptionOptions;
        }

        /// <summary> The targets of the call. </summary>
        public IList<CommunicationIdentifierModel> Targets { get; }
        /// <summary>
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Required only when calling a PSTN callee.
        /// </summary>
        public PhoneNumberIdentifierModel SourceCallerIdNumber { get; set; }
        /// <summary> Display name of the call if dialing out to a pstn number. </summary>
        public string SourceDisplayName { get; set; }
        /// <summary> The identifier of the source of the call. </summary>
        public CommunicationUserIdentifierModel Source { get; set; }
        /// <summary> A customer set value used to track the answering of a call. </summary>
        public string OperationContext { get; set; }
        /// <summary> The callback URI. </summary>
        public string CallbackUri { get; }
        /// <summary> AI options for the call. </summary>
        public CallIntelligenceOptionsInternal CallIntelligenceOptions { get; set; }
        /// <summary> The identifier of the source in an OPS call. </summary>
        public MicrosoftTeamsAppIdentifierModel OpsSource { get; set; }
        /// <summary> Used by customer to send custom calling context to targets. </summary>
        public CustomCallingContextInternal CustomCallingContext { get; set; }
        /// <summary> Media Streaming Options. </summary>
        public MediaStreamingOptionsInternal MediaStreamingOptions { get; set; }
        /// <summary> Transcription Options. </summary>
        public TranscriptionOptionsInternal TranscriptionOptions { get; set; }
    }
}
