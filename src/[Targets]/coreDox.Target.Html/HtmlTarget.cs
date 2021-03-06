﻿using coreDox.Core.Contracts;

namespace coreDox.Target.Html
{
    public sealed class HtmlTarget : ITarget<HtmlConfig>
    {
        public void Write(string outputPath)
        {
            throw new System.NotImplementedException();
        }

        public IProject Project { get; set; }

        public HtmlConfig Config { get; set; }

        public string Name => "Html";
    }
}
