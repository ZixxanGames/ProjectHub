﻿using System;

namespace Web.ViewModels.Pagination
{
    public class PaginationInfoViewModel
    {
        public int CurrentPage { get; init; }

        public int TotalPages { get; init; }


        public bool HasPreviousPage => CurrentPage > 1;

        public bool HasNextPage => CurrentPage < TotalPages;


        public PaginationInfoViewModel() {}

        public PaginationInfoViewModel(int currentPage, int pageSize, int itemsCount)
        {
            CurrentPage = currentPage;

            TotalPages = (int)Math.Ceiling((double)itemsCount / pageSize);
        }
    }
}
