using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 기준 전압
/// </summary>
public partial class BaseVoltage
{
    /// <summary>
    /// 기준 전압 ID
    /// </summary>
    public int BaseVoltageId { get; set; }

    /// <summary>
    /// 기준 전압명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 기준 전압
    /// </summary>
    public float? NormalVoltage { get; set; }

    /// <summary>
    /// 기준 전압 단위
    /// </summary>
    public int? NormalVoltageUnitFk { get; set; }

    /// <summary>
    /// 최대 전압
    /// </summary>
    public float? MaxVoltage { get; set; }

    /// <summary>
    /// 최대 전압 단위
    /// </summary>
    public int? MaxVoltageUnitFk { get; set; }
}
