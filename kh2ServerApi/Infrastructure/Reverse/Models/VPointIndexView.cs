using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

public partial class VPointIndexView
{
    public int PointTypeId { get; set; }

    public long DynamicIndex { get; set; }

    public string? Name { get; set; }

    public string EName { get; set; } = null!;

    public int? AlarmPriorityId { get; set; }

    public int? DataTypeId { get; set; }

    public int? StateGroupId { get; set; }

    public double? LimitMinValue { get; set; }

    public double? LimitMaxValue { get; set; }

    public int? UnitId { get; set; }

    public int? AlarmTypeFk { get; set; }
}
