using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 계산식 정의 코드
/// </summary>
public partial class CalculationDefineCode
{
    /// <summary>
    /// 코드ID
    /// </summary>
    public int CodeId { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 설명
    /// </summary>
    public string? Description { get; set; }
}
