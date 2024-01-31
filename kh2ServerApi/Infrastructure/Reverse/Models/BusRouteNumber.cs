using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 버스노선번호
/// </summary>
public partial class BusRouteNumber
{
    /// <summary>
    /// 노선번호
    /// </summary>
    public int BrtId { get; set; }

    /// <summary>
    /// 노선번호확장
    /// </summary>
    public sbyte BrtClass { get; set; }

    /// <summary>
    /// 사용여부
    /// </summary>
    public sbyte? BrtUseYn { get; set; }
}
