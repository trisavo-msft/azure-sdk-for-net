// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Migration.Assessment
{
    public partial class AssessedSqlInstanceV2Resource : IJsonModel<AssessedSqlInstanceV2Data>
    {
        void IJsonModel<AssessedSqlInstanceV2Data>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AssessedSqlInstanceV2Data>)Data).Write(writer, options);

        AssessedSqlInstanceV2Data IJsonModel<AssessedSqlInstanceV2Data>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AssessedSqlInstanceV2Data>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AssessedSqlInstanceV2Data>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        AssessedSqlInstanceV2Data IPersistableModel<AssessedSqlInstanceV2Data>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AssessedSqlInstanceV2Data>(data, options);

        string IPersistableModel<AssessedSqlInstanceV2Data>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AssessedSqlInstanceV2Data>)Data).GetFormatFromOptions(options);
    }
}
