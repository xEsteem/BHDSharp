﻿// <copyright file="BhdRestClient.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

namespace BHDSharp;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BHDSharp.Data.Search;
using BHDSharp.Services;
using RestSharp;

public class BhdRestClient : IBhdRestClient
{
    #region Fields

    private static readonly Uri _apiUriBase = new("https://beyond-hd.me/api");
    private readonly string _apiKey;
    private readonly RestClient _restClient;

    #endregion

    #region Constructors

    public BhdRestClient(string apiKey)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new ArgumentNullException(nameof(apiKey));
        }

        this._apiKey = apiKey;

        RestClientOptions options = new(_apiUriBase);
        this._restClient = new RestClient(options);
    }

    #endregion

    #region Methods

    /// <inheritdoc />
    public SearchResult Search(Search search)
    {
        RestRequest request = this.CreateRestSearchRequest(search);
        SearchResult searchResult = this._restClient.Post<SearchResult>(request);
        return searchResult;
    }

    /// <inheritdoc />
    public async Task<SearchResult> SearchAsync(Search search)
    {
        RestRequest request = this.CreateRestSearchRequest(search);
        SearchResult searchResult = await this._restClient.PostAsync<SearchResult>(request);
        return searchResult;
    }

    /// <inheritdoc />
    public IReadOnlyCollection<SearchResultItem> SearchComprehensive(Search search)
    {
        search.Page = 1;

        SearchResult initialResponse = this.Search(search);
        List<SearchResultItem> results = new(initialResponse.TotalResults);
        results.AddRange(initialResponse.Results);

        if (initialResponse.TotalPages < 1)
        {
            return results;
        }

        for (int i = 2; i <= initialResponse.TotalPages; i++)
        {
            search.Page = i;
            SearchResult subResponse = this.Search(search);
            results.AddRange(subResponse.Results);
        }

        return results;
    }

    /// <inheritdoc />
    public async Task<IReadOnlyCollection<SearchResultItem>> SearchComprehensiveAsync(Search search)
    {
        search.Page = 1;

        SearchResult initialResponse = await this.SearchAsync(search);
        List<SearchResultItem> results = new(initialResponse.TotalResults);
        results.AddRange(initialResponse.Results);

        if (initialResponse.TotalPages < 1)
        {
            return results;
        }

        for (int i = 2; i <= initialResponse.TotalPages; i++)
        {
            search.Page = i;
            SearchResult subResponse = await this.SearchAsync(search);
            results.AddRange(subResponse.Results);
        }

        return results;
    }

    private RestRequest CreateRestSearchRequest(Search search)
    {
        RestRequest request = new($"torrents/{this._apiKey}")
        {
            Method = Method.Post
        };
        request.AddJsonBody(search);
        return request;
    }

    #endregion
}