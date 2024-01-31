using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

/// <summary>
/// 디바이스 시나리오 타입
/// </summary>
public partial class DeviceScenarioType
{
    /// <summary>
    /// 시나리오타입ID
    /// </summary>
    public int ScenarioTypeId { get; set; }

    /// <summary>
    /// 시나리오타입이름
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 설명
    /// </summary>
    public string? Description { get; set; }
}
