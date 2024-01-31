using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 스테이션(변전소) 타입
/// </summary>
public partial class StationType
{
    /// <summary>
    /// 스테이션 타입 ID
    /// </summary>
    public int StationTypeId { get; set; }

    /// <summary>
    /// 스테이션명
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ICollection<Substation> Substations { get; set; } = new List<Substation>();
}
