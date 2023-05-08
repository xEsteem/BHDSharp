// <copyright file="SearchResultItem.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

namespace BHDSharp.Data.Search;

using System;
using System.Text.Json.Serialization;
using BHDSharp.Converters;

public class SearchResultItem
{
    #region Properties

    [JsonPropertyName("bhd_rating")]
    public float BhdRating { get; set; }

    [JsonConverter(typeof(DateTimeConverter))]
    [JsonPropertyName("bumped_at")]
    public DateTime BumpedAt { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("commentary")]
    public bool Commentary { get; set; }

    [JsonConverter(typeof(DateTimeConverter))]
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("dv")]
    public bool DolbyVision { get; set; }

    [JsonPropertyName("download_url")]
    public Uri DownloadUrl { get; set; }

    [JsonPropertyName("folder_name")]
    public string FolderName { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("freeleech")]
    public bool Freeleech { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("hdr10")]
    public bool Hdr10 { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("hdr10+")]
    public bool Hdr10Plus { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("hlg")]
    public bool Hlg { get; set; }

    [JsonPropertyName("id")]
    public uint Id { get; set; }

    [JsonPropertyName("imdb_id")]
    public string ImdbId { get; set; }

    [JsonPropertyName("imdb_rating")]
    public float ImdbRating { get; set; }

    [JsonPropertyName("info_hash")]
    public string InfoHash { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("internal")]
    public bool Internal { get; set; }

    [JsonPropertyName("leechers")]
    public uint Leechers { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("limited")]
    public bool Limited { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("promo25")]
    public bool Promo25 { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("promo50")]
    public bool Promo50 { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("promo75")]
    public bool Promo75 { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("refund")]
    public bool Refund { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("rescue")]
    public bool Rescue { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("rewind")]
    public bool Rewind { get; set; }

    [JsonPropertyName("seeders")]
    public uint Seeders { get; set; }

    [JsonPropertyName("size")]
    public long Size { get; set; }

    [JsonPropertyName("times_completed")]
    public uint TimesCompleted { get; set; }

    [JsonPropertyName("tmdb_id")]
    public string TmdbId { get; set; }

    [JsonPropertyName("tmdb_rating")]
    public float TmdbRating { get; set; }

    [JsonConverter(typeof(BoolConverter))]
    [JsonPropertyName("tv_pack")]
    public bool TvPack { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("uploaded_by")]
    public string UploadedBy { get; set; }

    [JsonPropertyName("url")]
    public Uri UrL { get; set; }

    #endregion
}