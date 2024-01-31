using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 버스타고도시코드
/// </summary>
public partial class BusTagoCityCode
{
    /// <summary>
    /// 도시코드
    /// </summary>
    public int CityCode { get; set; }

    /// <summary>
    /// 도시이름
    /// </summary>
    public string CityName { get; set; } = null!;

    /// <summary>
    /// 사용여부
    /// </summary>
    public sbyte? UseYn { get; set; }

    public virtual ICollection<BusTagoRouteInfo> BusTagoRouteInfos { get; set; } = new List<BusTagoRouteInfo>();
}
