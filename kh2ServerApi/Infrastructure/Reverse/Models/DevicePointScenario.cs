using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 디바이스 포인트 시나리오
/// </summary>
public partial class DevicePointScenario
{
    /// <summary>
    /// 로그인덱스
    /// </summary>
    public long Idx { get; set; }

    /// <summary>
    /// 시나리오 타입 (1: 개별, 2: CEQ 타입별)
    /// </summary>
    public sbyte ScenarioType { get; set; }

    /// <summary>
    /// 시나리오 이름
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// CEQ 타입
    /// </summary>
    public int? CeqTypeId { get; set; }

    /// <summary>
    /// 디바이스 아이디
    /// </summary>
    public int? DeviceId { get; set; }

    /// <summary>
    /// 회로번호
    /// </summary>
    public sbyte? CircuitNo { get; set; }

    /// <summary>
    /// 포인트 영문명
    /// </summary>
    public string? IndexName { get; set; }

    /// <summary>
    /// 시나리오 패턴(1: 일반 2: 증가 11: 년 12: 월 13:시 14:분 15: 초)
    /// </summary>
    public sbyte? ScenarioPattern { get; set; }

    /// <summary>
    /// 포인트 설정값
    /// </summary>
    public string? SetValues { get; set; }

    /// <summary>
    /// 업데이트 시간
    /// </summary>
    public DateTime UpdateTime { get; set; }
}
