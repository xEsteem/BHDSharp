// <copyright file="BhdRestClient.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

using BHDSharp.Services;

namespace BHDSharp;

using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using BHDSharp.Data.Search;
using RestSharp;
using RestSharp.Serializers;
using RestSharp.Serializers.Json;

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

        RestClientOptions options = new(new Uri(_apiUriBase, apiKey));
        this._restClient = new RestClient(options);
    }

    #endregion

    #region Methods

    public async Task<SearchResult> SearchAsync(Search search)
    {
        RestRequest request = new($"torrents/{this._apiKey}")
        {
            Method = Method.Post
        };
        request.AddJsonBody(search);

        SearchResult searchResult = await this._restClient.PostAsync<SearchResult>(request);
        return searchResult;
    }

    #endregion
}