// <copyright file="BhdRestClient.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

namespace BHDSharp;

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BHDSharp.Data.Search;
using BHDSharp.Services;
using RestSharp;
using RestSharp.Serializers.Json;

public class BhdRestClient : IBhdRestClient
{
    #region Fields

    private static readonly Uri _apiUriBase = new("https://beyond-hd.me/api");
    private readonly RestClient _restClient;

    #endregion

    #region Constructors

    public BhdRestClient()
    {
        RestClientOptions options = new(_apiUriBase);
        this._restClient = new RestClient(
            options,
            configureSerialization: s => s.UseSystemTextJson(new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
            }));
    }

    #endregion

    #region Methods

    /// <inheritdoc />
    public SearchResult Search(Search search)
    {
        if (string.IsNullOrWhiteSpace(search.ApiKey))
        {
            throw new Exception("ApiKey must be assigned to the search payload.");
        }

        RestRequest request = CreateRestSearchRequest(search);
        SearchResult searchResult = this._restClient.Post<SearchResult>(request);
        return searchResult;
    }

    /// <inheritdoc />
    public async Task<SearchResult> SearchAsync(Search search)
    {
        if (string.IsNullOrWhiteSpace(search.ApiKey))
        {
            throw new Exception("ApiKey must be assigned to the search payload.");
        }

        RestRequest request = CreateRestSearchRequest(search);
        SearchResult searchResult = await this._restClient.PostAsync<SearchResult>(request);
        return searchResult;
    }

    /// <inheritdoc />
    public IReadOnlyCollection<SearchResultItem> SearchComprehensive(Search search)
    {
        if (string.IsNullOrWhiteSpace(search.ApiKey))
        {
            throw new Exception("ApiKey must be assigned to the search payload.");
        }

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
        if (string.IsNullOrWhiteSpace(search.ApiKey))
        {
            throw new Exception("ApiKey must be assigned to the search payload.");
        }

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

    private static RestRequest CreateRestSearchRequest(Search search)
    {
        RestRequest request = new($"torrents/{search.ApiKey}")
        {
            Method = Method.Post
        };
        request.AddJsonBody(search);
        return request;
    }

    #endregion
}