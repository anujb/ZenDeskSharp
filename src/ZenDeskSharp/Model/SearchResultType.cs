using System;

namespace ZenDeskSharp.Model
{
	public class SearchResultType
	{
		public Type ResultType { get; private set; }
		
		public SearchResultType(Type resultType)
		{
			ResultType = resultType;
		}
		
		public static readonly SearchResultType Attachment = new SearchResultType(typeof(Attachment));
		public static readonly SearchResultType Comment = new SearchResultType(typeof(Comment));
		public static readonly SearchResultType Entry = new SearchResultType(typeof(Entry));
		public static readonly SearchResultType Forum = new SearchResultType(typeof(Forum));
		public static readonly SearchResultType Group = new SearchResultType(typeof(Group));
		public static readonly SearchResultType Macro = new SearchResultType(typeof(Macro));
		public static readonly SearchResultType Organization = new SearchResultType(typeof(Organization));
		public static readonly SearchResultType Post = new SearchResultType(typeof(Post));
		public static readonly SearchResultType Tag = new SearchResultType(typeof(TagScore));
		public static readonly SearchResultType Ticket = new SearchResultType(typeof(Ticket));
		public static readonly SearchResultType User = new SearchResultType(typeof(User));
		
	}
}

