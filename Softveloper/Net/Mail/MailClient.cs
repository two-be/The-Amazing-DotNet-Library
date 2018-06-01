using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Softveloper.Net.Mail
{
	public class MailClient
	{
		public string Address { get; set; } = string.Empty;
		public string Body { get; set; } = string.Empty;
		public Encoding BodyEncoding { get; set; } = Encoding.UTF8;
		public List<string> Cc { get; set; } = new List<string>();
		public string DisplayName { get; set; } = string.Empty;
		public Encoding DisplayNameEncoding { get; set; } = Encoding.UTF8;
		public bool EnableSsl { get; set; }
		public string Host { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public int Port { get; set; }
		public string Subject { get; set; } = string.Empty;
		public Encoding SubjectEncoding { get; set; } = Encoding.UTF8;
		public List<string> To { get; set; } = new List<string>();
		public string Username { get; set; } = string.Empty;

		public MailClient() { }

		public MailClient(string host, int port) => (Host, Port) = (host, port);

		public MailClient(string host, int port, string username, string password) => (Host, Port, Username, Password) = (host, port, username, password);

		public void Send()
		{
			using (var client = new SmtpClient(Host, Port))
			{
				client.Credentials = new NetworkCredential(Username, Password);
				client.EnableSsl = EnableSsl;

				var from = new MailAddress(Address);
				if (!string.IsNullOrEmpty(DisplayName))
				{
					from = new MailAddress(Address, DisplayName, DisplayNameEncoding);
				}

				var message = new MailMessage();
				message.Body = Body;
				message.BodyEncoding = BodyEncoding;
				Cc.ForEach(message.CC.Add);
				message.From = from;
				message.Subject = Subject;
				message.SubjectEncoding = SubjectEncoding;
				To.ForEach(message.To.Add);
				client.Send(message);
				message.Dispose();
			}
		}
	}
}
