using System;
using System.Collections.Generic;
using Flow.Launcher.Plugin;

namespace Flow.Launcher.Plugin.PoiPoiClipboard
{
    public class PoiPoiClipboard : IPlugin
    {
        private PluginInitContext _context;

        public void Init(PluginInitContext context)
        {
            _context = context;
        }

        public List<Result> Query(Query query)
        {
            var result = new Result
            {
                Title = "Poi Poi Clipboard",
                SubTitle = "Clear the clipboard with one command",
                Action = c =>
                {
                    System.Windows.Clipboard.Clear();
                    return true;
                },
                IcoPath = "Images/icon.png"
            };
            
            return new List<Result> { result };
        }
    }
}