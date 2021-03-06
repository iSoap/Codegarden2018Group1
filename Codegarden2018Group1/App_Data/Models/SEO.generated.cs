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
	// Mixin content Type 1061 with alias "sEO"
	/// <summary>_SEO</summary>
	public partial interface ISEO : IPublishedContent
	{
		/// <summary>Meta description</summary>
		string MetaDescription { get; }

		/// <summary>Meta keywords</summary>
		string MetaKeywords { get; }
	}

	/// <summary>_SEO</summary>
	[PublishedContentModel("sEO")]
	public partial class SEO : PublishedContentModel, ISEO
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sEO";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SEO(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SEO, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return GetMetaDescription(this); }
		}

		/// <summary>Static getter for Meta description</summary>
		public static string GetMetaDescription(ISEO that) { return that.GetPropertyValue<string>("metaDescription"); }

		///<summary>
		/// Meta keywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return GetMetaKeywords(this); }
		}

		/// <summary>Static getter for Meta keywords</summary>
		public static string GetMetaKeywords(ISEO that) { return that.GetPropertyValue<string>("metaKeywords"); }
	}
}
