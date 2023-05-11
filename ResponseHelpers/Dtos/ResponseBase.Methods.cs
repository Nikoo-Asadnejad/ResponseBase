using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace ResponseBase.Dtos;

public partial struct ResponseBase<T>
{
    public ResponseBase<T> Ok(T data, string message = null)
    {
        this.Data = data;
        this.StatusCode = HttpStatusCode.OK;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.Ok : message;
        return this;
    }
    public ResponseBase<T> Created(T data, string message = null)
    {
        this.Data = data;
        this.StatusCode = HttpStatusCode.Created;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.Created : message;
        return this;
    }
    public ResponseBase<T> Accepted(T data, string message = null)
    {
        this.Data = data;
        this.StatusCode = HttpStatusCode.Accepted;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.Accepted : message;
        return this;
    }
    public ResponseBase<T> BadRequest(string message = null)
    {
        this.StatusCode = HttpStatusCode.BadRequest;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.BadRequest : message;
        return this;
    }
    public ResponseBase<T> Duplicated(string message = null)
    {
        this.StatusCode = HttpStatusCode.BadRequest;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.Duplicated : message;
        return this;
    }
    public ResponseBase<T> UnAuthorized(string message = null)
    {
        this.StatusCode = HttpStatusCode.Unauthorized;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.UnAuthorized : message;
        return this;
    }
    public ResponseBase<T> Forbidden(string message = null)
    {
        this.StatusCode = HttpStatusCode.Forbidden;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.Forbidden : message;
        return this;
    }
    public ResponseBase<T> NotFound(string message = null)
    {
        this.StatusCode = HttpStatusCode.NotFound;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.NotFound : message;
        return this;
    }
    public ResponseBase<T> MethodNotAllowed(string message = null)
    {
        this.StatusCode = HttpStatusCode.MethodNotAllowed;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.MethodNotAllowed : message;
        return this;
    }
    public ResponseBase<T> NotAccepted(string message = null)
    {
        this.StatusCode = HttpStatusCode.NotAcceptable;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.NotAccepted : message;
        return this;
    }
    public ResponseBase<T> UnSupportedMediaType(string message = null)
    {
        this.StatusCode = HttpStatusCode.UnsupportedMediaType;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.UnSupportedMediaType : message;
        return this;
    }
    public ResponseBase<T> Conflict(string message = null)
    {
        this.StatusCode = HttpStatusCode.Conflict;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.Conflict : message;
        return this;
    }
    public ResponseBase<T> PaymentRequired(string message = null)
    {
        this.StatusCode = HttpStatusCode.PaymentRequired;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.PaymentRequired : message;
        return this;
    }
    public ResponseBase<T> TooManyRequest(string message = null)
    {
        this.StatusCode = HttpStatusCode.TooManyRequests;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.TooManyRequest : message;
        return this;
    }
    public ResponseBase<T> ServerError(string message = null)
    {
        this.StatusCode = HttpStatusCode.InternalServerError;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.InternalServerError : message;
        return this;
    }
    public ResponseBase<T> ServiceUnAvailable(string message = null)
    {
        this.StatusCode = HttpStatusCode.ServiceUnavailable;
        this.Message = string.IsNullOrWhiteSpace(message) ? ResponseMessages.ServiceUnAvailable : message;
        return this;
    }
}

