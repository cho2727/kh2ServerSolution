using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

public partial class VRealMessageListView
{
    public int GroupId { get; set; }

    public int MsgType { get; set; }

    public string? MsgName { get; set; }

    public int MsgCount { get; set; }

    public string ServerCode { get; set; } = null!;
}
