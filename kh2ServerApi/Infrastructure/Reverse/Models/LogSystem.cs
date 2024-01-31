using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 시스템 로그
/// </summary>
public partial class LogSystem
{
    /// <summary>
    /// 로그ID
    /// </summary>
    public long LogId { get; set; }

    /// <summary>
    /// 메시지 타입 ID
    /// </summary>
    public int MsgTypeId { get; set; }

    /// <summary>
    /// 요청 프로그램 이름
    /// </summary>
    public string? ReqProcName { get; set; }

    /// <summary>
    /// 응답(수행) 프로그램 이름
    /// </summary>
    public string? ResProcName { get; set; }

    /// <summary>
    /// 요청 시간
    /// </summary>
    public string? ReqTime { get; set; }

    /// <summary>
    /// 응답시간
    /// </summary>
    public string? ResTime { get; set; }

    /// <summary>
    /// 결과코드
    /// </summary>
    public string? ResultCode { get; set; }

    /// <summary>
    /// 결과 메시지
    /// </summary>
    public string? ResultMessage { get; set; }

    /// <summary>
    /// 업데이트 시간(저장시간)
    /// </summary>
    public DateTime UpdateTime { get; set; }
}
