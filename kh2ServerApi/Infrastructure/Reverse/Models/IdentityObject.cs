using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 개체 식별 정보
/// </summary>
public partial class IdentityObject
{
    /// <summary>
    /// 개체 ID
    /// </summary>
    public long Mrid { get; set; }

    /// <summary>
    /// 개체명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 연결 모델 ID
    /// </summary>
    public int? ModelFk { get; set; }

    /// <summary>
    /// 별칭
    /// </summary>
    public string? AliasName { get; set; }

    public virtual ConductingEquipment? ConductingEquipment { get; set; }

    public virtual ModelInfo? ModelFkNavigation { get; set; }
}
