using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

public partial class VSnmpInfoView
{
    /// <summary>
    /// 아이디
    /// </summary>
    public int SnmpId { get; set; }

    /// <summary>
    /// snmp 그룹 아이디
    /// </summary>
    public int SnmpGroupFk { get; set; }

    /// <summary>
    /// snmp 그룹 이름
    /// </summary>
    public string SnmpGroupName { get; set; } = null!;

    /// <summary>
    /// 주소
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// 포트
    /// </summary>
    public int? Port { get; set; }

    /// <summary>
    /// 커뮤니티 이름
    /// </summary>
    public string? CommunityName { get; set; }

    /// <summary>
    /// OS 타입
    /// </summary>
    public int OsTypeFk { get; set; }

    /// <summary>
    /// 장비 이름
    /// </summary>
    public string? DeviceName { get; set; }

    /// <summary>
    /// 타임아웃
    /// </summary>
    public int? TimeOut { get; set; }

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
    /// 알람 우선순위 ID
    /// </summary>
    public int AlarmPriorityFk { get; set; }

    /// <summary>
    /// 지역 코드
    /// </summary>
    public long? MemberOfficeFk { get; set; }

    /// <summary>
    /// 상태 그룹 코드
    /// </summary>
    public int? StateGorupFk { get; set; }

    public string? DpName { get; set; }

    public string DpType { get; set; } = null!;

    /// <summary>
    /// 갱신 시간
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
