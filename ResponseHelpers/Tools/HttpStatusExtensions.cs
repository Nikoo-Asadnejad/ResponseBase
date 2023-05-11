using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ResponseHelper.Tools;
public static class HttpStatusExtensions
{
  public static bool IsSuccessfulll(this HttpStatusCode httpStatusCode)
  => (int)httpStatusCode >= 200 && (int)httpStatusCode < 300;
  public static bool IsRedirected(this HttpStatusCode httpStatusCode)
  => (int)httpStatusCode >= 300 && (int)httpStatusCode < 400;
  public static bool IsError(this HttpStatusCode httpStatusCode)
  => (int) httpStatusCode >= 400 && (int) httpStatusCode < 500;
  public static bool IsServerError(this HttpStatusCode httpStatusCode)
  => (int)httpStatusCode >= 500 && (int)httpStatusCode < 600;
  public static bool IsUnAuthorized(this HttpStatusCode httpStatusCode)
      => (int)httpStatusCode is 401 || (int)httpStatusCode is 403;

  public static bool IsSuccessfulll(this int httpStatusCode)
 => httpStatusCode >= 200 && httpStatusCode < 300;
  public static bool IsRedirected(this int httpStatusCode)
  => httpStatusCode >= 300 && httpStatusCode < 400;
  public static bool IsError(this int httpStatusCode)
  => httpStatusCode >= 400 && httpStatusCode < 500;
  public static bool IsServerError(this int httpStatusCode)
  => httpStatusCode >= 500 && httpStatusCode < 600;
  public static bool IsUnAuthorized(this int httpStatusCode)
      => httpStatusCode is 401 || httpStatusCode is 403;
}

