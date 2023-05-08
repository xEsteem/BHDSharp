// <copyright file="BoolConverter.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

namespace BHDSharp.Converters;

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class BoolConverter : JsonConverter<bool>
{
    #region Methods

    public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
            JsonTokenType.True => true,
            JsonTokenType.False => false,
            JsonTokenType.String => bool.TryParse(reader.GetString(), out bool b) ? b : throw new JsonException(),
            JsonTokenType.Number => reader.TryGetByte(out byte l)
                ? Convert.ToBoolean(l)
                : reader.TryGetDouble(out double d) && Convert.ToBoolean(d),
            _ => throw new JsonException()
        };
    }

    public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(Convert.ToByte(value));
    }

    #endregion
}