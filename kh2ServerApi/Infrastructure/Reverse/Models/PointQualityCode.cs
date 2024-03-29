﻿using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 포인트 Quality 코드
/// </summary>
public partial class PointQualityCode
{
    /// <summary>
    /// 포인트 Quality 코드 ID
    /// </summary>
    public int PointQualityCodeId { get; set; }

    /// <summary>
    /// 포인트 Quality 코드명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 포인트 Quality 코드 값
    /// </summary>
    public short? Value { get; set; }

    /// <summary>
    /// 별칭
    /// </summary>
    public string? AliseName { get; set; }
}
