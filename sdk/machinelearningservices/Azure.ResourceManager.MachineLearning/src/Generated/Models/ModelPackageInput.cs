// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Model package input options. </summary>
    public partial class ModelPackageInput
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ModelPackageInput"/>. </summary>
        /// <param name="inputType"> [Required] Type of the input included in the target image. </param>
        /// <param name="path">
        /// [Required] Location of the input.
        /// Please note <see cref="PackageInputPathBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="PackageInputPathId"/>, <see cref="PackageInputPathVersion"/> and <see cref="PackageInputPathUri"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> is null. </exception>
        public ModelPackageInput(PackageInputType inputType, PackageInputPathBase path)
        {
            Argument.AssertNotNull(path, nameof(path));

            InputType = inputType;
            Path = path;
        }

        /// <summary> Initializes a new instance of <see cref="ModelPackageInput"/>. </summary>
        /// <param name="inputType"> [Required] Type of the input included in the target image. </param>
        /// <param name="mode"> Input delivery mode of the input. </param>
        /// <param name="mountPath"> Relative mount path of the input in the target image. </param>
        /// <param name="path">
        /// [Required] Location of the input.
        /// Please note <see cref="PackageInputPathBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="PackageInputPathId"/>, <see cref="PackageInputPathVersion"/> and <see cref="PackageInputPathUri"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ModelPackageInput(PackageInputType inputType, PackageInputDeliveryMode? mode, string mountPath, PackageInputPathBase path, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InputType = inputType;
            Mode = mode;
            MountPath = mountPath;
            Path = path;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ModelPackageInput"/> for deserialization. </summary>
        internal ModelPackageInput()
        {
        }

        /// <summary> [Required] Type of the input included in the target image. </summary>
        public PackageInputType InputType { get; set; }
        /// <summary> Input delivery mode of the input. </summary>
        public PackageInputDeliveryMode? Mode { get; set; }
        /// <summary> Relative mount path of the input in the target image. </summary>
        public string MountPath { get; set; }
        /// <summary>
        /// [Required] Location of the input.
        /// Please note <see cref="PackageInputPathBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="PackageInputPathId"/>, <see cref="PackageInputPathVersion"/> and <see cref="PackageInputPathUri"/>.
        /// </summary>
        public PackageInputPathBase Path { get; set; }
    }
}
