using System.Collections.Generic;

namespace NetSharp.QueryModel
{
    /// <summary>
    /// 表示列表查询。
    /// </summary>
    public class ListQuery
    {
        /// <summary>
        /// 获取筛选项组合。
        /// </summary>
        public FilterGroup Filter { get; }

        /// <summary>
        /// 获取排序项集合。
        /// </summary>
        public List<SorterItem> Sorters { get; }

        /// <summary>
        /// 初始化 <see cref="ListQuery"/> 类型的新实例。
        /// </summary>
        public ListQuery()
        {
            Filter = new FilterGroup(FilterCombination.And);
            Sorters = new List<SorterItem>();
        }
    }
}
