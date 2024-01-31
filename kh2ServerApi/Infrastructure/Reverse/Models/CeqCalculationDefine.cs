using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 설비단위계산포인트정의
/// </summary>
public partial class CeqCalculationDefine
{
    /// <summary>
    /// 설비 ID
    /// </summary>
    public long Mrid { get; set; }

    /// <summary>
    /// 인덱스 ID
    /// </summary>
    public int DynamicIndex { get; set; }

    /// <summary>
    /// 계산주기
    /// </summary>
    public int? Period { get; set; }

    /// <summary>
    /// 계산식
    /// </summary>
    public string? Formula { get; set; }

    /// <summary>
    /// 설명
    /// </summary>
    public string? Description { get; set; }
}
