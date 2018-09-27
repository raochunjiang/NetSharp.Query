using System;
using System.Collections;
using System.Collections.Generic;

namespace NetSharp.QueryModel
{
    /// <summary>
    /// 表示分页信息。
    /// </summary>
    public class Pagination<TModel> : Paginator
        where TModel : class
    {
        /// <summary>
        /// 获取当前页结果集。
        /// </summary>
        public ICollection<TModel> Items { get; }

        /// <summary>
        /// 获取当前页条目数。
        /// </summary>
        public int Count { get { return Items.Count; } }

        /// <summary>
        /// 获取总条目数。
        /// </summary>
        public long Total { get; }

        /// <summary>
        /// 获取总页数。
        /// </summary>
        public int IndexCount { get { return (int)(Total <= Size ? 1 : Total/Size + 1); } }

        /// <summary>
        /// 获取下一个页码。无下一页时该属性值为 null。
        /// </summary>
        public int? NextIndex { get { return IndexCount > Index ? new Nullable<int>(Index + 1) : null; } }

        /// <summary>
        /// 获取上一个页码。无上一页时该属性值为 null。
        /// </summary>
        public int? PreviousIndex { get { return IndexCount > 1 ? new Nullable<int>(Index - 1) : null; } }

        /// <summary>
        /// 初始化 <see cref="QueryPagination"/> 类型的新实例。
        /// </summary>
        /// <param name="paginator">查询时所引用的分页项。</param>
        /// <param name="items">当前页结果集。</param>
        /// <param name="total">总条目数。</param>
        public Pagination(Paginator paginator, ICollection<TModel> items, long total)
        {
            Index = paginator?.Index ?? throw new ArgumentNullException(nameof(paginator));
            Size = paginator?.Size ?? throw new ArgumentNullException(nameof(paginator));
            Items = items ?? throw new ArgumentNullException(nameof(items));
            Total = total >= 0 ? total : throw new ArgumentOutOfRangeException(nameof(total));
        }
    }
}
