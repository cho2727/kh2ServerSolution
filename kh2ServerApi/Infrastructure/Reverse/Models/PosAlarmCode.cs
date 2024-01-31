using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// POS 알람 코드 정보
/// </summary>
public partial class PosAlarmCode
{
    /// <summary>
    /// 알람 코드 ID
    /// </summary>
    public int PosAlarmId { get; set; }

    /// <summary>
    /// 알람 코드명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 알람 코드 영문명
    /// </summary>
    public string EName { get; set; } = null!;

    /// <summary>
    /// 설명
    /// </summary>
    public string? Description { get; set; }
}
