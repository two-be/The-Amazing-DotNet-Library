```c#
using Softveloper.IO;

// Create directory
Filerectory.CreateDirectory("./DirectoryName");

// Delete file
Filerectory.DeleteFile("./FileName");
```

```c#
using Softveloper.Extensions;

// HttpRequest Get String Value
var request = Request; //HttpRequest
var value = request.GetStringValue("key");

// SHA512
var password = "Password";
var sha512 = password.ToSha512();
```