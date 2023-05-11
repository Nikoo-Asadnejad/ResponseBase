# ResponseBase
ResponseBase is a generic return type of a service or api which contains:

* Status
* Message
* Data

It can implicitly be converted to objectResult and httpStatusCodes,
and also httpStatusCodes and tuples can be implicitly converted to responseBase.



