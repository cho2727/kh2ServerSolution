using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 단위
/// </summary>
public partial class Unit
{
    /// <summary>
    /// 단위 ID
    /// </summary>
    public int UnitId { get; set; }

    /// <summary>
    /// 단위
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ICollection<AiIndex> AiIndices { get; set; } = new List<AiIndex>();

    public virtual ICollection<AoIndex> AoIndices { get; set; } = new List<AoIndex>();

    public virtual ICollection<CalculationIndex> CalculationIndices { get; set; } = new List<CalculationIndex>();

    public virtual ICollection<CounterIndex> CounterIndices { get; set; } = new List<CounterIndex>();

    public virtual ICollection<MasterIndex> MasterIndices { get; set; } = new List<MasterIndex>();

    public virtual ICollection<ModelItemIndex> ModelItemIndices { get; set; } = new List<ModelItemIndex>();
}
