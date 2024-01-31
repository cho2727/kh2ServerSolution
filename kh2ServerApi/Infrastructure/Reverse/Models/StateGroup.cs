using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 상태 그룹 정보
/// </summary>
public partial class StateGroup
{
    /// <summary>
    /// 상태 그룹 ID
    /// </summary>
    public int StateGroupId { get; set; }

    /// <summary>
    /// 상태 그룹명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 상태 개수
    /// </summary>
    public int? Count { get; set; }

    public virtual ICollection<AiIndex> AiIndices { get; set; } = new List<AiIndex>();

    public virtual ICollection<AoIndex> AoIndices { get; set; } = new List<AoIndex>();

    public virtual ICollection<BiIndex> BiIndices { get; set; } = new List<BiIndex>();

    public virtual ICollection<CalculationIndex> CalculationIndices { get; set; } = new List<CalculationIndex>();

    public virtual ICollection<ComputerInfo> ComputerInfos { get; set; } = new List<ComputerInfo>();

    public virtual ICollection<CounterIndex> CounterIndices { get; set; } = new List<CounterIndex>();

    public virtual ICollection<MasterIndex> MasterIndices { get; set; } = new List<MasterIndex>();

    public virtual ICollection<ProgramInfo> ProgramInfos { get; set; } = new List<ProgramInfo>();

    public virtual ICollection<SnmpInfo> SnmpInfos { get; set; } = new List<SnmpInfo>();

    public virtual ICollection<StateValue> StateValues { get; set; } = new List<StateValue>();
}
