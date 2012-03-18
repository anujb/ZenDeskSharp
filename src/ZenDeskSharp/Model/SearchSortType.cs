using System;

namespace ZenDeskSharp
{
	public class SearchSortType
	{
		private readonly string _sortType;
		
		public SearchSortType(string sortType)
		{
			_sortType = sortType;
		}
		
		public static implicit operator SearchSortType(string sortType)
		{
			return new SearchSortType(sortType);
		}
		
		public override string ToString ()
		{
			return _sortType;
		}
		
		public static readonly SearchSortType None = new SearchSortType("NONE");
		public static readonly SearchSortType Sort_Ascending = new SearchSortType("SORT_ASC");
		public static readonly SearchSortType Sort_Descending = new SearchSortType("SORT_DESC");
		public static readonly SearchSortType OrderBy_Priority = new SearchSortType("ORDERBY_PRIORITY");
		public static readonly SearchSortType OrderBy_Status = new SearchSortType("ORDERBY_STATUS");
		public static readonly SearchSortType OrderBy_TicketType = new SearchSortType("ORDERBY_TICKETTYPE");
		public static readonly SearchSortType OrderBy_Updated = new SearchSortType("ORDERBY_UPDATEDAT");
		public static readonly SearchSortType OrderBy_Created = new SearchSortType("ORDERBY_CREATEDAT");
	}
}

