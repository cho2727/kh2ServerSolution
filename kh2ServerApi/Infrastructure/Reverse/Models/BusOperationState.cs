using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 버스타고 차량운영상태
/// </summary>
public partial class BusOperationState
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
    /// 도시코드
    /// </summary>
    public int CityCode { get; set; }

    /// <summary>
    /// 노선ID
    /// </summary>
    public string RouteId { get; set; } = null!;

    /// <summary>
    /// 사용여부
    /// </summary>
    public sbyte? BusRunStop { get; set; }

    /// <summary>
    /// 연료주입일
    /// </summary>
    public DateTime? FuelInjectionDate { get; set; }

    /// <summary>
    /// 전체주행거리
    /// </summary>
    public long? TotalMileage { get; set; }

    /// <summary>
    /// 연료주입시총주행거리
    /// </summary>
    public long? FuelInjectionMileage { get; set; }

    /// <summary>
    /// 연료충전완료후량
    /// </summary>
    public int? AfterFuelAmount { get; set; }

    /// <summary>
    /// 업데이트 시간(저장시간)
    /// </summary>
    public DateTime? DeviceUpdateTime { get; set; }

    /// <summary>
    /// 업데이트 시간(저장시간)
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
