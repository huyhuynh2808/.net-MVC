﻿namespace FashionShopMVC.Helper
{
    public class AdminPaginationSet<T>
    {
        public int Page { get; set; }
        public int Count
        {
            get
            {
                return (List != null) ? List.Count() : 0;
            }
        }
        public int PageSize { get; set; }  // Kích thước trang
        // Lưu tổng số trang
        public int PagesCount { get; set; }

        // Lưu tổng số bản ghi
        public int TotalCount { get; set; }

        public IEnumerable<T> List { get; set; }
    }
}
