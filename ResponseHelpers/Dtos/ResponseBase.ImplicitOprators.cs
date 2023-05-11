using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace ResponseBase.Dtos;

public partial struct ResponseBase<T>
{
    
    public static implicit operator ObjectResult(ResponseBase<T> response)
        => new ObjectResult(response)
        {
            StatusCode = (int)response.StatusCode
        };

    public static implicit operator ResponseBase<T>(ObjectResult objectResult)
        => new ResponseBase<T>
        {
            StatusCode = (HttpStatusCode)objectResult.StatusCode,
            Message = ResponseMessages.GetStatusMessage((HttpStatusCode)objectResult.StatusCode),
            Data = (T)objectResult.Value
        };

    public static explicit operator T(ResponseBase<T> response)
        => (T)response.Data;

    public static implicit operator ResponseBase<T>(HttpStatusCode statusCode)
        => new ResponseBase<T>()
        {
            StatusCode = statusCode,
            Message = ResponseMessages.GetStatusMessage(statusCode)
        };

    public static implicit operator ResponseBase<T>((HttpStatusCode statusCode, string message) tuple)
        => new ResponseBase<T>()
        {
            StatusCode = tuple.statusCode,
            Message = tuple.message
        };

    public static implicit operator ResponseBase<T>((HttpStatusCode statusCode, T data) tuple)
        => new ResponseBase<T>()
        {
            StatusCode = tuple.statusCode,
            Message = ResponseMessages.GetStatusMessage(tuple.statusCode),
            Data = tuple.data
        };

    public static implicit operator ResponseBase<T>((HttpStatusCode statusCode, T data, string message) tuple)
        => new ResponseBase<T>()
        {
            StatusCode = tuple.statusCode,
            Message = tuple.message,
            Data = tuple.data
        };
}

