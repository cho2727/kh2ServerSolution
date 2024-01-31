using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 사용자 정보
/// </summary>
public partial class User
{
    /// <summary>
    /// 사용자 ID
    /// </summary>
    public string UserId { get; set; } = null!;

    /// <summary>
    /// 사용자 권한 타입 ID
    /// </summary>
    public int UserAuthorityTypeFk { get; set; }

    /// <summary>
    /// 사용자명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 패스워드
    /// </summary>
    public string? Password { get; set; }

    /// <summary>
    /// 조직정보
    /// </summary>
    public string? Organization { get; set; }

    /// <summary>
    /// 이메일
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// 전화번호
    /// </summary>
    public string? MobileNo { get; set; }

    /// <summary>
    /// 지역 코드
    /// </summary>
    public long? MemberOfficeFk { get; set; }

    /// <summary>
    /// 삭제 여부
    /// </summary>
    public sbyte? DeleteFlag { get; set; }

    /// <summary>
    /// 알림여부:0,1
    /// </summary>
    public sbyte? IsNotify { get; set; }

    public virtual MemberOffice? MemberOfficeFkNavigation { get; set; }

    public virtual UserAuthorityType UserAuthorityTypeFkNavigation { get; set; } = null!;
}
