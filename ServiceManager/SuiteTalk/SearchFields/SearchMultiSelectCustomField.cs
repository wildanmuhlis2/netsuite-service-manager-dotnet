//~ Generated by ISupportSearchValueNTemplate.tt
#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class SearchMultiSelectCustomField 
		: ISupportSearchValue< ListOrRecordRef[] >,  
		  ISupportReferenceSearchValue< IReference[] > ,  
		  ISupportSearchOperator< com.celigo.net.ServiceManager.SuiteTalk.SearchMultiSelectFieldOperator >,
		  IBasicSearchField 
	{ 
		public ListOrRecordRef[] GetSearchValue()
		{
			return this.searchValue;
		}
		
				
		IReference[] ISupportReferenceSearchValue< IReference[] >.GetSearchValue()
		{
			return this.searchValue;
		}
				
		public void SetSearchValue(ListOrRecordRef[] value)
		{
			this.searchValue = value; 			
		}
		
				
	}
}
