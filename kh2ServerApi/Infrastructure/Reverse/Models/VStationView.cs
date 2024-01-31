using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

public partial class VStationView
{
    /// <summary>
    /// 지역(사업소) 코드
    /// </summary>
    public long MemberOfficeId { get; set; }

    /// <summary>
    /// 지역(사업소) 명
    /// </summary>
    public string OfficeName { get; set; } = null!;

    /// <summary>
    /// 스테이션 ID
    /// </summary>
    public long StationId { get; set; }

    /// <summary>
    /// 개체명
    /// </summary>
    public string StationName { get; set; } = null!;

    /// <summary>
    /// 스테이션 타입
    /// </summary>
    public int? StationTypeId { get; set; }

    /// <summary>
    /// 연결 모델 ID
    /// </summary>
    public int? ModelId { get; set; }

    /// <summary>
    /// 모델명
    /// </summary>
    public string ModelName { get; set; } = null!;

    /// <summary>
    /// 스테이션명
    /// </summary>
    public string StationTypeName { get; set; } = null!;

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
}
