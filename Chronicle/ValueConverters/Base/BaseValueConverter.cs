﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Chronicle
{
	/// <summary>
	/// A base value converter for this application
	/// </summary>
	/// <typeparam name="T">The type of this value converter</typeparam>
	public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
		where T : class, new()
	{
		#region Private Members 
		/// <summary>
		/// A single static instance of this value converter
		/// </summary>
		private static T Converter = null;

		#endregion

		#region Markup Extension Methods

		/// <summary>
		/// Provides a static instance of the value converter
		/// </summary>
		/// <param name="serviceProvider"></param>
		/// <returns></returns>
		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			return Converter ?? (Converter = new T());
		}

		#endregion

		#region Value Converter Methods

		/// <summary>
		/// Converts a value to another type
		/// </summary>
		/// <param name="value"></param>
		/// <param name="targetType"></param>
		/// <param name="parameter"></param>
		/// <param name="culture"></param>
		/// <returns></returns>
		public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

		/// <summary>
		/// Converts a type back to its original value
		/// </summary>
		/// <param name="value"></param>
		/// <param name="targetType"></param>
		/// <param name="parameter"></param>
		/// <param name="culture"></param>
		/// <returns></returns>
		public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

		#endregion
	}
}
