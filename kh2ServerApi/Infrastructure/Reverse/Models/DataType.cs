using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 데이터 타입
/// </summary>
public partial class DataType
{
    /// <summary>
    /// 데이터 타입 ID
    /// </summary>
    public int DataTypeId { get; set; }

    /// <summary>
    /// 데이터 타입명
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ICollection<AiIndex> AiIndices { get; set; } = new List<AiIndex>();

    public virtual ICollection<AoIndex> AoIndices { get; set; } = new List<AoIndex>();

    public virtual ICollection<BiIndex> BiIndices { get; set; } = new List<BiIndex>();

    public virtual ICollection<CalculationIndex> CalculationIndices { get; set; } = new List<CalculationIndex>();

    public virtual ICollection<CommonIndex> CommonIndices { get; set; } = new List<CommonIndex>();

    public virtual ICollection<CounterIndex> CounterIndices { get; set; } = new List<CounterIndex>();

    public virtual ICollection<MasterIndex> MasterIndices { get; set; } = new List<MasterIndex>();
}
