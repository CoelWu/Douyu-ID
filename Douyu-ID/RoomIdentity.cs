using System;
using System.Collections.Generic;
using System.Text;

namespace Douyu.ID
{
    public sealed partial class DouyuID
    {
        public string ParseRoomIdentify(int roomIdentity)
        {
            switch (roomIdentity)
            {
                case 1:
                    return "";
                case 4:
                    return "房管";
                case 5:
                    return "主播";
                default:
                    return "";
            }
        }
    }
}
