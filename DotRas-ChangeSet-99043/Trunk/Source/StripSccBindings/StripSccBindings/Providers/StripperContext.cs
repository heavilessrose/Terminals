﻿//--------------------------------------------------------------------------
// <copyright file="StripperContext.cs" company="Jeff Winn">
//      Copyright (c) Jeff Winn. All rights reserved.
//
//      The use and distribution terms for this software is covered by the
//      GNU Library General Public License (LGPL) v2.1 which can be found
//      in the License.rtf at the root of this distribution.
//      By using this software in any fashion, you are agreeing to be bound by
//      terms of this license.
//
//      You must not remove this notice, or any other, from this software.
// </copyright>
//--------------------------------------------------------------------------

namespace StripSccBindings.Providers
{
    using System;
    using System.IO;

    /// <summary>
    /// Provides contextual information for a stripper.
    /// </summary>
    internal class StripperContext
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StripSccBindings.Providers.StripperContext"/> class.
        /// </summary>
        public StripperContext()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public FileInfo File
        {
            get;
            set;
        }

        #endregion
    }
}