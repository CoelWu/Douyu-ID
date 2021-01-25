using System;

namespace Douyu.ID
{
    public sealed partial class DouyuID
    {
        public string ParseNobility(int nobility)
        {
            switch (nobility)
            {
                case 1:
                    return "骑士";
                case 2:
                    return "子爵";
                case 3:
                    return "伯爵";
                case 4:
                    return "公爵";
                case 5:
                    return "国王";
                case 6:
                    return "皇帝";
                case 7:
                    return "游侠";
                case 8:
                    return "超级皇帝";
                case 9:
                    return "幻神";
                default:
                    return "";
            }
        }
    }
}
