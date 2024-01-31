using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 버스타고 차량 목록
/// </summary>
public partial class BusTagoVehicle
{
    /// <summary>
    /// 차량번호
    /// </summary>
    public int VehicleNo { get; set; }

    /// <summary>
    /// 지역(사업소) 코드
    /// </summary>
    public long MemberOfficeFk { get; set; }

    /// <summary>
    /// 연료탱크용량
    /// </summary>
    public int FuelTankCapacity { get; set; }

    /// <summary>
    /// 생성시간
    /// </summary>
    public DateTime? CreateTime { get; set; }

    public virtual MemberOffice MemberOfficeFkNavigation { get; set; } = null!;
}
