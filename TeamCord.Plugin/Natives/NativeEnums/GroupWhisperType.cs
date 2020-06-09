﻿namespace TeamCord.Plugin.Natives
{
    public enum GroupWhisperType
    {
        /// GROUPWHISPERTYPE_SERVERGROUP -> 0
        GROUPWHISPERTYPE_SERVERGROUP = 0,

        /// GROUPWHISPERTYPE_CHANNELGROUP -> 1
        GROUPWHISPERTYPE_CHANNELGROUP = 1,

        /// GROUPWHISPERTYPE_CHANNELCOMMANDER -> 2
        GROUPWHISPERTYPE_CHANNELCOMMANDER = 2,

        /// GROUPWHISPERTYPE_ALLCLIENTS -> 3
        GROUPWHISPERTYPE_ALLCLIENTS = 3,

        GROUPWHISPERTYPE_ENDMARKER,
    }
}