// <copyright file="OrderBy.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

namespace BHDSharp.Data.Search;

using System.Runtime.Serialization;

public enum OrderBy
{
    [EnumMember(Value = "desc")]
    Descending,
    [EnumMember(Value = "asc")]
    Ascending
}