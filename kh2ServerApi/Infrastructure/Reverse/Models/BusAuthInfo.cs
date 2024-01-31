using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 버스 API 인증키
/// </summary>
public partial class BusAuthInfo
{
    /// <summary>
    /// 인증ID
    /// </summary>
    public int AuthId { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 인증키
    /// </summary>
    public string AuthKey { get; set; } = null!;

    /// <summary>
    /// kakao_key
    /// </summary>
    public string? KakaoKey { get; set; }
}
