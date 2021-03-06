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
	/// <summary>Discoverpage</summary>
	[PublishedContentModel("discoverpage")]
	public partial class Discoverpage : PublishedContentModel, IContentComposition, ISEO
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "discoverpage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Discoverpage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Discoverpage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Experience headline
		///</summary>
		[ImplementPropertyType("experienceHeadline")]
		public string ExperienceHeadline
		{
			get { return this.GetPropertyValue<string>("experienceHeadline"); }
		}

		///<summary>
		/// Experience map
		///</summary>
		[ImplementPropertyType("experienceMap")]
		public string ExperienceMap
		{
			get { return this.GetPropertyValue<string>("experienceMap"); }
		}

		///<summary>
		/// Get ready content
		///</summary>
		[ImplementPropertyType("getReadyContent")]
		public IHtmlString GetReadyContent
		{
			get { return this.GetPropertyValue<IHtmlString>("getReadyContent"); }
		}

		///<summary>
		/// Get ready headline
		///</summary>
		[ImplementPropertyType("getReadyHeadline")]
		public string GetReadyHeadline
		{
			get { return this.GetPropertyValue<string>("getReadyHeadline"); }
		}

		///<summary>
		/// Get ready to do
		///</summary>
		[ImplementPropertyType("getReadyToDo")]
		public IHtmlString GetReadyToDo
		{
			get { return this.GetPropertyValue<IHtmlString>("getReadyToDo"); }
		}

		///<summary>
		/// Get ready transport
		///</summary>
		[ImplementPropertyType("getReadyTransport")]
		public IHtmlString GetReadyTransport
		{
			get { return this.GetPropertyValue<IHtmlString>("getReadyTransport"); }
		}

		///<summary>
		/// Intro
		///</summary>
		[ImplementPropertyType("intro")]
		public IHtmlString Intro
		{
			get { return this.GetPropertyValue<IHtmlString>("intro"); }
		}

		///<summary>
		/// Looking back bodytext
		///</summary>
		[ImplementPropertyType("lookingBackBodytext")]
		public string LookingBackBodytext
		{
			get { return this.GetPropertyValue<string>("lookingBackBodytext"); }
		}

		///<summary>
		/// Looking back hashtag
		///</summary>
		[ImplementPropertyType("lookingBackHashtag")]
		public string LookingBackHashtag
		{
			get { return this.GetPropertyValue<string>("lookingBackHashtag"); }
		}

		///<summary>
		/// Looking back headline
		///</summary>
		[ImplementPropertyType("lookingBackHeadline")]
		public string LookingBackHeadline
		{
			get { return this.GetPropertyValue<string>("lookingBackHeadline"); }
		}

		///<summary>
		/// Looking back Image
		///</summary>
		[ImplementPropertyType("lookingBackImage")]
		public IPublishedContent LookingBackImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("lookingBackImage"); }
		}

		///<summary>
		/// Looking bad nested
		///</summary>
		[ImplementPropertyType("lookingBadNested")]
		public IEnumerable<IPublishedContent> LookingBadNested
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("lookingBadNested"); }
		}

		///<summary>
		/// Umbraco awards bodytext
		///</summary>
		[ImplementPropertyType("umbracoAwardsBodytext")]
		public string UmbracoAwardsBodytext
		{
			get { return this.GetPropertyValue<string>("umbracoAwardsBodytext"); }
		}

		///<summary>
		/// Umbraco awards headline
		///</summary>
		[ImplementPropertyType("umbracoAwardsHeadline")]
		public string UmbracoAwardsHeadline
		{
			get { return this.GetPropertyValue<string>("umbracoAwardsHeadline"); }
		}

		///<summary>
		/// Umbraco awards image
		///</summary>
		[ImplementPropertyType("umbracoAwardsImage")]
		public IPublishedContent UmbracoAwardsImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("umbracoAwardsImage"); }
		}

		///<summary>
		/// Umbraco awards link
		///</summary>
		[ImplementPropertyType("umbracoAwardsLink")]
		public IPublishedContent UmbracoAwardsLink
		{
			get { return this.GetPropertyValue<IPublishedContent>("umbracoAwardsLink"); }
		}

		///<summary>
		/// Bodytext
		///</summary>
		[ImplementPropertyType("bodytext")]
		public string Bodytext
		{
			get { return Umbraco.Web.PublishedContentModels.ContentComposition.GetBodytext(this); }
		}

		///<summary>
		/// Content image
		///</summary>
		[ImplementPropertyType("contentImage")]
		public IPublishedContent ContentImage
		{
			get { return Umbraco.Web.PublishedContentModels.ContentComposition.GetContentImage(this); }
		}

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return Umbraco.Web.PublishedContentModels.ContentComposition.GetHeadline(this); }
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta keywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetMetaKeywords(this); }
		}
	}
}
