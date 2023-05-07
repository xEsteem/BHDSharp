// <copyright file="IBhdRestClient.cs" company="xEsteem@github">
// Copyright (c) xEsteem@github. All rights reserved.
// </copyright>

namespace BHDSharp.Services;

using System.Threading.Tasks;
using BHDSharp.Data.Search;

public interface IBhdRestClient
{
    #region Methods

    Task<SearchResult> SearchAsync(Search Search);

    #endregion
}