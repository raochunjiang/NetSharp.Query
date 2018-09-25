using System.Collections.Generic;

namespace NetSharp.Query.Model
{
    /// <summary>
    /// 表示筛选组合。
    /// </summary>
    public class FilterGroup
    {
        /// <summary>
        /// 获取当前对象在查询/父筛选组合对象中的组合逻辑。
        /// </summary>
        public FilterCombination Combine { get; }

        /// <summary>
        /// 获取组合中的筛选项集合。
        /// </summary>
        public ICollection<FilterItem> Items { get; }

        /// <summary>
        /// 获取组合中的子筛选组合集合。
        /// </summary>
        public ICollection<FilterGroup> Groups { get; }

        /// <summary>
        /// 初始化 <see cref="FilterGroup"/> 类型的新实例。
        /// </summary>
        /// <param name="combine">当前对象在查询/筛选组合对象中的组合逻辑。</param>
        public FilterGroup(FilterCombination combine)
        {
            Combine = combine;
            Items = new List<FilterItem>();
            Groups = new List<FilterGroup>();
        }
    }
}
