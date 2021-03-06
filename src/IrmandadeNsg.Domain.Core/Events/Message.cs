﻿using MediatR;
using System;

namespace IrmandadeNsg.Domain.Core.Events
{
    public class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
