```c#
using Softveloper.IO;

// Create directory
Filerectory.CreateDirectory("./DirectoryName");

// Delete file
Filerectory.DeleteFile("./FileName");
```

```c#
using Softveloper.Extensions;

// SHA512
var password = "Password";
var sha512 = password.ToSha512();
```