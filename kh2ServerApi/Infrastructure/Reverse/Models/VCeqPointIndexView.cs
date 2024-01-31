using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

public partial class VCeqPointIndexView
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

    /// <summary>
    /// 설비 영문 타입명
    /// </summary>
    public string CeqTypeEname { get; set; } = null!;

    /// <summary>
    /// 모델 ID
    /// </summary>
    public int ModelId { get; set; }

    public int PointTypeId { get; set; }

    public long? DynamicIndex { get; set; }

    public string? Name { get; set; }

    public string EName { get; set; } = null!;

    public string? DtStr { get; set; }

    public int? AlarmPriority { get; set; }

    public int? DataTypeId { get; set; }

    public int? StateGroupId { get; set; }

    public double? LimitMinValue { get; set; }

    public double? LimitMaxValue { get; set; }

    public int? UnitId { get; set; }

    /// <summary>
    /// 단위
    /// </summary>
    public string? UnitName { get; set; }

    public int? AlarmTypeId { get; set; }
}
