using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 시스템 설정 테이블
/// </summary>
public partial class SystemSetting
{
    /// <summary>
    /// 아이디
    /// </summary>
    public long Idx { get; set; }

    /// <summary>
    /// 설정키
    /// </summary>
    public string SetKey { get; set; } = null!;

    /// <summary>
    /// 설정값
    /// </summary>
    public string? SetValue { get; set; }
}
