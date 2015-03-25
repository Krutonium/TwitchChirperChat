﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitchChirperChat
{
    /// <summary>
    /// Used exclusively for a message that gets put into the queue. This is used specifically to hold
    /// the time it was added to the queue and the citizenId. I don't want to have to get the citizen's Id
    /// if I don't send the message, so I use this until I actually want to send the message
    /// </summary>
    public class QueuedChirperMessage
    {
        private uint _citizenId = 0u;
        public uint CitizenId
        {
            get { return _citizenId; }
            set
            {
                _citizenId = value;
                IsCitizenIdSet = true; 
            }
        }
        public string CitizenName { get; private set; }
        public bool IsCitizenIdSet { get; private set; }
        public string Message { get; set; }
        public DateTime QueueTime { get; private set; }

        public QueuedChirperMessage(string citizenName, string message)
        {
            IsCitizenIdSet = false;
            CitizenName = citizenName;
            Message = message;
            QueueTime = DateTime.Now;
        }

        public QueuedChirperMessage(string citizenName, string message, uint citizenId)
        {
            _citizenId = citizenId;
            IsCitizenIdSet = true;
            CitizenName = citizenName;
            Message = message;
            QueueTime = DateTime.Now;
        }
    }
}
