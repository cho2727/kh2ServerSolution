using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

public partial class VProgramInfoView
{
    /// <summary>
    /// 프로그램 ID
    /// </summary>
    public int ProgramId { get; set; }

    /// <summary>
    /// 프로그램명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 컴퓨터 ID
    /// </summary>
    public int? ComputerFk { get; set; }

    /// <summary>
    /// 컴퓨터명
    /// </summary>
    public string ComputerName { get; set; } = null!;

    /// <summary>
    /// 컴퓨터 그룹ID
    /// </summary>
    public int ComputerGroupFk { get; set; }

    /// <summary>
    /// 프로그램 타입 ID
    /// </summary>
    public int? ProgramTypeFk { get; set; }

    /// <summary>
    /// 프로그램번호
    /// </summary>
    public int? ProgramNo { get; set; }

    /// <summary>
    /// 실행타입(0:실행안함, 1:콘솔명령, 2:윈도우 서비스)
    /// </summary>
    public sbyte? ExecuteType { get; set; }

    /// <summary>
    /// 알람 우선순위 ID
    /// </summary>
    public int AlarmPriorityFk { get; set; }

    /// <summary>
    /// 상태 그룹 ID
    /// </summary>
    public int? StateGroupFk { get; set; }

    /// <summary>
    /// IP ADDR
    /// </summary>
    public string? IpAddr { get; set; }

    /// <summary>
    /// TCP PORT
    /// </summary>
    public int? TcpPort { get; set; }

    /// <summary>
    /// 시작 명령
    /// </summary>
    public string? StartCmd { get; set; }

    /// <summary>
    /// 종료 명령
    /// </summary>
    public string? StopCmd { get; set; }

    /// <summary>
    /// 프로그램 상태 갱신주기
    /// </summary>
    public int? UpdatePeriod { get; set; }

    /// <summary>
    /// 사용 여부
    /// </summary>
    public sbyte? UseFlag { get; set; }

    /// <summary>
    /// 파일이름(경로포함)
    /// </summary>
    public string? ProcFullName { get; set; }

    /// <summary>
    /// 프로그램 설명(버젼정보)
    /// </summary>
    public string? ProgramDesc { get; set; }

    public string? DpName { get; set; }

    public string DpType { get; set; } = null!;
}
