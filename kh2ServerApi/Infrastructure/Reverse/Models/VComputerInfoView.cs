using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

public partial class VComputerInfoView
{
    /// <summary>
    /// 컴퓨터 ID
    /// </summary>
    public int ComputerId { get; set; }

    /// <summary>
    /// 컴퓨터명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 컴퓨터 그룹ID
    /// </summary>
    public int ComputerGroupFk { get; set; }

    /// <summary>
    /// 컴퓨터 그룹명
    /// </summary>
    public string GroupName { get; set; } = null!;

    /// <summary>
    /// 이중화구성여부
    /// </summary>
    public sbyte? IsDup { get; set; }

    /// <summary>
    /// 알람 우선순위 ID
    /// </summary>
    public int? AlarmPriorityFk { get; set; }

    /// <summary>
    /// 상태 그룹 ID
    /// </summary>
    public int? StateGroupFk { get; set; }

    /// <summary>
    /// 지역 코드
    /// </summary>
    public long? MemberOfficeFk { get; set; }

    /// <summary>
    /// OS 이름
    /// </summary>
    public string? OsName { get; set; }

    /// <summary>
    /// OS 버젼
    /// </summary>
    public string? OsVersion { get; set; }

    /// <summary>
    /// 사용 여부
    /// </summary>
    public sbyte? UseFlag { get; set; }

    public string? DpName { get; set; }

    public string DpType { get; set; } = null!;
}
