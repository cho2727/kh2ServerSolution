﻿using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 아날로그 설정 표준 인덱스
/// </summary>
public partial class AoIndex
{
    /// <summary>
    /// 아날로그 설정 인덱스 ID
    /// </summary>
    public int IndexId { get; set; }

    /// <summary>
    /// 아날로그 설정 인덱스명
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 아날로그 설정 영문 인덱스명
    /// </summary>
    public string EName { get; set; } = null!;

    /// <summary>
    /// 알람 우선순위 ID
    /// </summary>
    public int? AlarmPriorityFk { get; set; }

    /// <summary>
    /// 데이터 타입 ID
    /// </summary>
    public int? DataTypeFk { get; set; }

    /// <summary>
    /// 상태 그룹 ID
    /// </summary>
    public int? StateGroupFk { get; set; }

    /// <summary>
    /// 스케일 펙터터 ID
    /// </summary>
    public int? ScaleFactorFk { get; set; }

    /// <summary>
    /// 단위 ID
    /// </summary>
    public int? UnitFk { get; set; }

    /// <summary>
    /// deadband 값
    /// </summary>
    public float? Deadband { get; set; }

    /// <summary>
    /// 최소 LIMIT 값
    /// </summary>
    public float? LimitMinValue { get; set; }

    /// <summary>
    /// 최대 LIMIT 값
    /// </summary>
    public float? LimitMaxValue { get; set; }

    /// <summary>
    /// alarm_type_fk
    /// </summary>
    public int? AlarmTypeFk { get; set; }

    public virtual AlarmPriority? AlarmPriorityFkNavigation { get; set; }

    public virtual DataType? DataTypeFkNavigation { get; set; }

    public virtual ScaleFactor? ScaleFactorFkNavigation { get; set; }

    public virtual StateGroup? StateGroupFkNavigation { get; set; }

    public virtual Unit? UnitFkNavigation { get; set; }
}
