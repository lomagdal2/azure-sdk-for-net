// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorScaleCapacity : IUtf8JsonSerializable, IJsonModel<MonitorScaleCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorScaleCapacity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MonitorScaleCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorScaleCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorScaleCapacity)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("minimum"u8);
            WriteMinimum(writer);
            writer.WritePropertyName("maximum"u8);
            WriteMaximum(writer);
            writer.WritePropertyName("default"u8);
            WriteDefault(writer);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MonitorScaleCapacity IJsonModel<MonitorScaleCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorScaleCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorScaleCapacity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorScaleCapacity(document.RootElement, options);
        }

        internal static MonitorScaleCapacity DeserializeMonitorScaleCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int minimum = default;
            int maximum = default;
            int @default = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimum"u8))
                {
                    ReadMinimum(property, ref minimum);
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    ReadMaximum(property, ref maximum);
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    ReadDefault(property, ref @default);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MonitorScaleCapacity(minimum, maximum, @default, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorScaleCapacity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorScaleCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorScaleCapacity)} does not support writing '{options.Format}' format.");
            }
        }

        MonitorScaleCapacity IPersistableModel<MonitorScaleCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorScaleCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorScaleCapacity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorScaleCapacity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorScaleCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
