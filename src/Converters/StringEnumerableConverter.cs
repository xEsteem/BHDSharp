// <copyright file="StringEnumerableConverter.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

namespace BHDSharp.Converters;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class StringEnumerableConverter : JsonConverter<IEnumerable<string>>
{
    #region Methods

    public override IEnumerable<string> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
            JsonTokenType.String => reader.GetString()
                                          .Split(
                                              new[]
                                              {
                                                  ','
                                              },
                                              StringSplitOptions.RemoveEmptyEntries),
            _ => throw new JsonException()
        };
    }

    public override void Write(Utf8JsonWriter writer, IEnumerable<string> value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(string.Join(",", value));
    }

    #endregion
}