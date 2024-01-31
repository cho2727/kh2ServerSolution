using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 정류장 정보
/// </summary>
public partial class BusStopInfo
{
    /// <summary>
    /// 정류장 표준ID
    /// </summary>
    public long StopStandardId { get; set; }

    /// <summary>
    /// 정류장 ID
    /// </summary>
    public int StopId { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 지점ID
    /// </summary>
    public long BnodeId { get; set; }

    /// <summary>
    /// 지점순번
    /// </summary>
    public int? BrnSeqNo { get; set; }

    public virtual ICollection<BusRouteStopInfo> BusRouteStopInfos { get; set; } = new List<BusRouteStopInfo>();
}
