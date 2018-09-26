namespace NetSharp.QueryModel
{
    /// <summary>
    /// 表示排序项。
    /// </summary>
    public class SorterItem
    {
        /// <summary>
        /// 获取成员名称。
        /// </summary>
        public string Member { get; }

        /// <summary>
        /// 获取排序方向。
        /// </summary>
        public SorterDirection Direction { get; }

        /// <summary>
        /// 初始化 <see cref="SorterItem"/> 类型的新实例。
        /// </summary>
        /// <param name="member">成员名称。</param>
        /// <param name="direction">排序方向。</param>
        public SorterItem(string member, SorterDirection direction)
        {
            Member = member;
            Direction = direction;
        }
    }
}
