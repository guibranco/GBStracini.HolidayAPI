﻿namespace GuiStracini.HolidayAPI.Model
{
    /// <summary>
    /// The country interface.
    /// </summary>
    public interface ICountry
    {
        /// <summary>
        /// Gets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        string Code { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; }
        /// <summary>
        /// Gets the languages.
        /// </summary>
        /// <value>
        /// The languages.
        /// </value>
        string[] Languages { get; }
        /// <summary>
        /// Gets the codes.
        /// </summary>
        /// <value>
        /// The codes.
        /// </value>
        CountryCode Codes { get; }
    }
}
