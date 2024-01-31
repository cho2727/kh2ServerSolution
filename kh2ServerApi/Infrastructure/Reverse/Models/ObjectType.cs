using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 개체 타입
/// </summary>
public partial class ObjectType
{
    /// <summary>
    /// 개체 타입 ID
    /// </summary>
    public int ObjectTypeId { get; set; }

    /// <summary>
    /// 개체 타입명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 타입 코드
    /// </summary>
    public string? TypeCode { get; set; }

    /// <summary>
    /// e_name
    /// </summary>
    public string? EName { get; set; }

    public virtual ICollection<ModelInfo> ModelInfos { get; set; } = new List<ModelInfo>();
}
