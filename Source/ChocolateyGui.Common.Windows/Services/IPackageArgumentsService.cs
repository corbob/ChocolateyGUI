﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Chocolatey" file="IPackageArgumentsService.cs">
//   Copyright 2017 - Present Chocolatey Software, LLC
//   Copyright 2014 - 2017 Rob Reynolds, the maintainers of Chocolatey, and RealDimensions Software, LLC
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace ChocolateyGui.Common.Windows.Services
{
    public interface IPackageArgumentsService
    {
        IEnumerable<string> DecryptPackageArgumentsFile(string id, string version);
    }
}