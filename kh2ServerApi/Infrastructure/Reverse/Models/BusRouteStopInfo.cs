using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 노선별 정류장 정보
/// </summary>
public partial class BusRouteStopInfo
{
    /// <summary>
    /// 노선 식별 ID
    /// </summary>
    public long BrtStdId { get; set; }

    /// <summary>
    /// 정류장 표준ID
    /// </summary>
    public long? StopStandardId { get; set; }

    /// <summary>
    /// 정류장순번
    /// </summary>
    public int BrsSeqno { get; set; }

    /// <summary>
    /// 비고
    /// </summary>
    public string? Remark { get; set; }

    public virtual BusRouteInfo BrtStd { get; set; } = null!;

    public virtual BusStopInfo? StopStandard { get; set; }
}
