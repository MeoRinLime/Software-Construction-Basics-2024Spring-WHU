using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    class SimpleCrawler
    {
        private ConcurrentDictionary<string, bool> urls = new ConcurrentDictionary<string, bool>();
        private int count = 0;
        private static readonly int MaxPageCount = 100; // 最大下载页面数量
        private static readonly int ConcurrentTasks = 10; // 并行任务数量

        static async Task Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.TryAdd(startUrl, false); // 加入初始页面
            await myCrawler.Crawl();
        }

        private async Task Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            List<Task> tasks = new List<Task>();

            while (urls.Count < MaxPageCount && urls.Any(u => !u.Value))
            {
                var currentUrls = urls.Where(u => !u.Value).Take(ConcurrentTasks).ToList();
                foreach (var url in currentUrls)
                {
                    urls[url.Key] = true; // 标记为已处理
                    tasks.Add(ProcessUrl(url.Key));
                }

                if (tasks.Count >= ConcurrentTasks)
                {
                    await Task.WhenAny(tasks);
                    tasks = tasks.Where(t => !t.IsCompleted).ToList();
                }
            }

            // 等待所有任务完成
            await Task.WhenAll(tasks);
            Console.WriteLine("爬行结束");
        }

        private async Task ProcessUrl(string url)
        {
            try
            {
                Console.WriteLine("爬行" + url + "页面!");
                string html = await DownLoad(url);
                Parse(html);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error crawling {url}: {ex.Message}");
            }
        }

        public async Task<string> DownLoad(string url)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string html = await httpClient.GetStringAsync(url);
                string fileName = (++count).ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                string value = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (value.Length == 0) continue;
                if (!urls.ContainsKey(value)) urls.TryAdd(value, false);
            }
        }
    }
}
