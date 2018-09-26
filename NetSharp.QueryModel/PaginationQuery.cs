namespace NetSharp.QueryModel
{
    /// <summary>
    /// 表示分页列表查询。
    /// </summary>
    public class PaginationQuery : ListQuery
    {
        /// <summary>
        /// 获取分页项。
        /// </summary>
        public Paginator Paginator { get; }

        /// <summary>
        /// 初始化 <see cref="PaginationQuery"/> 类型的新实例。
        /// </summary>
        public PaginationQuery()
        {
            Paginator = new Paginator();
        }
    }
}
