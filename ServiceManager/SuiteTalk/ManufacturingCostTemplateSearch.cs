//~ Generated by SearchRecordTemplate.tt
#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class ManufacturingCostTemplateSearchBasic : ISearchBasic, ISupportsCustomFields<SearchCustomField>	
	{			
		/// <summary>
		/// Gets custom field with the given ID or <c>null</c> if a field with the
		/// given ID was not found.
		/// </summary>
		public T FindCustomField<T>(string fieldId) where T: SearchCustomField
		{
			T match = null;
			if (null != this.customFieldList)
			{
				match = (T)Array.Find(
									this.customFieldList, 
									f => f is T && f.GetInternalId() == fieldId);
			}				
			return match;
		}
			
        /// <summary>
        /// Gets custom field with the given ID or <c>null</c> if a field with the
        /// given ID was not found.
        /// </summary>
        public SearchCustomField FindCustomField(string fieldId)
		{
			SearchCustomField match = null;
			if (null != this.customFieldList)
			{
				match = Array.Find(
									this.customFieldList, 
									f => f.GetInternalId() == fieldId);
			}				
			return match;
		}	}

	public partial class ManufacturingCostTemplateSearch : ISearchRecord
	{
		/// <summary>
		/// Gets the basic search criteria.
		/// </summary>
		/// <returns>The basic search criteria</returns>
		public ISearchBasic GetSearchBasic()
		{
			return this.basic;
		}
			
		/// <summary>
		/// Gets the basic search criteria.
		/// </summary>
		/// <param name="create">if set to <c>true</c> creates the basic criteria if null.</param>
		/// <returns>The basic search criteria</returns>
		public ISearchBasic GetSearchBasic(bool create)
		{
			if (create && this.basic == null)
				this.basic = new ManufacturingCostTemplateSearchBasic();
			return this.basic;
		}
	}
}	