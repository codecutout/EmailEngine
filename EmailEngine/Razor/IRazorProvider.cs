﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailEngine.Razor
{
    using System.CodeDom;
    using System.CodeDom.Compiler;
    using System.Web.Razor;

    /// <summary>
    /// Defines a provider used to create associated compiler types.
    /// </summary>
    public interface IRazorProvider
    {
        /// <summary>
        /// Creates a code language service.
        /// </summary>
        /// <returns>Creates a language service.</returns>
        RazorCodeLanguage CreateLanguageService();

        /// <summary>
        /// Creates a <see cref="CodeDomProvider"/>.
        /// </summary>
        /// <returns>The a code dom provider.</returns>
        CodeDomProvider CreateCodeDomProvider();
    }
}
