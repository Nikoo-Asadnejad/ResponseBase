namespace ResponseBase.Dtos;

public struct ResponseMessages
{
    public const string Ok = "عملیات با موفقعیت انجام شد";
    public const string Created = "عملیات با موفقعیت انجام شد";
    public const string Accepted = "عملیات با موفقعیت انجام شد";
    
    public const string BadRequest = "داده ورودی اشتباه است";
    public const string UnAuthorized = "لطفا ابتدا وارد شودید";
    public const string Forbidden = "دسترسی لازم برای این درخواست را ندارید";
    public const string NotFound = "دیتای مورد نظر یافت نشد";
    public const string MethodNotAllowed = "";
    public const string NotAccepted = "درخواست قابل بررسی نمی باشد";
    public const string UnSupportedMediaType = "درخواست قابل بررسی نمی باشد";
    public const string RequestTimedOut = "پردازش درخواست بیش از حد مجاز به طول انجامید";
    public const string Conflict = "دادخ وروردی باعث ایجاد خطا می شود";
    public const string PaymentRequired = "پرداخت اجباری است";
    public const string TooManyRequest = "تعداد درخواست بیشتر از حد مجاز است لطفا بعدا تلاش کنید";
    
    public const string InternalServerError = "خطای سرور";
    public const string ServiceUnAvailable = "سرور در دسترس نیست";

    public const string Error = "خطایی رخ داده است";
    public static string ErrorOnAction(string action) => $" با خطا مواجه شد {action} ";
    public static string SucessOnAction(string action) => $" با موافقیت انجام شد {action} ";

}