﻿using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class HistoryGetAllFolderFile
    {
        public string Mpath { get; set; }
        public string Name { get; set; }
        public int? MarketSegmentId { get; set; }
        public int? RegionId { get; set; }
        public int? LandId { get; set; }
        public int? SubMarketId { get; set; }
        public int? ProductId { get; set; }
        public int? ProductGroupId { get; set; }
        public int? IndependencyId { get; set; }
        public int? OtherId { get; set; }
        public long? ProjectId { get; set; }
        public long? DeletedBy { get; set; }
        public bool? IsActive { get; set; }
        public int IsRelation { get; set; }
        public Guid Id { get; set; }
        public long AccountId { get; set; }
        public DateTime ModifedDate { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string ObjectId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public int? Action { get; set; }
        public long RecoverBy { get; set; }
        public bool? IsNotRecover { get; set; }
        public long? Rn { get; set; }
    }
}