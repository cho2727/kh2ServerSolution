using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// POS 사업자 코드 정보
/// </summary>
public partial class PosBsnsCode
{
    /// <summary>
    /// 사업 코드 ID
    /// </summary>
    public int PosBsnsId { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 설명
    /// </summary>
    public string? Description { get; set; }
}
