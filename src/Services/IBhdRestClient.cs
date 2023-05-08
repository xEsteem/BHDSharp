// <copyright file="IBhdRestClient.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

namespace BHDSharp.Services;

using System.Collections.Generic;
using System.Threading.Tasks;
using BHDSharp.Data.Search;

public interface IBhdRestClient
{
    #region Methods

    SearchResult Search(Search search);

    IReadOnlyCollection<SearchResultItem> SearchComprehensive(Search search);

    Task<SearchResult> SearchAsync(Search search);

    Task<IReadOnlyCollection<SearchResultItem>> SearchComprehensiveAsync(Search search);

    #endregion
}