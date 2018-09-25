namespace NetSharp.Query.Model
{
    /// <summary>
    /// 表示筛选项。
    /// </summary>
    public class FilterItem
    {
        /// <summary>
        /// 初始化 <see cref="FilterItem"/> 类型的新实例。
        /// </summary>
        /// <param name="combine">当前对象在查询/筛选组合对象中的组合逻辑。</param>
        /// <param name="member">成员名称。</param>
        /// <param name="operator">筛选操作。</param>
        /// <param name="value">用于筛选的值。</param>
        public FilterItem(FilterCombination combine, string member, FilterOperator @operator, object value)
        {
            Combine = combine;
            Member = member;
            Operator = @operator;
            Value = value;
        }

        /// <summary>
        /// 获取当前对象在查询/筛选组合对象中的组合逻辑。
        /// </summary>
        public FilterCombination Combine { get; }

        /// <summary>
        /// 获取成员名称。
        /// </summary>
        public string Member { get; }

        /// <summary>
        /// 获取筛选操作。
        /// </summary>
        public FilterOperator Operator { get; }

        /// <summary>
        /// 获取或设置用于筛选的值。
        /// </summary>
        public object Value { get; set; }

    }
}
