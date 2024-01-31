using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// DVR 시스템
/// </summary>
public partial class DvrSystem
{
    /// <summary>
    /// DVR ID
    /// </summary>
    public int DvrId { get; set; }

    /// <summary>
    /// 스테이션 ID
    /// </summary>
    public long StationFk { get; set; }

    /// <summary>
    /// ODT 번호
    /// </summary>
    public int? OdtNo { get; set; }

    /// <summary>
    /// DVR 번호
    /// </summary>
    public string? DvrNo { get; set; }

    /// <summary>
    /// DVR IP
    /// </summary>
    public string? DvrIp { get; set; }

    /// <summary>
    /// DVR PORT
    /// </summary>
    public int? DvrPort { get; set; }

    /// <summary>
    /// 업데이트 시간
    /// </summary>
    public DateTime UpdateTime { get; set; }

    public virtual Substation StationFkNavigation { get; set; } = null!;
}
