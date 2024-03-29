﻿using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 레포트 폼 타입
/// </summary>
public partial class ReportFormType
{
    /// <summary>
    /// 레포트 폼 타입 ID
    /// </summary>
    public int FormTypeId { get; set; }

    /// <summary>
    /// 레포트 폼 타입명
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ICollection<ReportForm> ReportForms { get; set; } = new List<ReportForm>();
}
