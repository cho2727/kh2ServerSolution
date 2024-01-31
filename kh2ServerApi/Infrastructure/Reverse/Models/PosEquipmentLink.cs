using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// POS 설비 연결
/// </summary>
public partial class PosEquipmentLink
{
    /// <summary>
    /// 로그인덱스
    /// </summary>
    public long Idx { get; set; }

    /// <summary>
    /// POSID
    /// </summary>
    public int PosFk { get; set; }

    /// <summary>
    /// 개체 ID
    /// </summary>
    public long CeqFk { get; set; }

    public virtual ConductingEquipment CeqFkNavigation { get; set; } = null!;

    public virtual PosSystem PosFkNavigation { get; set; } = null!;
}
