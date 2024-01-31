using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 버스 정류장 위치 정보
/// </summary>
public partial class BusStopPositionInfo
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
    /// x좌표(경도)
    /// </summary>
    public float Stopx { get; set; }

    /// <summary>
    /// y좌표(위도)
    /// </summary>
    public float Stopy { get; set; }
}
