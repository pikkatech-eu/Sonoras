/***********************************************************************************
* File:         TemporalData.cs                                                    *
* Contents:     Class TemporalData                                                 *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-16 14:35                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Gnomon.Domain;
using Gnomon.Domain.Arithmetical;
using Gnomon.Domain.Astronomical;
using Gnomon.Domain.Celestial;

namespace Sonoras.Domain
{
	/// <summary>
	/// Collection of values calculated and displayed.
	/// </summary>
	public class TemporalData
	{
		public GregorianDate	GregorianDate		{get;set;}
		public BahaiDate		BahaiDate			{get;set;}
		public IslamicDate		IslamicDate			{get;set;}
		public HebrewDate		HebrewDate			{get;set;}
		public double			JulianDay			{get;set;}


		public TimeSpan			StandardTime		{get;set;}
		public TimeSpan			LocalTime			{get;set;}
		public TimeSpan			UtcTime				{get;set;}

		/// <summary>
		/// degrees
		/// </summary>
		public double			SunLongitude		{get;set;}
		public double			SunDeclination		{get;set;}
		public double			SunRightAscension	{get;set;}
		public double			SunAltitude			{get;set;}
		public double			SunAzimuth			{get;set;}

		public string			Sunrise				{get;set;}
		public string			Sunset				{get;set;}
	}
}
