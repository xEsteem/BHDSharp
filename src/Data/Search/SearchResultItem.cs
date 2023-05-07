// <copyright file="SearchResultItem.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

namespace BHDSharp.Data.Search;

using System;
using System.Text.Json.Serialization;

public class SearchResultItem
{
    #region Properties

    [JsonPropertyName("bhd_rating")]
    public float BhdRating { get; set; }

    [JsonPropertyName("bumped_at")]
    public DateTime BumpedAt { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("commentary")]
    public bool Commentary { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("dv")]
    public bool DolbyVision { get; set; }

    [JsonPropertyName("download_url")]
    public Uri DownloadUrl { get; set; }

    [JsonPropertyName("folder_name")]
    public string FolderName { get; set; }

    [JsonPropertyName("freeleech")]
    public bool Freeleech { get; set; }

    [JsonPropertyName("hdr10")]
    public bool Hdr10 { get; set; }

    [JsonPropertyName("hdr10+")]
    public bool Hdr10Plus { get; set; }

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

    [JsonPropertyName("internal")]
    public bool Internal { get; set; }

    [JsonPropertyName("leechers")]
    public uint Leechers { get; set; }

    [JsonPropertyName("limited")]
    public bool Limited { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("promo25")]
    public bool Promo25 { get; set; }

    [JsonPropertyName("promo50")]
    public bool Promo50 { get; set; }

    [JsonPropertyName("promo75")]
    public bool Promo75 { get; set; }

    [JsonPropertyName("refund")]
    public bool Refund { get; set; }

    [JsonPropertyName("rescue")]
    public bool Rescue { get; set; }

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