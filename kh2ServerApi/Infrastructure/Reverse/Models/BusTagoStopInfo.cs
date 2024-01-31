using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 버스타고 정류장 정보
/// </summary>
public partial class BusTagoStopInfo
{
    /// <summary>
    /// 정류장ID
    /// </summary>
    public string NodeId { get; set; } = null!;

    /// <summary>
    /// 노선ID
    /// </summary>
    public string RouteId { get; set; } = null!;

    /// <summary>
    /// 정류장번호
    /// </summary>
    public int NodeNo { get; set; }

    /// <summary>
    /// 정류장이름
    /// </summary>
    public string NodeName { get; set; } = null!;

    /// <summary>
    /// 위도
    /// </summary>
    public float? GpsLati { get; set; }

    /// <summary>
    /// 경도
    /// </summary>
    public float? GpsLong { get; set; }

    /// <summary>
    /// 노드순서
    /// </summary>
    public int? NodeOrder { get; set; }

    public virtual BusTagoRouteInfo Route { get; set; } = null!;
}
