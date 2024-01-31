using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 스테이션 정보
/// </summary>
public partial class Substation
{
    /// <summary>
    /// 스테이션 ID
    /// </summary>
    public long StationMrfk { get; set; }

    /// <summary>
    /// 스테이션 코드
    /// </summary>
    public string? StationCode { get; set; }

    /// <summary>
    /// 지역 코드 ID
    /// </summary>
    public long? MemberOfficeFk { get; set; }

    /// <summary>
    /// 스테이션 타입
    /// </summary>
    public int? StationTypeFk { get; set; }

    /// <summary>
    /// 스테이션 주소
    /// </summary>
    public string? StationAdder { get; set; }

    /// <summary>
    /// 설치일자
    /// </summary>
    public string? InstallDate { get; set; }

    /// <summary>
    /// 사업자코드
    /// </summary>
    public string? BsensCode { get; set; }

    /// <summary>
    /// 전화번호
    /// </summary>
    public string? PhoneNo { get; set; }

    public virtual ICollection<ConductingEquipment> ConductingEquipments { get; set; } = new List<ConductingEquipment>();

    public virtual ICollection<DvrSystem> DvrSystems { get; set; } = new List<DvrSystem>();

    public virtual MemberOffice? MemberOfficeFkNavigation { get; set; }

    public virtual ICollection<PosSystem> PosSystems { get; set; } = new List<PosSystem>();

    public virtual StationType? StationTypeFkNavigation { get; set; }
}
