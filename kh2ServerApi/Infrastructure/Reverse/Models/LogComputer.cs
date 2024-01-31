using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 컴퓨터 상태 로그
/// </summary>
public partial class LogComputer
{
    /// <summary>
    /// 로그ID
    /// </summary>
    public long LogId { get; set; }

    /// <summary>
    /// 컴퓨터 ID
    /// </summary>
    public int ComputerId { get; set; }

    /// <summary>
    /// 지역 코드
    /// </summary>
    public long? MemberOfficeFk { get; set; }

    /// <summary>
    /// CPU 사용률(%)
    /// </summary>
    public float? CpuRate { get; set; }

    /// <summary>
    /// 전체 메모리 크기(MB)
    /// </summary>
    public long? MemTotal { get; set; }

    /// <summary>
    /// 사용 메모리 크기(MB)
    /// </summary>
    public long? MemUsage { get; set; }

    /// <summary>
    /// 전체 디스크 크기(MB)
    /// </summary>
    public long? DiskTotal { get; set; }

    /// <summary>
    /// 사용 디스크 크기(MB)
    /// </summary>
    public long? DiskUsage { get; set; }

    /// <summary>
    /// 상태
    /// </summary>
    public sbyte? OldStatus { get; set; }

    /// <summary>
    /// 상태
    /// </summary>
    public sbyte? NewStatus { get; set; }

    /// <summary>
    /// 활성화 상태(Active)
    /// </summary>
    public sbyte? OldActiveState { get; set; }

    /// <summary>
    /// 활성화 상태(Active)
    /// </summary>
    public sbyte? NewActiveState { get; set; }

    /// <summary>
    /// 메시지
    /// </summary>
    public string? EventMsg { get; set; }

    /// <summary>
    /// 업데이트 시간(저장시간)
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
