using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

public partial class VBusTagoDetailInfoView
{
    /// <summary>
    /// 차량번호
    /// </summary>
    public int VehicleNo { get; set; }

    /// <summary>
    /// 지역 코드
    /// </summary>
    public long? MemberOfficeId { get; set; }

    /// <summary>
    /// 도시코드
    /// </summary>
    public int CityCode { get; set; }

    /// <summary>
    /// 노선ID
    /// </summary>
    public string RouteId { get; set; } = null!;

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
    /// 첫차시간
    /// </summary>
    public string? StartVehicleTime { get; set; }

    /// <summary>
    /// 막차시간
    /// </summary>
    public string? EndVehicleTime { get; set; }

    /// <summary>
    /// 노선유형
    /// </summary>
    public string? RouteTp { get; set; }

    /// <summary>
    /// 정류장ID
    /// </summary>
    public string? BeforeNodeId { get; set; }

    /// <summary>
    /// 정류장이름
    /// </summary>
    public string? BeforeNodeName { get; set; }

    /// <summary>
    /// 노드순서
    /// </summary>
    public int? BeforeNodeOrder { get; set; }

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
    /// 정류장ID
    /// </summary>
    public string? NextNodeId { get; set; }

    /// <summary>
    /// 정류장이름
    /// </summary>
    public string? NextNodeName { get; set; }

    /// <summary>
    /// 노드순서
    /// </summary>
    public int? NextNodeOrder { get; set; }

    /// <summary>
    /// 경도
    /// </summary>
    public float? GpsLong { get; set; }

    /// <summary>
    /// 위도
    /// </summary>
    public float? GpsLati { get; set; }

    /// <summary>
    /// 전체주행거리
    /// </summary>
    public long? TotalMileage { get; set; }

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

    public long? AfterFuelMileage { get; set; }

    public double? AfterFuelUsage { get; set; }

    public double? FuelRemainAmount { get; set; }

    /// <summary>
    /// 업데이트 시간(저장시간)
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 생성시간
    /// </summary>
    public DateTime? CreateTime { get; set; }
}
