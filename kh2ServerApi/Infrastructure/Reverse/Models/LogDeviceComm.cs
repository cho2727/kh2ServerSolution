using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 원격 설비 통신 로그
/// </summary>
public partial class LogDeviceComm
{
    /// <summary>
    /// 로그ID
    /// </summary>
    public long LogId { get; set; }

    /// <summary>
    /// 지역 코드
    /// </summary>
    public long? MemberOfficeFk { get; set; }

    /// <summary>
    /// 변전소 ID
    /// </summary>
    public long? StationFk { get; set; }

    /// <summary>
    /// 통신기기ID
    /// </summary>
    public int DeviceFk { get; set; }

    /// <summary>
    /// 연결 기기 ID
    /// </summary>
    public long? CeqFk { get; set; }

    /// <summary>
    /// 통신상태
    /// </summary>
    public sbyte? OldCommState { get; set; }

    /// <summary>
    /// 통신상태
    /// </summary>
    public sbyte? NewCommState { get; set; }

    /// <summary>
    /// 전체 통신 수행 횟수
    /// </summary>
    public int? CommTotalCnt { get; set; }

    /// <summary>
    /// 통신 성공 개수
    /// </summary>
    public int? CommSucessCnt { get; set; }

    /// <summary>
    /// 통신 실패 개수
    /// </summary>
    public int? CommFailCnt { get; set; }

    /// <summary>
    /// 무응답 개수
    /// </summary>
    public int? CommNoResponseCnt { get; set; }

    /// <summary>
    /// 메시지
    /// </summary>
    public string? EventMsg { get; set; }

    /// <summary>
    /// 업데이트 시간(저장시간)
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
