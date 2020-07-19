using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.AspNetCore.Html;
using Microsoft.DotNet.Interactive.Formatting;

namespace Vega.Charts
{
    public class VegaChart
    {
        public Guid Id
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get;
        }

        public string Title
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get;
        }

        public Schema.Specification Specification
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get;
        }

        public double? Width
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Specification.Width; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { Specification.Width = value; }
        }

        public double? Height
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Specification.Height; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { Specification.Height = value; }
        }

        #region Constructors

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        protected VegaChart(string title,
                            Guid?  id = null)
        {
            Title = title;

            if(id == null)
            {
                Id = Guid.NewGuid();
            }
            else if(Id == Guid.Empty)
            {
                Id = id.Value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VegaChart(string               title,
                         Schema.Specification vegaLiteSpecification,
                         Guid?                id = null)
            : this(title,
                   id)
        {
            Specification = vegaLiteSpecification;
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return GetHtml();
        }

        public static           string VegaUrl = "https://cdn.jsdelivr.net/npm/vega";
        private static readonly string LE      = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "\r\n" : "\n";

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string GetHtmlContent()
        {
            string uid = Id.ToString().Replace("-",
                                               "");

            string content = $"        <div id=\"{uid}\">{LE}"                                         +
                             $"            <h1>{Title}</h1>{LE}"                                       +
                             $"            <div id=\"vis-{uid}\" class=\"view\">{LE}"                  +
                             $"                <script language=\"javascript\">{LE}"                   +
                             $"                    const spec = {Specification.ToJson()};{LE}"         +
                             $"                    const runtime = vega.parse(spec);{LE}"              +
                             $"                    const view = new vega.View(runtime){LE}"            +
                             $"                                       .logLevel(vega.Error){LE}"       +
                             $"                                       .initialize(\"#vis-{uid}\"){LE}" +
                             $"                                       .renderer(\"svg\"){LE}"          +
                             $"                                       .hover();{LE}"                   +
                             $"                    view.runAsync();{LE}"                               +
                             $"                </script>{LE}"                                          +
                             $"            </div>{LE}"                                                 +
                             $"        </div>{LE}";

            return content;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string GetHtml()
        {
            string html = $"<!DOCTYPE html>{LE}"                                                      +
                          $"<html>{LE}"                                                               +
                          $"    <head>{LE}"                                                           +
                          $"        <meta charset=\"utf-8\" />{LE}"                                   +
                          $"        <script type=\"text/javascript\" src=\"{VegaUrl}\"></script>{LE}" +
                          $"    </head>{LE}"                                                          +
                          $"    <body>{LE}"                                                           +
                          $"{GetHtmlContent()}{LE}"                                                   +
                          $"    </body>{LE}"                                                          +
                          $"</html>{LE}";

            return new HtmlString(html).ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void ShowInBrowser()
        {
            string tempPath = Path.GetTempPath();
            string path     = $"{Id}.html";

            string text = Path.Combine(tempPath,
                                       path);

            File.WriteAllText(text,
                              GetHtml());

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = text, UseShellExecute = true
                };

                Process p = Process.Start(startInfo);

                if(p != null)
                {
                    p.EnableRaisingEvents = true;
                    p.WaitForInputIdle();
                }

                return;
            }

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open",
                              text);

                return;
            }

            if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open",
                              text);

                return;
            }

            throw new InvalidOperationException("Not supported OS platform");
        }
    }
}
