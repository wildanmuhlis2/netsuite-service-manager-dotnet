//~ Generated by ISupportSearchValueNTemplate.tt
#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class SearchMultiSelectField 
		: ISupportSearchValue< RecordRef[] >,  
		  ISupportReferenceSearchValue< IReference[] > ,  
		  ISupportSearchOperator< com.celigo.net.ServiceManager.SuiteTalk.SearchMultiSelectFieldOperator >,
		  IBasicSearchField 
	{ 
		public RecordRef[] GetSearchValue()
		{
			return this.searchValue;
		}
		
				
		IReference[] ISupportReferenceSearchValue< IReference[] >.GetSearchValue()
		{
			return this.searchValue;
		}
				
		public void SetSearchValue(RecordRef[] value)
		{
			this.searchValue = value; 			
		}
		
				
	}
}
