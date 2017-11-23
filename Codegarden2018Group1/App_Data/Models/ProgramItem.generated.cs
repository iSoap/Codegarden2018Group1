//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>ProgramItem</summary>
	[PublishedContentModel("programItem")]
	public partial class ProgramItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "programItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ProgramItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ProgramItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// EndTime
		///</summary>
		[ImplementPropertyType("endTime")]
		public DateTime EndTime
		{
			get { return this.GetPropertyValue<DateTime>("endTime"); }
		}

		///<summary>
		/// Location
		///</summary>
		[ImplementPropertyType("location")]
		public string Location
		{
			get { return this.GetPropertyValue<string>("location"); }
		}

		///<summary>
		/// Speakers
		///</summary>
		[ImplementPropertyType("speakers")]
		public IEnumerable<IPublishedContent> Speakers
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("speakers"); }
		}

		///<summary>
		/// StartTime
		///</summary>
		[ImplementPropertyType("startTime")]
		public DateTime StartTime
		{
			get { return this.GetPropertyValue<DateTime>("startTime"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}
}