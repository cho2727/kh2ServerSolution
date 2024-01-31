using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 지역(사업소) 정보
/// </summary>
public partial class MemberOffice
{
    /// <summary>
    /// 지역(사업소) 코드
    /// </summary>
    public long MemberOfficeId { get; set; }

    /// <summary>
    /// 그룹사업소 ID
    /// </summary>
    public int GroupOfficeFk { get; set; }

    /// <summary>
    /// 지역(사업소) 명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 지역(사업소) 타입
    /// </summary>
    public sbyte? OfficeType { get; set; }

    public virtual ICollection<BusTagoVehicle> BusTagoVehicles { get; set; } = new List<BusTagoVehicle>();

    public virtual ICollection<ComputerInfo> ComputerInfos { get; set; } = new List<ComputerInfo>();

    public virtual GroupOffice GroupOfficeFkNavigation { get; set; } = null!;

    public virtual ICollection<SnmpInfo> SnmpInfos { get; set; } = new List<SnmpInfo>();

    public virtual ICollection<Substation> Substations { get; set; } = new List<Substation>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
