﻿// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace ILSpy.Host
{
    public class ListTypeResponse
    {
        public IEnumerable<MemberData> Types { get; set; }
    }
}
