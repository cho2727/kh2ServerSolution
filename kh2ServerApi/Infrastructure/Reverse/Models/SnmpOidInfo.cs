using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// OID 정보
/// </summary>
public partial class SnmpOidInfo
{
    /// <summary>
    /// OS 타입
    /// </summary>
    public int OsType { get; set; }

    /// <summary>
    /// OID 아이디
    /// </summary>
    public int? OidId { get; set; }

    /// <summary>
    /// OID 인덱스
    /// </summary>
    public int? OidIndex { get; set; }

    /// <summary>
    /// OID 정보
    /// </summary>
    public string? OidValue { get; set; }

    /// <summary>
    /// OID 설명
    /// </summary>
    public string? OidDesc { get; set; }

    public virtual SnmpOsType OsTypeNavigation { get; set; } = null!;
}
