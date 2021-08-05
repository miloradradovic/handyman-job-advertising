﻿using System;
using System.Collections.Generic;
using Model.dto;

namespace Model.models
{
    public class JobAd
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Location Address { get; set; }
        public User Owner { get; set; }
        public AdditionalJobAdInfo AdditionalJobAdInfo { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public virtual List<Trade> Trades { get; set; }

        public JobAdDTO ToJobAdDTO()
        {
            if (AdditionalJobAdInfo == null)
            {
                return new JobAdDTO()
                {
                    Address = Address.ToLocationDTO(),
                    DateFrom = DateFrom,
                    DateTo = DateTo,
                    Description = Description,
                    Id = Id,
                    Title = Title,
                    Trades = ConvertTradesToStrings()
                };
            }
            
            return new JobAdDTO()
            {
                Address = Address.ToLocationDTO(),
                DateFrom = DateFrom,
                DateTo = DateTo,
                Description = Description,
                Id = Id,
                Title = Title,
                Trades = ConvertTradesToStrings(),
                AdditionalJobAdInfo = AdditionalJobAdInfo.ToAdditionalJobAdInfoDTO()
            };
        }

        private List<string> ConvertTradesToStrings()
        {
            List<string> trades = new List<string>();

            foreach (Trade trade in Trades)
            {
                trades.Add(trade.Name);
            }

            return trades;
        }
    }
}