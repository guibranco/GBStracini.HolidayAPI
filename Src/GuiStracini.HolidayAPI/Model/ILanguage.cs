﻿namespace GuiStracini.HolidayAPI.Model
{
    /// <summary>
    /// The language interface
    /// </summary>
    public interface ILanguage
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
    }
}
