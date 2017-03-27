﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poloniex.Core.Domain.Models
{
    public class Task
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TaskId { get; set; }

        [Required, MaxLength(32)]
        public string TaskType { get; set; }

        // Navigation properties
        public virtual TaskLoop TaskLoop { get; set; }

        public virtual GatherTask GatherTask { get; set; }

        public virtual TradeTask TradeTask { get; set; }

        public virtual ICollection<EventAction> EventActions { get; set; }
    }
}
