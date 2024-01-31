using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

public partial class VDevicePointIndexView
{
    /// <summary>
    /// ceq_type_group_fk
    /// </summary>
    public int? CeqTypeGroupId { get; set; }

    public int CeqTypeId { get; set; }

    /// <summary>
    /// 설비 타입명
    /// </summary>
    public string CeqTypeName { get; set; } = null!;

    public int PointTypeId { get; set; }

    public int? PointIndex { get; set; }

    public long? DynamicIndex { get; set; }

    public string? Name { get; set; }

    public string? EName { get; set; }

    public int? CircuitNo { get; set; }

    public string? RemoteAddress { get; set; }

    public int? ClassNo { get; set; }

    public int? ModbusAddress { get; set; }

    public int? BitPosition { get; set; }

    public int? AlarmPriority { get; set; }

    public int? DataTypeId { get; set; }

    public int? StateGroupId { get; set; }

    /// <summary>
    /// 스케일 펙터 값
    /// </summary>
    public float Scale { get; set; }

    /// <summary>
    /// 스케일 펙터 OFFSET 값
    /// </summary>
    public float Offset { get; set; }

    public float? LimitMinValue { get; set; }

    public float? LimitMaxValue { get; set; }

    public int? UnitId { get; set; }

    /// <summary>
    /// 단위
    /// </summary>
    public string UnitName { get; set; } = null!;

    public int? AlarmTypeId { get; set; }

    public string? Description { get; set; }
}
