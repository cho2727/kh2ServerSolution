using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// CEQ 타입 그룹
/// </summary>
public partial class CeqTypeGroup
{
    /// <summary>
    /// 설비 타입 ID
    /// </summary>
    public int CeqTypeGroupId { get; set; }

    /// <summary>
    /// 설비 타입명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 설비 영문 타입명
    /// </summary>
    public string EName { get; set; } = null!;

    public virtual ICollection<CeqType> CeqTypes { get; set; } = new List<CeqType>();

    public virtual ICollection<DeviceCommUnit> DeviceCommUnits { get; set; } = new List<DeviceCommUnit>();

    public virtual ICollection<ModbusSchedule> ModbusSchedules { get; set; } = new List<ModbusSchedule>();
}
