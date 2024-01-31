using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 설비 타입
/// </summary>
public partial class CeqType
{
    /// <summary>
    /// 설비 타입 ID
    /// </summary>
    public int CeqTypeId { get; set; }

    /// <summary>
    /// 설비 타입명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 설비 영문 타입명
    /// </summary>
    public string EName { get; set; } = null!;

    /// <summary>
    /// 프로토콜 ID
    /// </summary>
    public int? ProtocolTypeFk { get; set; }

    /// <summary>
    /// ceq_type_group_fk
    /// </summary>
    public int? CeqTypeGroupFk { get; set; }

    public virtual ICollection<CalculationIndex> CalculationIndices { get; set; } = new List<CalculationIndex>();

    public virtual CeqTypeGroup? CeqTypeGroupFkNavigation { get; set; }

    public virtual ICollection<MasterIndex> MasterIndices { get; set; } = new List<MasterIndex>();

    public virtual ICollection<ModelInfo> ModelInfos { get; set; } = new List<ModelInfo>();

    public virtual ProtocolType? ProtocolTypeFkNavigation { get; set; }
}
