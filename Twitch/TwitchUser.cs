﻿using System;

namespace TwitchChirperChat.TwitchIrc
{
    /// <summary>
    /// A generic Twitch User with no interal data parsing or logic beyond the object matching overrides
    /// </summary>
    public class TwitchUser
    {
        public string UserName { get; set; }
        public DateTime? SubscribeDateTime { get; set; }
        public int MonthsSubscribed { get; set; }
        public DateTime? FollowedDateTime { get; set; }

        public TwitchUser()
        {
            MonthsSubscribed = 1;
        }

        /// <returns>true if UserName is equal</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is TwitchUser))
                return false;

            return this.UserName.Equals(((TwitchUser)obj).UserName);
        }

        /// <returns>Hashcode of UserName, which should always be unique</returns>
        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        /// <returns>UserName</returns>
        public override string ToString()
        {
            return UserName;
        }
    }
}