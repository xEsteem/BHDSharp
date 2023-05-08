// <copyright file="Search.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

namespace BHDSharp.Data.Search;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using BHDSharp.Converters;

public class Search
{
    #region Properties

    [JsonPropertyName("action")]
    public string Action { get; } = "search";

    [JsonPropertyName("alive")]
    public bool Alive { get; set; }

    [JsonConverter(typeof(StringEnumerableConverter))]
    [JsonPropertyName("audios")]
    public IEnumerable<string> AudioLanguages { get; set; }

    [JsonPropertyName("h264")]
    public bool Avc { get; set; }

    [JsonConverter(typeof(StringEnumerableConverter))]
    [JsonPropertyName("categories")]
    public IEnumerable<string> Categories { get; set; }

    [JsonPropertyName("completed")]
    public bool Completed { get; set; }

    [JsonConverter(typeof(StringEnumerableConverter))]
    [JsonPropertyName("countries")]
    public IEnumerable<string> Countries { get; set; }

    [JsonPropertyName("dead")]
    public bool Dead { get; set; }

    [JsonPropertyName("dying")]
    public bool Dying { get; set; }

    [JsonConverter(typeof(StringEnumerableConverter))]
    [JsonPropertyName("features")]
    public IEnumerable<string> Features { get; set; }

    [JsonPropertyName("features_type")]
    public MatchType FeaturesMatch { get; set; } = MatchType.All;

    [JsonPropertyName("file_name")]
    public string FileName { get; set; }

    [JsonPropertyName("folder_name")]
    public string FolderName { get; set; }

    [JsonPropertyName("freeleech")]
    public bool FreeLeech { get; set; }

    [JsonPropertyName("genres_type")]
    public MatchType GenreMatch { get; set; } = MatchType.All;

    [JsonConverter(typeof(StringEnumerableConverter))]
    [JsonPropertyName("genres")]
    public IEnumerable<string> Genres { get; set; }

    [JsonConverter(typeof(StringEnumerableConverter))]
    [JsonPropertyName("groups")]
    public IEnumerable<string> Groups { get; set; }

    [JsonPropertyName("h265")]
    public bool Hevc { get; set; }

    [JsonPropertyName("imdb_id")]
    public int ImdbId { get; set; }

    [JsonPropertyName("incomplete")]
    public bool Incomplete { get; set; }

    [JsonPropertyName("info_hash")]
    public string InfoHash { get; set; }

    [JsonPropertyName("internal")]
    public bool Internal { get; set; }

    [JsonPropertyName("leeching")]
    public bool Leeching { get; set; }

    [JsonPropertyName("limited")]
    public bool Limited { get; set; }

    [JsonPropertyName("max_year")]
    public uint MaximumYear { get; set; }

    [JsonPropertyName("min_bhd")]
    public float MinimumBhdRating { get; set; }

    [JsonPropertyName("vote_bhd")]
    public int MinimumBhdVotes { get; set; }

    [JsonPropertyName("min_imdb")]
    public float MinimumImdbRating { get; set; }

    [JsonPropertyName("vote_imdb")]
    public int MinimumImdbVotes { get; set; }

    [JsonPropertyName("min_tmdb")]
    public float MinimumTmdbRating { get; set; }

    [JsonPropertyName("vote_tmdb")]
    public int MinimumTmdbVotes { get; set; }

    [JsonPropertyName("min_year")]
    public uint MinimumYear { get; set; }

    [JsonPropertyName("notdownloaded")]
    public bool NotDownloaded { get; set; }

    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    [JsonPropertyName("order")]
    public OrderBy OrderBy { get; set; } = OrderBy.Descending;

    [JsonPropertyName("page")]
    public int Page { get; set; } = 1;

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

    [JsonPropertyName("reseed")]
    public bool Reseed { get; set; }

    [JsonPropertyName("rewind")]
    public bool Rewind { get; set; }

    [JsonPropertyName("rsskey")]
    public string RssKey { get; set; }

    [JsonPropertyName("search")]
    public string SearchTerm { get; set; }

    [JsonPropertyName("seeding")]
    public bool Seeding { get; set; }

    [JsonPropertyName("size")]
    public long Size { get; set; }

    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    [JsonPropertyName("sort")]
    public SortBy SortBy { get; set; } = SortBy.BumpedAt;

    [JsonConverter(typeof(StringEnumerableConverter))]
    [JsonPropertyName("sources")]
    public IEnumerable<string> Sources { get; set; }

    [JsonConverter(typeof(StringEnumerableConverter))]
    [JsonPropertyName("languages")]
    public IEnumerable<string> SpokenLanguages { get; set; }

    [JsonPropertyName("sd")]
    public bool StandardDefinition { get; set; }

    [JsonPropertyName("stream")]
    public bool StreamOptimized { get; set; }

    [JsonConverter(typeof(StringEnumerableConverter))]
    [JsonPropertyName("subtitles")]
    public IEnumerable<string> SubtitleLanguages { get; set; }

    [JsonPropertyName("tmdb_id")]
    public int TmdbId { get; set; }

    [JsonPropertyName("pack")]
    public bool TvPack { get; set; }

    [JsonConverter(typeof(StringEnumerableConverter))]
    [JsonPropertyName("types")]
    public IEnumerable<string> Types { get; set; }

    [JsonPropertyName("uploaded_by")]
    public string UploadedBy { get; set; }

    #endregion
}