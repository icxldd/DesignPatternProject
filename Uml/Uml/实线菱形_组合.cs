using System.Collections.Generic;

namespace Uml
{
    //整体和部分   离开整体部分不能存活  则是组合关系

    //人与手，头  是组合关系   没有人 就没有人的手，头

    //学校与学校报名单是组合关系  ，没有学校就没有学校报名单

    public class 学校
    {
        public List<学校报名单> 学校报名单s { get; set; }
    }

    public class 学校报名单
    {
    }

    public class 人
    {
        public 手 手 { get; set; }


        public 头 头 { get; set; }
    }


    public class 头
    {
    }

    public class 手
    {
    }
}