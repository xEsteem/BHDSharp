// <copyright file="BhdRestClient.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

namespace BHDSharp.Services.Impl;

using System;
using System.Threading.Tasks;
using BHDSharp.Data.Search;
using RestSharp;

public class BhdRestClient : IBhdRestClient
{
    #region Fields

    private static readonly Uri _apiUriBase = new("https://beyond-hd.me/api");
    private readonly RestClient _restClient;

    #endregion

    #region Constructors

    public BhdRestClient(string apiKey)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new ArgumentNullException(nameof(apiKey));
        }

        RestClientOptions options = new(new Uri(_apiUriBase, apiKey));
        this._restClient = new RestClient(options);
    }

    #endregion

    #region Methods

    public async Task<SearchResult> SearchAsync(Search search)
    {
        RestRequest request = new()
        {
            Method = Method.Post
        };
        request.AddJsonBody(search);

        SearchResult searchResult = await this._restClient.PostAsync<SearchResult>(request);
        return searchResult;
    }

    #endregion
}