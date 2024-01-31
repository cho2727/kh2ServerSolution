using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 프로그램 상태 로그
/// </summary>
public partial class LogProgram
{
    /// <summary>
    /// 로그ID
    /// </summary>
    public long LogId { get; set; }

    /// <summary>
    /// 프로그램 ID
    /// </summary>
    public int ProgramId { get; set; }

    /// <summary>
    /// 지역 코드
    /// </summary>
    public long? MemberOfficeFk { get; set; }

    /// <summary>
    /// 상태
    /// </summary>
    public sbyte? OldStatus { get; set; }

    /// <summary>
    /// 상태
    /// </summary>
    public sbyte? NewStatus { get; set; }

    /// <summary>
    /// 시작시간
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// 종료시간
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// 메시지
    /// </summary>
    public string? EventMsg { get; set; }

    /// <summary>
    /// 갱신시간
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
