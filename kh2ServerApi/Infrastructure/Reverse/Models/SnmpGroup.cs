using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// SNMP 그룹
/// </summary>
public partial class SnmpGroup
{
    /// <summary>
    /// snmp 그룹 아이디
    /// </summary>
    public int SnmpGroupId { get; set; }

    /// <summary>
    /// snmp 그룹 이름
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ICollection<SnmpInfo> SnmpInfos { get; set; } = new List<SnmpInfo>();
}
