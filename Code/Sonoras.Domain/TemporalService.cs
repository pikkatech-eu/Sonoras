/***********************************************************************************
* File:         TemporalService.cs                                                 *
* Contents:     Class TemporalService                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-03-16 14:43                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Gnomon.Domain.Arithmetical;
using Gnomon.Domain.Astronomical;
using Gnomon.Domain.Celestial;
using Gnomon.Domain.Celestial.Enumerations;

namespace Sonoras.Domain
{
	public class TemporalService
	{
		private System.Timers.Timer	_dataTimer;
		public int Interval	{get;set;} = 1000;

		public Location	Location	{get;set;} = null;

		private SolarEventsCalculator _calculator = new SolarEventsCalculator();

		/// <summary>
		/// Computes all temporal data for a
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public TemporalData GetTemporalData()
		{
			TemporalData data = new TemporalData();

			DateTime dtUtcNow = DateTime.UtcNow;
			GregorianDate gregorianUtc = dtUtcNow;

			double rdUtc = gregorianUtc.RataDie + dtUtcNow.TimeOfDay.TotalHours / 24;

			data.SunLongitude = this._calculator.SolarEphemeris.GetEclipticLongitude(rdUtc);

			var equatorial = SolarEventsCalculator.EclipticToEquatorial(data.SunLongitude, data.JulianDay);

			data.SunDeclination = equatorial.dec;
			data.SunRightAscension = equatorial.ra;

			var horizontals = this._calculator.GetAltitude(rdUtc, this.Location);
			data.SunAltitude = horizontals.Altitude;
			data.SunAzimuth = horizontals.Azimuth;   

			DateTime dtLocal = DateTime.Now;;
			data.GregorianDate = dtLocal;
			double rdLocal = data.GregorianDate.ToMoment();

			data.BahaiDate		= new BahaiDate();
			data.IslamicDate	= new IslamicDate();
			data.HebrewDate		= new HebrewDate();

			data.BahaiDate.FromMoment(rdLocal);
			data.IslamicDate.FromMoment(rdLocal);
			data.HebrewDate.FromMoment(rdLocal);	

			double jd = rdLocal - SimpleSolarEphemeris.JULIAN_DAY_EPOCH - 0.5;

			DateTime midday = (dtLocal - dtLocal.TimeOfDay).AddHours(12);
			var delta = dtLocal - midday;

			jd += delta.TotalHours / 24;

			data.JulianDay	= jd;

			string timeZoneId = TimeZoneConverter.TZConvert.IanaToWindows(Location.TimeZoneIanaId);

			data.StandardTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dtUtcNow, timeZoneId).TimeOfDay;

			data.UtcTime = dtUtcNow.TimeOfDay;

			data.LocalTime = dtUtcNow.AddHours(this.Location.Longitude / 15).TimeOfDay;

			SolarEvents se = this._calculator.GetSolarEvents(rdUtc, this.Location);

			if (se.PolarStatus == PolarStatus.None)
			{
				try
				{
					string windowsId = TimeZoneConverter.TZConvert.IanaToWindows(this.Location.TimeZoneIanaId);

					TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(windowsId);

					DateTime dtSunriseUtc = RataDieConverter.ToDateTime((double)se.Sunrise);
					DateTime dtSunriseLocal = TimeZoneInfo.ConvertTimeFromUtc(dtSunriseUtc, tzi);
					data.Sunrise = dtSunriseLocal.ToString("HH:mm:ss");

					DateTime dtSunsetUtc = RataDieConverter.ToDateTime((double)se.Sunset);
					DateTime dtSunsetLocal = TimeZoneInfo.ConvertTimeFromUtc(dtSunsetUtc, tzi);
					data.Sunset = dtSunsetLocal.ToString("HH:mm:ss");
				}
				catch (Exception ex)
				{
				}
			}
			else
			{
				data.Sunrise = se.PolarStatus.ToString();
				data.Sunset = se.PolarStatus.ToString();
			}

			return data;
		}

		/// <summary>
		/// All data, appended to a high-frequency timer.
		/// </summary>
		public event Action<TemporalData>	TemporalDataComputed;

		public TemporalService()
		{
			this._dataTimer = new System.Timers.Timer();
			this._dataTimer.Interval	= this.Interval;

			this._dataTimer.Elapsed += this.OnTimerElapsed;
		}

		private void OnTimerElapsed(object? sender, System.Timers.ElapsedEventArgs e)
		{
			if (this.Location != null)
			{
				GregorianDate gregorian	= DateTime.Now;
				double t = gregorian.RataDie;

				TemporalData data = this.GetTemporalData();

				this.TemporalDataComputed?.Invoke(data);
			}
		}

		public void StartTimer()
		{
			this._dataTimer.Start();
		}

		public void StopTimer()
		{
			this._dataTimer.Stop();
		}
	}
}
