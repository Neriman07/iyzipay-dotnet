﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
    public class Payment : IyzipayResource
    {
        public String Price { get; set; }
        public String PaidPrice { get; set; }
        public int? Installment { get; set; }
        public String PaymentId { get; set; }
        public int FraudStatus { get; set; }
        public String MerchantCommissionRate { get; set; }
        public String MerchantCommissionRateAmount { get; set; }
        public String IyziCommissionRateAmount { get; set; }
        public String IyziCommissionFee { get; set; }
        public String CardType { get; set; }
        public String CardAssociation { get; set; }
        public String CardFamily { get; set; }
        public String CardToken { get; set; }
        public String CardUserKey { get; set; }
        public String BinNumber { get; set; }
        public String BasketId { get; set; }
        [JsonProperty(PropertyName = "itemTransactions")]
        private List<PaymentItem> PaymentItems { get; set; }
    }
}
