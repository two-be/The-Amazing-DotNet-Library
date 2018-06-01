using System;
using Softveloper.Net.Mail;
using Xunit;

namespace Softveloper.Test
{
	public class MailClientTest
	{
		[Fact]
		public void Send() {
			var address = "Testset.Developer@gmail.com";
			var client = new MailClient("smtp.gmail.com", 587, address, "Pa$$w0rd;");
			client.Address = address;
			client.Body = "Body";
			client.DisplayName = "Test Tset";
			client.EnableSsl = true;
			client.Subject = "Subject";
			client.To.Add(address);
			client.Send();
		}
	}
}
