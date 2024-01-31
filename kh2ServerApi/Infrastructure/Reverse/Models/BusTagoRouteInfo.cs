using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 버스타고 노선정보
/// </summary>
public partial class BusTagoRouteInfo
{
    /// <summary>
    /// 노선ID
    /// </summary>
    public string RouteId { get; set; } = null!;

    /// <summary>
    /// 이름
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 도시코드
    /// </summary>
    public int CityCode { get; set; }

    /// <summary>
    /// 노선번호
    /// </summary>
    public string RouteNo { get; set; } = null!;

    /// <summary>
    /// 기점
    /// </summary>
    public string? StartNodeName { get; set; }

    /// <summary>
    /// 종점
    /// </summary>
    public string? EndNodeName { get; set; }

    /// <summary>
    /// 노선유형
    /// </summary>
    public string? RouteTp { get; set; }

    /// <summary>
    /// 첫차시간
    /// </summary>
    public string? StartVehicleTime { get; set; }

    /// <summary>
    /// 막차시간
    /// </summary>
    public string? EndVehicleTime { get; set; }

    /// <summary>
    /// 사용여부
    /// </summary>
    public sbyte? UseYn { get; set; }

    public virtual ICollection<BusTagoStopInfo> BusTagoStopInfos { get; set; } = new List<BusTagoStopInfo>();

    public virtual BusTagoCityCode CityCodeNavigation { get; set; } = null!;
}
