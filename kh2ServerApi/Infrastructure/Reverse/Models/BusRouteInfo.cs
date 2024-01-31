using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 버스노선정보
/// </summary>
public partial class BusRouteInfo
{
    /// <summary>
    /// 노선 식별 ID
    /// </summary>
    public long BrtStdId { get; set; }

    /// <summary>
    /// 노선번호
    /// </summary>
    public int BrtId { get; set; }

    /// <summary>
    /// 노선번호확장
    /// </summary>
    public sbyte BrtClass { get; set; }

    /// <summary>
    /// 노선이름
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 버스대수
    /// </summary>
    public int? BrtBusNum { get; set; }

    /// <summary>
    /// 노선방향(1:정방향, 2:역방향)
    /// </summary>
    public sbyte BrtDirection { get; set; }

    /// <summary>
    /// 기점명
    /// </summary>
    public string? BrtStartName { get; set; }

    /// <summary>
    /// 종점명
    /// </summary>
    public string? BrtEndName { get; set; }

    /// <summary>
    /// 첫차시각
    /// </summary>
    public string? BrtFirstTime { get; set; }

    /// <summary>
    /// 막차시각
    /// </summary>
    public string? BrtLastTime { get; set; }

    /// <summary>
    /// 배차간격불규칙여부
    /// </summary>
    public string? BrtIlregInterval { get; set; }

    /// <summary>
    /// 노선길이
    /// </summary>
    public int? BrtLength { get; set; }

    /// <summary>
    /// 비첨두시배차간격
    /// </summary>
    public int? BrtMaxInterval { get; set; }

    /// <summary>
    /// 점두시배차간격
    /// </summary>
    public int? BrtMinInterval { get; set; }

    /// <summary>
    /// 평균소요시간
    /// </summary>
    public int? BrtNeedTime { get; set; }

    /// <summary>
    /// 분선ID
    /// </summary>
    public string? BrtSubId { get; set; }

    /// <summary>
    /// 사용여부
    /// </summary>
    public sbyte? BrtUseYn { get; set; }

    public virtual ICollection<BusRouteStopInfo> BusRouteStopInfos { get; set; } = new List<BusRouteStopInfo>();

    public virtual ICollection<BusStopLocation> BusStopLocations { get; set; } = new List<BusStopLocation>();
}
