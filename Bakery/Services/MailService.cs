using Bakery.Models;
using System;
using System.Web.Helpers;

namespace Bakery.Services
{
    public class MailService : IMailService
    {
        public void SendOrderConfirmation(Order order) 
        {
            var body = "Thank you, we have received your order for " + order.Quantity + " unit(s) of " + order.Product.Name + "!<br/>";
            var orderShipping = order.ShippingAddress;
            var customerEmail = order.EmailAddress;

                //Replace carriage returns with HTML breaks for HTML mail
                var formattedOrder = orderShipping.Replace("\r\n", "<br/>");
                body += "Your address is: <br/>" + formattedOrder + "<br/>";
            
            body += "Your total is $" + (order.Product.Price * order.Product.Price) + ".<br/>";
            body += "We will contact you if we have questions about your order.  Thanks!<br/>";

            try {
                //SMTP Configuration for Hotmail
                WebMail.SmtpServer = "smtp.live.com";
                WebMail.SmtpPort = 25;
                WebMail.EnableSsl = true;

                //Enter your Hotmail credentials for UserName/Password and a "From" address for the e-mail
                WebMail.UserName = "";
                WebMail.Password = "";
                WebMail.From = "";
                WebMail.Send(to: customerEmail, subject: "Fourth Coffee - New Order", body: body);
            }
            catch (Exception) {
                // only placed here to allow app to run without configuring email
            }
        }
    }
}