using System.Net;

namespace ResponseBase.Dtos;

public class ResponseBase<T>
{
    public HttpStatusCode HttpStatusCode { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
    
    public ResponseBase()
    {
    }

    public ResponseBase(
      HttpStatusCode statusCode,
      T data = default,
      string? message = null)
    {
      this.Data = data;
      this.HttpStatusCode = statusCode;
      this.Message = message;
    }

    public ResponseBase<T> Ok(T data, string title = null, string message = null)
    {
      this.Data = data;
      this.HttpStatusCode = HttpStatusCode.OK;
      this.Message = message == null ? "عملیات با موفقعیت انجام شد" : message;
      return this;
    }
    public ResponseBase<T> Accepted(T data, string title = null, string message = null)
    {
      this.Data = data;
      this.HttpStatusCode = HttpStatusCode.OK;
      this.Message = message == null ? "عملیات با موفقعیت انجام شد" : message;
      return this;
    }
    public ResponseBase<T> Created(T data, string title = null, string message = null)
    {
      this.Data = data;
      this.HttpStatusCode = HttpStatusCode.OK;
      this.Message = message == null ? "عملیات با موفقعیت انجام شد" : message;
      return this;
    }
    
    public ResponseBase<T> BadRequest(string title = null, string message = null)
    {
      this.HttpStatusCode = HttpStatusCode.BadRequest;
      this.Message = message == null ? "خطای سرور" : message;
      return this;
    }
    public ResponseBase<T> Duplicated(string title = null, string message = null)
    {
      this.HttpStatusCode = HttpStatusCode.BadRequest;
      this.Message = message == null ? "داده ورودی تکراری است" : message;
      return this;
    }
    public ResponseBase<T> UnAuthorized (string title = null, string message = null)
    {
      this.HttpStatusCode = HttpStatusCode.Unauthorized;
      this.Message = message == null ? "برای دسترسی به این بخش باید ابتدا وارد سیستم شوید" : message;
      return this;
    }
    public ResponseBase<T> AccessDenied(string title = null, string message = null)
    {
      this.HttpStatusCode = HttpStatusCode.Forbidden;
      this.Message = message == null ? "برای دسترسی به این بخش باید ابتدا وارد سیستم شوید" : message;
      return this;
    }
    public ResponseBase<T> NotFound(string title = null, string message = null)
    {
      this.HttpStatusCode = HttpStatusCode.NotFound;
      this.Message = message == null ? "دیتای مورد نظر یافت نشد" : message;
      return this;
    }

  
    public ResponseBase<T> ServerError(string title = null, string message = null)
    {
      this.HttpStatusCode = HttpStatusCode.InternalServerError;
      this.Message = message == null ? "خطای سرور" : message;
      return this;
    }
    

   

    
  }
