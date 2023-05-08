// <copyright file="SortBy.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

namespace BHDSharp.Data.Search;

using System.Runtime.Serialization;

public enum SortBy
{
    [EnumMember(Value = "bumped_at")]
    BumpedAt,
    [EnumMember(Value = "created_at")]
    CreatedAt,
    [EnumMember(Value = "seeders")]
    Seeders,
    [EnumMember(Value = "leechers")]
    Leechers,
    [EnumMember(Value = "times_completed")]
    TimesCompleted,
    [EnumMember(Value = "size")]
    Size,
    [EnumMember(Value = "name")]
    Name,
    [EnumMember(Value = "imdb_rating")]
    ImdbRating,
    [EnumMember(Value = "tmdb_rating")]
    TmdbRating,
    [EnumMember(Value = "bhd_rating")]
    BhdRating
}