﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;

namespace iyzipay_dotnet_sample.Sample
{
    [TestClass]
    public class CancelSample : Sample
    {
        [TestMethod]
        public void Should_Cancel_Payment()
        {
            CreateCancelRequest request = new CreateCancelRequest();
            request.ConversationId = "123456";
            request.Locale = Locale.TR.GetName();
            request.PaymentId = "1";
            request.Ip = "127.0.0.1";

            Cancel cancel = Cancel.Create(request, options);
            Assert.IsNotNull(cancel.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), cancel.Status);
            Assert.AreEqual(Locale.TR.GetName(), cancel.Locale);
            Assert.AreEqual("123456789", cancel.ConversationId);
            Assert.AreEqual("1", cancel.PaymentId);
        }
    }
}
