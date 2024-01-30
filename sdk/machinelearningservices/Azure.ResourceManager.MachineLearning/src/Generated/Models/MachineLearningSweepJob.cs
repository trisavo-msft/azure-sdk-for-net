// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Sweep job definition. </summary>
    public partial class MachineLearningSweepJob : MachineLearningJobProperties
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningSweepJob"/>. </summary>
        /// <param name="objective"> [Required] Optimization objective. </param>
        /// <param name="samplingAlgorithm">
        /// [Required] The hyperparameter sampling algorithm
        /// Please note <see cref="Models.SamplingAlgorithm"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BayesianSamplingAlgorithm"/>, <see cref="GridSamplingAlgorithm"/> and <see cref="RandomSamplingAlgorithm"/>.
        /// </param>
        /// <param name="searchSpace"> [Required] A dictionary containing each parameter and its distribution. The dictionary key is the name of the parameter. </param>
        /// <param name="trial"> [Required] Trial component definition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="objective"/>, <paramref name="samplingAlgorithm"/>, <paramref name="searchSpace"/> or <paramref name="trial"/> is null. </exception>
        public MachineLearningSweepJob(MachineLearningObjective objective, SamplingAlgorithm samplingAlgorithm, BinaryData searchSpace, MachineLearningTrialComponent trial)
        {
            Argument.AssertNotNull(objective, nameof(objective));
            Argument.AssertNotNull(samplingAlgorithm, nameof(samplingAlgorithm));
            Argument.AssertNotNull(searchSpace, nameof(searchSpace));
            Argument.AssertNotNull(trial, nameof(trial));

            Inputs = new ChangeTrackingDictionary<string, MachineLearningJobInput>();
            Objective = objective;
            Outputs = new ChangeTrackingDictionary<string, MachineLearningJobOutput>();
            SamplingAlgorithm = samplingAlgorithm;
            SearchSpace = searchSpace;
            Trial = trial;
            JobType = JobType.Sweep;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningSweepJob"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="componentId"> ARM resource ID of the component resource. </param>
        /// <param name="computeId"> ARM resource ID of the compute resource. </param>
        /// <param name="displayName"> Display name of job. </param>
        /// <param name="experimentName"> The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment. </param>
        /// <param name="identity">
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// Please note <see cref="MachineLearningIdentityConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmlToken"/>, <see cref="MachineLearningManagedIdentity"/> and <see cref="MachineLearningUserIdentity"/>.
        /// </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="jobType"> [Required] Specifies the type of job. </param>
        /// <param name="notificationSetting"> Notification setting for the job. </param>
        /// <param name="secretsConfiguration"> Configuration for secrets to be made available during runtime. </param>
        /// <param name="services">
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </param>
        /// <param name="status"> Status of the job. </param>
        /// <param name="earlyTermination">
        /// Early termination policies enable canceling poor-performing runs before they complete
        /// Please note <see cref="MachineLearningEarlyTerminationPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BanditPolicy"/>, <see cref="MedianStoppingPolicy"/> and <see cref="TruncationSelectionPolicy"/>.
        /// </param>
        /// <param name="inputs">
        /// Mapping of input data bindings used in the job.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </param>
        /// <param name="limits"> Sweep Job limit. </param>
        /// <param name="objective"> [Required] Optimization objective. </param>
        /// <param name="outputs">
        /// Mapping of output data bindings used in the job.
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </param>
        /// <param name="queueSettings"> Queue settings for the job. </param>
        /// <param name="samplingAlgorithm">
        /// [Required] The hyperparameter sampling algorithm
        /// Please note <see cref="Models.SamplingAlgorithm"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BayesianSamplingAlgorithm"/>, <see cref="GridSamplingAlgorithm"/> and <see cref="RandomSamplingAlgorithm"/>.
        /// </param>
        /// <param name="searchSpace"> [Required] A dictionary containing each parameter and its distribution. The dictionary key is the name of the parameter. </param>
        /// <param name="trial"> [Required] Trial component definition. </param>
        internal MachineLearningSweepJob(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier componentId, ResourceIdentifier computeId, string displayName, string experimentName, MachineLearningIdentityConfiguration identity, bool? isArchived, JobType jobType, NotificationSetting notificationSetting, IDictionary<string, SecretConfiguration> secretsConfiguration, IDictionary<string, MachineLearningJobService> services, MachineLearningJobStatus? status, MachineLearningEarlyTerminationPolicy earlyTermination, IDictionary<string, MachineLearningJobInput> inputs, MachineLearningSweepJobLimits limits, MachineLearningObjective objective, IDictionary<string, MachineLearningJobOutput> outputs, JobQueueSettings queueSettings, SamplingAlgorithm samplingAlgorithm, BinaryData searchSpace, MachineLearningTrialComponent trial) : base(description, properties, tags, serializedAdditionalRawData, componentId, computeId, displayName, experimentName, identity, isArchived, jobType, notificationSetting, secretsConfiguration, services, status)
        {
            EarlyTermination = earlyTermination;
            Inputs = inputs;
            Limits = limits;
            Objective = objective;
            Outputs = outputs;
            QueueSettings = queueSettings;
            SamplingAlgorithm = samplingAlgorithm;
            SearchSpace = searchSpace;
            Trial = trial;
            JobType = jobType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningSweepJob"/> for deserialization. </summary>
        internal MachineLearningSweepJob()
        {
        }

        /// <summary>
        /// Early termination policies enable canceling poor-performing runs before they complete
        /// Please note <see cref="MachineLearningEarlyTerminationPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BanditPolicy"/>, <see cref="MedianStoppingPolicy"/> and <see cref="TruncationSelectionPolicy"/>.
        /// </summary>
        public MachineLearningEarlyTerminationPolicy EarlyTermination { get; set; }
        /// <summary>
        /// Mapping of input data bindings used in the job.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </summary>
        public IDictionary<string, MachineLearningJobInput> Inputs { get; set; }
        /// <summary> Sweep Job limit. </summary>
        public MachineLearningSweepJobLimits Limits { get; set; }
        /// <summary> [Required] Optimization objective. </summary>
        public MachineLearningObjective Objective { get; set; }
        /// <summary>
        /// Mapping of output data bindings used in the job.
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </summary>
        public IDictionary<string, MachineLearningJobOutput> Outputs { get; set; }
        /// <summary> Queue settings for the job. </summary>
        public JobQueueSettings QueueSettings { get; set; }
        /// <summary>
        /// [Required] The hyperparameter sampling algorithm
        /// Please note <see cref="Models.SamplingAlgorithm"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BayesianSamplingAlgorithm"/>, <see cref="GridSamplingAlgorithm"/> and <see cref="RandomSamplingAlgorithm"/>.
        /// </summary>
        public SamplingAlgorithm SamplingAlgorithm { get; set; }
        /// <summary>
        /// [Required] A dictionary containing each parameter and its distribution. The dictionary key is the name of the parameter
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData SearchSpace { get; set; }
        /// <summary> [Required] Trial component definition. </summary>
        public MachineLearningTrialComponent Trial { get; set; }
    }
}
