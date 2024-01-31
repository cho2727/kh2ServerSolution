namespace kh2ServerApi.Shard;

public /*abstract*/ class BaseResponse
{
    public bool Result { get; set; }
    public Error? Error { get; set; }// = new Error { Code = "00", Message = "정상처리" };
}

public class Error
{
    public string Code { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}

public class BasePosResponse
{
    public string Comm_Code { get; set; } = string.Empty;       // 통신코드
    public string Res_Code { get; set; } = "000";       // 응답코드
}
