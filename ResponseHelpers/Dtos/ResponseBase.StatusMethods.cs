using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace ResponseBase.Dtos;

public partial struct ResponseBase<T>
{
    public bool IsSuccessfull()
        => (int)this.StatusCode >= 200 && (int)this.StatusCode < 300;

    public bool IsError()
        => (int)this.StatusCode >= 400 && (int)this.StatusCode < 500;

    public bool IsServerError()
        => (int)this.StatusCode >= 500 && (int)this.StatusCode < 600;
    
    public bool IsNotSuccessfull()
        => !IsSuccessfull();
}

