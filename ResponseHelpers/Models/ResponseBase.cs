using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace ResponseBase.Dtos;

public partial struct ResponseBase<T>
{
    public HttpStatusCode StatusCode { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }

    public ResponseBase()
    {
            
    }
    public ResponseBase(HttpStatusCode statusCode, T data, string message)
    {
        this.Data = data;
        this.StatusCode = statusCode;
        this.Message = message;
    }
    public ResponseBase(HttpStatusCode statusCode, string message)
    {
        this.StatusCode = statusCode;
        this.Message = message;
    }
    public ResponseBase(HttpStatusCode statusCode, T data)
    {
        this.StatusCode = StatusCode;
        this.Message = ResponseMessages.GetStatusMessage(statusCode);
        this.Data = data;
    }
    public ResponseBase(HttpStatusCode statusCode)
    {
        this.StatusCode = StatusCode;
        this.Message = ResponseMessages.GetStatusMessage(statusCode);
    }

}

