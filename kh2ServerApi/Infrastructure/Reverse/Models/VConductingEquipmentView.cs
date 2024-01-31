using System;
using System.Collections.Generic;

namespace kh2ServerApi.Infrastructure.Reverse.Models;

public partial class VConductingEquipmentView
{
    /// <summary>
    /// 개체 ID
    /// </summary>
    public long CeqId { get; set; }

    /// <summary>
    /// 개체명
    /// </summary>
    public string CeqName { get; set; } = null!;

    /// <summary>
    /// 지역 코드 ID
    /// </summary>
    public long? OfficeCode { get; set; }

    /// <summary>
    /// 소속 스테이션 ID
    /// </summary>
    public long? StationMrfk { get; set; }

    /// <summary>
    /// 개체명
    /// </summary>
    public string StationName { get; set; } = null!;

    /// <summary>
    /// 타입 코드
    /// </summary>
    public string? StnTypeCode { get; set; }

    /// <summary>
    /// 개체 타입 ID
    /// </summary>
    public int ObjectType { get; set; }

    /// <summary>
    /// 개체 타입명
    /// </summary>
    public string ObjectTypeName { get; set; } = null!;

    /// <summary>
    /// e_name
    /// </summary>
    public string? ObjectTypeEname { get; set; }

    /// <summary>
    /// 타입 코드
    /// </summary>
    public string? TypeCode { get; set; }

    /// <summary>
    /// 연결 모델 ID
    /// </summary>
    public int? ModelId { get; set; }

    /// <summary>
    /// 모델명
    /// </summary>
    public string ModelName { get; set; } = null!;

    /// <summary>
    /// ceq_type_group_fk
    /// </summary>
    public int? CeqTypeGroupId { get; set; }

    /// <summary>
    /// 설비 타입 ID
    /// </summary>
    public int? CeqTypeFk { get; set; }

    /// <summary>
    /// 통신기기ID
    /// </summary>
    public int? DeviceFk { get; set; }

    /// <summary>
    /// 회로번호
    /// </summary>
    public sbyte? CircuitNo { get; set; }

    /// <summary>
    /// 별칭
    /// </summary>
    public string? CeqAliasName { get; set; }

    public string? DpName { get; set; }

    /// <summary>
    /// 설비 영문 타입명
    /// </summary>
    public string DpType { get; set; } = null!;
}
