using System;

namespace NetSharp.Query.Model
{
    /// <summary>
    /// 表示分页项
    /// </summary>
    public class Paginator
    {
        private int _index = 1;
        private int _size = 10;

        /// <summary>
        /// 页码。最小值是 1
        /// </summary>
        public int Index
        {
            get => _index;
            set => _index = value < 1 ? throw new ArgumentOutOfRangeException(nameof(value)) : value;
        }
        /// <summary>
        /// 页容量。最小值是1
        /// </summary>
        public int Size
        {
            get => _size;
            set => _size = value < 1 ? throw new ArgumentOutOfRangeException(nameof(value)) : value;
        }
    }
}
