using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// SNMP 상태
/// </summary>
public partial class SnmpState
{
    /// <summary>
    /// SNMP ID
    /// </summary>
    public int SnmpFk { get; set; }

    /// <summary>
    /// 지역 코드
    /// </summary>
    public long? MemberOfficeFk { get; set; }

    /// <summary>
    /// 상태
    /// </summary>
    public int? Status { get; set; }

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
    /// 갱신 시간
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    public virtual SnmpInfo SnmpFkNavigation { get; set; } = null!;
}
