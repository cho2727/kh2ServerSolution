using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 버스타고 위치정보
/// </summary>
public partial class BusTagoLocationInfo
{
    /// <summary>
    /// 차량번호
    /// </summary>
    public int VehicleNo { get; set; }

    /// <summary>
    /// 지역 코드
    /// </summary>
    public long? MemberOfficeFk { get; set; }

    /// <summary>
    /// 노선ID
    /// </summary>
    public string RouteId { get; set; } = null!;

    /// <summary>
    /// 노선유형
    /// </summary>
    public string? RouteTp { get; set; }

    /// <summary>
    /// 정류장ID
    /// </summary>
    public string NodeId { get; set; } = null!;

    /// <summary>
    /// 정류장이름
    /// </summary>
    public string NodeName { get; set; } = null!;

    /// <summary>
    /// 노드순서
    /// </summary>
    public int? NodeOrder { get; set; }

    /// <summary>
    /// 위도
    /// </summary>
    public float? GpsLati { get; set; }

    /// <summary>
    /// 경도
    /// </summary>
    public float? GpsLong { get; set; }

    /// <summary>
    /// 일일주행거리
    /// </summary>
    public long? TodayMileage { get; set; }

    /// <summary>
    /// 연료주입일
    /// </summary>
    public DateTime? FuelInjectionDate { get; set; }

    /// <summary>
    /// 연료주입시총주행거리
    /// </summary>
    public long? FuelInjectionMileage { get; set; }

    /// <summary>
    /// 연료충전완료후량
    /// </summary>
    public int? AfterFuelAmount { get; set; }

    /// <summary>
    /// 전체주행거리
    /// </summary>
    public long? TotalMileage { get; set; }

    /// <summary>
    /// 업데이트 시간(저장시간)
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 생성시간
    /// </summary>
    public DateTime? CreateTime { get; set; }
}
