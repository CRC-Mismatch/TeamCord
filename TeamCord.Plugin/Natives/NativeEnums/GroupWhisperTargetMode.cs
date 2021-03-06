﻿namespace TeamCord.Plugin.Natives
{
    public enum GroupWhisperTargetMode
    {
        /// GROUPWHISPERTARGETMODE_ALL -> 0
        GROUPWHISPERTARGETMODE_ALL = 0,

        /// GROUPWHISPERTARGETMODE_CURRENTCHANNEL -> 1
        GROUPWHISPERTARGETMODE_CURRENTCHANNEL = 1,

        /// GROUPWHISPERTARGETMODE_PARENTCHANNEL -> 2
        GROUPWHISPERTARGETMODE_PARENTCHANNEL = 2,

        /// GROUPWHISPERTARGETMODE_ALLPARENTCHANNELS -> 3
        GROUPWHISPERTARGETMODE_ALLPARENTCHANNELS = 3,

        /// GROUPWHISPERTARGETMODE_CHANNELFAMILY -> 4
        GROUPWHISPERTARGETMODE_CHANNELFAMILY = 4,

        /// GROUPWHISPERTARGETMODE_ANCESTORCHANNELFAMILY -> 5
        GROUPWHISPERTARGETMODE_ANCESTORCHANNELFAMILY = 5,

        /// GROUPWHISPERTARGETMODE_SUBCHANNELS -> 6
        GROUPWHISPERTARGETMODE_SUBCHANNELS = 6,

        GROUPWHISPERTARGETMODE_ENDMARKER,
    }
}