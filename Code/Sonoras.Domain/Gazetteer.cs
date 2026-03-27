/***********************************************************************************
* File:         Gazetteer.cs                                                       *
* Contents:     Class Gazetteer                                                    *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-16 14:29                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Gnomon.Domain.Celestial;

namespace Sonoras.Domain
{
	public class Gazetteer
	{
		public List<Location> Locations	{get;set;} = new List<Location>();
		public Location SelectedLocation	{get;set;} = null;

		public string			Title			{get;set;} = "";
		public string			Description		{get;set;} = "";

		#region Serialization
		public string ToJson()
		{
			JsonSerializerOptions options = new JsonSerializerOptions
																	{
																		WriteIndented=true, 
																		Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
																	};

			string json = JsonSerializer.Serialize(this, options);

			return json;
		}

		public static Gazetteer FromJson(string json)
		{
			Gazetteer gazetteer	= JsonSerializer.Deserialize<Gazetteer>(json);
			return gazetteer;
		}

		public void Save(string fileName)
		{
			using (StreamWriter writer = new StreamWriter(fileName))
			{
				writer.Write(this.ToJson());
			}
		}

		public static Gazetteer Load(string fileName)
		{
			try
			{
				using (StreamReader reader = new StreamReader(fileName))
				{
					string json = reader.ReadToEnd();

					return FromJson(json);
				}
			}
			catch (Exception ex)
			{
				throw;
			}
		}
		#endregion
	}
}
