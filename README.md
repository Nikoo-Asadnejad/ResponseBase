# ResponseBase
ResponseBase is a generic return type of a service or api which contains:

* Status
* Message
* Data

It can implicitly be converted to objectResult and httpStatusCodes,
and also httpStatusCodes and tuples can be implicitly converted to responseBase.

* It's better to avoid creating a new instance of it, just return a tuple or status code in services.


