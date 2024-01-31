using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 버스정보
/// </summary>
public partial class BusStopLocation
{
    /// <summary>
    /// 버스 번호
    /// </summary>
    public int BusNo { get; set; }

    /// <summary>
    /// 노선 식별 ID
    /// </summary>
    public long BrtStdId { get; set; }

    /// <summary>
    /// 저상여부
    /// </summary>
    public sbyte? BusLow { get; set; }

    /// <summary>
    /// 현재 정류장 위치
    /// </summary>
    public long? NewStopStdId { get; set; }

    /// <summary>
    /// 이전 정류장 위치
    /// </summary>
    public long? OldStopStdId { get; set; }

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

    /// <summary>
    /// 사용여부
    /// </summary>
    public sbyte? BrtUseYn { get; set; }

    /// <summary>
    /// 업데이트 시간(저장시간)
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 생성시간
    /// </summary>
    public DateTime? CreateTime { get; set; }

    public virtual BusRouteInfo BrtStd { get; set; } = null!;
}
