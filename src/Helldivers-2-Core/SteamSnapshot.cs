﻿using Helldivers.Core.Mapping;
using Helldivers.Models.Domain;
using Helldivers.Models.Steam;

namespace Helldivers.Core;

public sealed class SteamSnapshot
{
    public List<SteamNews>? Feed { get; set; }

    public void UpdateSteamSnapshot(List<SteamNewsFeedItem> items)
    {
        Feed = items.Select(SteamNewsMapper.MapToDomain).ToList();
    }
}