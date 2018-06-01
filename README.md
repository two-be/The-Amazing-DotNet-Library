```c#
using Softveloper.Extensions;

// HttpRequest Get String Value
var request = Request; //HttpRequest
var value = request.GetStringValue("key");

// SHA512
var password = "Password";
var sha512 = password.ToSha512();
```

```c#
using Softveloper.IO;

// Create directory
Filerectory.CreateDirectory("./DirectoryName");

// Delete file
Filerectory.DeleteFile("./FileName");

// Write All Bytes
var bytes = new byte[2];
Filerectory.WriteAllBytes("./FileName", bytes);

// Write All Text
Filerectory.WriteAllText("./FileName", "Contents");
```

```c#
using Softveloper.Net

// Get IPv4 Address
HostInfo.GetIpv4();

// Get IPv4 Address with spectific HostName
HostInfo.GetIpv4("HostName");
```

```c#
using Softveloper.Net.Mail

// Send an Email
var client = new MailClient("Host", 25, "Username", "Password");
client.Address = "FromAddress";
client.Body = "Body";
client.Cc.Add("CcAddress");
client.DisplayName = "DisplayName";
client.EnableSsl = true;
client.Subject = "Subject";
client.To.Add("ToAddress");
client.Send();
```