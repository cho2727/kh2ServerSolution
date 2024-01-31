using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

public partial class VBusRouteStopView
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
    /// 이름
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// x좌표(경도)
    /// </summary>
    public float? Stopx { get; set; }

    /// <summary>
    /// y좌표(위도)
    /// </summary>
    public float? Stopy { get; set; }
}
