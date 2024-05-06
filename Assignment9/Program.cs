using System;
using System.Collections.Concurrent;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    class SimpleCrawler
    {
        private ConcurrentDictionary<string, bool> urls = new ConcurrentDictionary<string, bool>();
        // 使用ConcurrentDictionary 来保证线程安全
        private int count = 0;
        static async Task Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.TryAdd(startUrl, false); //加入初始页面
            await myCrawler.Crawl(startUrl);                //开始爬行(异步)
        }

        private async Task Crawl(string baseUrl)
        {              // 异步关键字async
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (var url in urls)
                {
                    if (url.Value) continue;
                    current = url.Key;
                    break;
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = await DownLoad(current); // 异步下载
                urls[current] = true;
                count++;
                Parse(html, baseUrl); //解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        private async Task<string> DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;

                Console.WriteLine($"Downloading: {url}");

                string html = await webClient.DownloadStringTaskAsync(url);
                string fileName = count.ToString();

                // 输出下载相关信息
                Console.WriteLine($"Downloaded {fileName}. Content length: {html.Length}");

                await File.WriteAllTextAsync(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading {url}: {ex.Message}");
                return "";
            }
        }


        private void Parse(string html, string baseUrl)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0 || strRef.StartsWith("javascript")) continue;

                Uri result;
                if (!Uri.TryCreate(strRef, UriKind.Absolute, out result))
                {
                    if (!Uri.TryCreate(baseUrl, UriKind.RelativeOrAbsolute, out result)) continue;
                }

                if (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps)
                {
                    if (result.AbsolutePath.EndsWith(".zip"))
                    {
                        // 处理zip文件，仅需要时下载
                    }
                    else
                    {
                        if (!urls.ContainsKey(result.ToString())) urls.TryAdd(result.ToString(), false);
                    }
                }
            }
        }

    }
}