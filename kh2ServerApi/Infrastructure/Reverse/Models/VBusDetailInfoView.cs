using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

public partial class VBusDetailInfoView
{
    /// <summary>
    /// 버스 번호
    /// </summary>
    public int BusNo { get; set; }

    /// <summary>
    /// 저상여부
    /// </summary>
    public sbyte? BusLow { get; set; }

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
    /// 정류장순번
    /// </summary>
    public int? MaxBrsSeqno { get; set; }

    public long StopCnt { get; set; }

    /// <summary>
    /// 이전 정류장 위치
    /// </summary>
    public long? BeforeStopId { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    public string? BeforeStopName { get; set; }

    /// <summary>
    /// 정류장순번
    /// </summary>
    public int? BeforeSeq { get; set; }

    /// <summary>
    /// 현재 정류장 위치
    /// </summary>
    public long? NowStopId { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    public string NowStopName { get; set; } = null!;

    /// <summary>
    /// 정류장순번
    /// </summary>
    public int NowSeq { get; set; }

    /// <summary>
    /// x좌표(경도)
    /// </summary>
    public float? NowStopx { get; set; }

    /// <summary>
    /// y좌표(위도)
    /// </summary>
    public float? NowStopy { get; set; }

    /// <summary>
    /// 정류장 표준ID
    /// </summary>
    public long? NextStopStdId { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    public string? NextStopName { get; set; }

    /// <summary>
    /// 정류장순번
    /// </summary>
    public int? NextSeq { get; set; }

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
    public long? BeforeFuelMileage { get; set; }

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
}
