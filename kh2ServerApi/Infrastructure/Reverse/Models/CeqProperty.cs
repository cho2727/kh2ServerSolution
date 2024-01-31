using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 설비(CEQ)별 속성
/// </summary>
public partial class CeqProperty
{
    /// <summary>
    /// 개체 ID
    /// </summary>
    public long CeqId { get; set; }

    /// <summary>
    /// 모델 아이템 ID
    /// </summary>
    public int ItemFk { get; set; }

    /// <summary>
    /// 표시 순서
    /// </summary>
    public int Seq { get; set; }

    /// <summary>
    /// 값
    /// </summary>
    public string? Value { get; set; }

    public virtual ConductingEquipment Ceq { get; set; } = null!;

    public virtual ModelItemIndex ItemFkNavigation { get; set; } = null!;
}
