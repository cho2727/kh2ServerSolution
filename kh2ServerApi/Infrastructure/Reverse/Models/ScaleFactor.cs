using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 스케일 펙터
/// </summary>
public partial class ScaleFactor
{
    /// <summary>
    /// 스케일 펙터 ID
    /// </summary>
    public int ScaleFactorId { get; set; }

    /// <summary>
    /// 스케일 펙터 값
    /// </summary>
    public float Scale { get; set; }

    /// <summary>
    /// 스케일 펙터 OFFSET 값
    /// </summary>
    public float Offset { get; set; }

    public virtual ICollection<AiIndex> AiIndices { get; set; } = new List<AiIndex>();

    public virtual ICollection<AoIndex> AoIndices { get; set; } = new List<AoIndex>();

    public virtual ICollection<CounterIndex> CounterIndices { get; set; } = new List<CounterIndex>();

    public virtual ICollection<MasterIndex> MasterIndices { get; set; } = new List<MasterIndex>();
}
