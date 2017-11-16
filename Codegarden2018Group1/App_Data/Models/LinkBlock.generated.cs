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
	// Mixin content Type 1073 with alias "linkBlock"
	/// <summary>Link block</summary>
	public partial interface ILinkBlock : IPublishedContent
	{
		/// <summary>Link block bodytext</summary>
		string LinkBlockBodytext { get; }

		/// <summary>Link block headline</summary>
		string LinkBlockHeadline { get; }

		/// <summary>Link block image</summary>
		IPublishedContent LinkBlockImage { get; }

		/// <summary>Link block link</summary>
		IPublishedContent LinkBlockLink { get; }
	}

	/// <summary>Link block</summary>
	[PublishedContentModel("linkBlock")]
	public partial class LinkBlock : PublishedContentModel, ILinkBlock
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "linkBlock";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LinkBlock(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LinkBlock, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Link block bodytext
		///</summary>
		[ImplementPropertyType("linkBlockBodytext")]
		public string LinkBlockBodytext
		{
			get { return GetLinkBlockBodytext(this); }
		}

		/// <summary>Static getter for Link block bodytext</summary>
		public static string GetLinkBlockBodytext(ILinkBlock that) { return that.GetPropertyValue<string>("linkBlockBodytext"); }

		///<summary>
		/// Link block headline
		///</summary>
		[ImplementPropertyType("linkBlockHeadline")]
		public string LinkBlockHeadline
		{
			get { return GetLinkBlockHeadline(this); }
		}

		/// <summary>Static getter for Link block headline</summary>
		public static string GetLinkBlockHeadline(ILinkBlock that) { return that.GetPropertyValue<string>("linkBlockHeadline"); }

		///<summary>
		/// Link block image
		///</summary>
		[ImplementPropertyType("linkBlockImage")]
		public IPublishedContent LinkBlockImage
		{
			get { return GetLinkBlockImage(this); }
		}

		/// <summary>Static getter for Link block image</summary>
		public static IPublishedContent GetLinkBlockImage(ILinkBlock that) { return that.GetPropertyValue<IPublishedContent>("linkBlockImage"); }

		///<summary>
		/// Link block link
		///</summary>
		[ImplementPropertyType("linkBlockLink")]
		public IPublishedContent LinkBlockLink
		{
			get { return GetLinkBlockLink(this); }
		}

		/// <summary>Static getter for Link block link</summary>
		public static IPublishedContent GetLinkBlockLink(ILinkBlock that) { return that.GetPropertyValue<IPublishedContent>("linkBlockLink"); }
	}
}