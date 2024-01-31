using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 포인트 타입 정보
/// </summary>
public partial class PointType
{
    /// <summary>
    /// 포인트 타입 ID
    /// </summary>
    public int PointTypeId { get; set; }

    /// <summary>
    /// 포인트 타입명
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ICollection<CalculationIndex> CalculationIndices { get; set; } = new List<CalculationIndex>();

    public virtual ICollection<CeqValue> CeqValues { get; set; } = new List<CeqValue>();

    public virtual ICollection<MasterIndex> MasterIndices { get; set; } = new List<MasterIndex>();
}
