// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Migration.Assessment
{
    public partial class MigrationAssessmentSqlAssessmentOptionResource : IJsonModel<MigrationAssessmentSqlAssessmentOptionData>
    {
        void IJsonModel<MigrationAssessmentSqlAssessmentOptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MigrationAssessmentSqlAssessmentOptionData>)Data).Write(writer, options);

        MigrationAssessmentSqlAssessmentOptionData IJsonModel<MigrationAssessmentSqlAssessmentOptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MigrationAssessmentSqlAssessmentOptionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MigrationAssessmentSqlAssessmentOptionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        MigrationAssessmentSqlAssessmentOptionData IPersistableModel<MigrationAssessmentSqlAssessmentOptionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MigrationAssessmentSqlAssessmentOptionData>(data, options);

        string IPersistableModel<MigrationAssessmentSqlAssessmentOptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MigrationAssessmentSqlAssessmentOptionData>)Data).GetFormatFromOptions(options);
    }
}
