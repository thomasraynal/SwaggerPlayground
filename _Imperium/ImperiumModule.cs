using SwaggerPlayground.Modules.Imperium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerPlayground._Imperium
{
    public class ImperiumModule : ImperiumModuleBase
    {
        public ImperiumModule(IImperiumService imperiumService) : base(imperiumService)
        {
        }
    }
}
