using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// POS 시스템
/// </summary>
public partial class PosSystem
{
    /// <summary>
    /// POSID
    /// </summary>
    public int PosId { get; set; }

    /// <summary>
    /// 스테이션 ID
    /// </summary>
    public long? StationFk { get; set; }

    /// <summary>
    /// ODT 번호
    /// </summary>
    public int? OdtNo { get; set; }

    public virtual ICollection<PosEquipmentLink> PosEquipmentLinks { get; set; } = new List<PosEquipmentLink>();

    public virtual Substation? StationFkNavigation { get; set; }
}
