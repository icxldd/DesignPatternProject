using System.Collections.Generic;

namespace Uml
{
    //整体和部分   部分可以离开整体存活  则是聚合关系

    //班级和人是聚合关系
    //部门和人是聚合关系
    
    
    public class 班级
    {
        public List<IPerson> Persons = new List<IPerson>();
    }

    public class 部门
    {
        public List<IPerson> Persons = new List<IPerson>();
    }


    public interface IPerson
    {
    }

    public partial class CXL : IPerson
    {
    }
}