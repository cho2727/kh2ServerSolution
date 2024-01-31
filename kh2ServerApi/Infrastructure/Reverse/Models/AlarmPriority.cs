using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 알람 우선순위
/// </summary>
public partial class AlarmPriority
{
    /// <summary>
    /// 알람 우선순위 ID
    /// </summary>
    public int AlarmPriorityId { get; set; }

    /// <summary>
    /// 알람 우선순위명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 소리 ID
    /// </summary>
    public int? SoundFk { get; set; }

    public virtual ICollection<AiIndex> AiIndices { get; set; } = new List<AiIndex>();

    public virtual ICollection<AoIndex> AoIndices { get; set; } = new List<AoIndex>();

    public virtual ICollection<BiIndex> BiIndices { get; set; } = new List<BiIndex>();

    public virtual ICollection<CalculationIndex> CalculationIndices { get; set; } = new List<CalculationIndex>();

    public virtual ICollection<ComputerInfo> ComputerInfos { get; set; } = new List<ComputerInfo>();

    public virtual ICollection<CounterIndex> CounterIndices { get; set; } = new List<CounterIndex>();

    public virtual ICollection<MasterIndex> MasterIndices { get; set; } = new List<MasterIndex>();

    public virtual ICollection<ProgramInfo> ProgramInfos { get; set; } = new List<ProgramInfo>();

    public virtual ICollection<SnmpInfo> SnmpInfos { get; set; } = new List<SnmpInfo>();
}
