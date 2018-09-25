namespace NetSharp.Query.Model
{
    /// <summary>
    /// 表示筛选项的筛选操作。
    /// </summary>
    public enum FilterOperator
    {
        /// <summary>
        /// 筛选项中指定的属性小于（&lt;）指定的值
        /// </summary>
        LessThan = 0,

        /// <summary>
        /// 筛选项中指定的属性小于或等于（&lt;=）指定的值
        /// </summary>
        LessThanOrEqualTo = 1,

        /// <summary>
        /// 筛选项中指定的属性等于（=）指定的值
        /// </summary>
        EqualTo = 2,

        /// <summary>
        /// 筛选项中指定的属性不等于（!=）指定的值
        /// </summary>
        NotEqualTo = 3,

        /// <summary>
        /// 筛选项中指定的属性大于或等于（&gt;=）指定的值
        /// </summary>
        GreaterThanOrEqualTo = 4,

        /// <summary>
        /// 筛选项中指定的属性大于（&gt;）指定的值
        /// </summary>
        GreaterThan = 5,

        /// <summary>
        /// 筛选项中指定属性的开头与指定的值匹配
        /// </summary>
        StartsWith = 6,

        /// <summary>
        /// 筛选项中指定属性的结尾与指定的值匹配
        /// </summary>
        EndsWith = 7,

        /// <summary>
        /// 筛选项中指定的属性包含指定的值
        /// </summary>
        Contains = 8,

        /// <summary>
        /// 筛选项中指定的属性包含于指定的值
        /// </summary>
        ContainedIn = 9,
    }
}