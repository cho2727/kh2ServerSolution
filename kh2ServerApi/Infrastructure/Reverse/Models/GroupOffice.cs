using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 그룹 사업소
/// </summary>
public partial class GroupOffice
{
    /// <summary>
    /// 그룹사업소 ID
    /// </summary>
    public int GroupOfficeId { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ICollection<MemberOffice> MemberOffices { get; set; } = new List<MemberOffice>();
}
