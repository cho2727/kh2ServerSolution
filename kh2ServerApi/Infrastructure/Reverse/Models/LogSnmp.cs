using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 컴퓨터 상태 로그
/// </summary>
public partial class LogSnmp
{
    /// <summary>
    /// 로그ID
    /// </summary>
    public long LogId { get; set; }

    /// <summary>
    /// SNMP ID
    /// </summary>
    public int SnmpId { get; set; }

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
    /// CPU 사용률(%)
    /// </summary>
    public float? CpuRate { get; set; }

    /// <summary>
    /// MEM 사용률(%)
    /// </summary>
    public float? MemRate { get; set; }

    /// <summary>
    /// DISK 사용률(%)
    /// </summary>
    public float? DiskRate { get; set; }

    /// <summary>
    /// 포트 아이디
    /// </summary>
    public string? PortId { get; set; }

    /// <summary>
    /// 포트 값
    /// </summary>
    public string? PortValue { get; set; }

    /// <summary>
    /// 메시지
    /// </summary>
    public string? EventMsg { get; set; }

    /// <summary>
    /// 업데이트 시간(저장시간)
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
