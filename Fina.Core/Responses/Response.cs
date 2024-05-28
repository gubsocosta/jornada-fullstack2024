using System.Text.Json.Serialization;

namespace Fina.Core.Responses;

public class Response<TData>
{
    private int _code = Configuration.DefaultHttpStatusCode;
    public string? Message { get; set; }
    public TData? Data { get; set; }
    
    [JsonIgnore]
    public bool IsSuccess => _code is >= 200 and <= 299;

    [JsonConstructor]
    public Response() => _code = Configuration.DefaultHttpStatusCode;

    public Response(
        TData? data,
        int code = Configuration.DefaultHttpStatusCode,
        string? message = null
    )
    {
        Data = data;
        _code = code;
        Message = message;
    }
}
