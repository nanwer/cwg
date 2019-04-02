﻿namespace cwg.web.Generators
{
    public class DLLGenerator : BaseGenerator
    {
        public override string Name => "DLL";

        protected override string SourceName => "sourceDLL";

        protected override string OutputExtension => "dll";
    }
}