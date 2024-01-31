using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 설비 정보
/// </summary>
public partial class ConductingEquipment
{
    /// <summary>
    /// 개체 ID
    /// </summary>
    public long Mrid { get; set; }

    /// <summary>
    /// 통신기기ID
    /// </summary>
    public int? DeviceFk { get; set; }

    /// <summary>
    /// 소속 스테이션 ID
    /// </summary>
    public long? StationMrfk { get; set; }

    /// <summary>
    /// 회로번호
    /// </summary>
    public sbyte? CircuitNo { get; set; }

    public virtual ICollection<CeqProperty> CeqProperties { get; set; } = new List<CeqProperty>();

    public virtual DeviceCommUnit? DeviceFkNavigation { get; set; }

    public virtual IdentityObject Mr { get; set; } = null!;

    public virtual ICollection<PosEquipmentLink> PosEquipmentLinks { get; set; } = new List<PosEquipmentLink>();

    public virtual Substation? StationMrfkNavigation { get; set; }
}
