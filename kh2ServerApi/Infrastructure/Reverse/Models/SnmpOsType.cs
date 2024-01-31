using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 운영체제 타입
/// </summary>
public partial class SnmpOsType
{
    /// <summary>
    /// OS 타입
    /// </summary>
    public int OsType { get; set; }

    /// <summary>
    /// OS 이름
    /// </summary>
    public string? OsName { get; set; }

    public virtual ICollection<SnmpInfo> SnmpInfos { get; set; } = new List<SnmpInfo>();
}
