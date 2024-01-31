namespace kh2ServerApi.Shard;
public class StationModel
{
    public long OfficeId { get; set; }

    public string OfficeName { get; set; } = null!;

    public long StationId { get; set; }

    public string StationName { get; set; } = null!;

    public int? StationTypeId { get; set; }

    public string StationTypeName { get; set; } = null!;
    public int? ModelId { get; set; }

    public string ModelName { get; set; } = null!;

    public string? StationAdder { get; set; }
    public string? InstallDate { get; set; }
    public string? BsensCode { get; set; }
    public string? PhoneNumber { get; set; }
}


public class StationResponseModel : BaseResponse
{
    public List<StationModel>? Datas { get; set; }
}