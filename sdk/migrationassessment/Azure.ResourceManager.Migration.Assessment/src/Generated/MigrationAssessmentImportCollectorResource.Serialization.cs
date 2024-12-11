// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Migration.Assessment
{
    public partial class MigrationAssessmentImportCollectorResource : IJsonModel<MigrationAssessmentImportCollectorData>
    {
        void IJsonModel<MigrationAssessmentImportCollectorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MigrationAssessmentImportCollectorData>)Data).Write(writer, options);

        MigrationAssessmentImportCollectorData IJsonModel<MigrationAssessmentImportCollectorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MigrationAssessmentImportCollectorData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MigrationAssessmentImportCollectorData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        MigrationAssessmentImportCollectorData IPersistableModel<MigrationAssessmentImportCollectorData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MigrationAssessmentImportCollectorData>(data, options);

        string IPersistableModel<MigrationAssessmentImportCollectorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MigrationAssessmentImportCollectorData>)Data).GetFormatFromOptions(options);
    }
}
