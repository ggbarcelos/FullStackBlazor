using System.Text.Json.Serialization;

namespace Fina.Core.Responses;

public abstract class Response<TData>
{
    private int _code = Configuration.DefaultStatuCode;

    [JsonConstructor]
    public Response() 
        => _code = Configuration.DefaultStatuCode;
    
    public Response(TData? data, 
        int code = Configuration.DefaultStatuCode, 
        string? message = null)
    {
        Data = data;
        _code = code;
        Message = message;
    }
    public TData? Data { get; set; }
    public string? Message { get; set; }

    [JsonIgnore]
    public bool IsSucess => _code is >= 200 and <= 299;
}