﻿using RestSharp;

namespace IqOptionApiDotNet.Http
{
    public class ChangeBalanceRequest : IqOptionRequest
    {
        public ChangeBalanceRequest(long balanceId) : base("profile/changebalance", Method.POST)
        {
            var body = new
            {
                balance_id = balanceId
            };

            AddJsonBody(body);
            AddHeader("Content-Type", "application/json");
        }
    }
}