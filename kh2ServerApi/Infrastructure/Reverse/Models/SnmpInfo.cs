using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// SNMP 정보
/// </summary>
public partial class SnmpInfo
{
    /// <summary>
    /// 아이디
    /// </summary>
    public int SnmpId { get; set; }

    /// <summary>
    /// 지역 코드
    /// </summary>
    public long? MemberOfficeFk { get; set; }

    /// <summary>
    /// snmp 그룹 아이디
    /// </summary>
    public int SnmpGroupFk { get; set; }

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
    /// 알람 우선순위 ID
    /// </summary>
    public int AlarmPriorityFk { get; set; }

    /// <summary>
    /// 상태 그룹 코드
    /// </summary>
    public int? StateGorupFk { get; set; }

    public virtual AlarmPriority AlarmPriorityFkNavigation { get; set; } = null!;

    public virtual MemberOffice? MemberOfficeFkNavigation { get; set; }

    public virtual SnmpOsType OsTypeFkNavigation { get; set; } = null!;

    public virtual SnmpGroup SnmpGroupFkNavigation { get; set; } = null!;

    public virtual SnmpState? SnmpState { get; set; }

    public virtual StateGroup? StateGorupFkNavigation { get; set; }
}
