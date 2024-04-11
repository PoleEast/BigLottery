using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BigLottery
{
    internal class web_crawler
    {
        private readonly string url = "https://www.taiwanlottery.com/lotto/result/lotto649";

        public async Task<string> browser_site()
        {
            using (HttpClient client = new HttpClient())
            {
                string html = await client.GetStringAsync(url);
                string result = "";
                // 使用 AngleSharp 的 HTML 解析器解析 HTML 內容
                var parser = new HtmlParser();
                var document = await parser.ParseDocumentAsync(html);

                // 提取所有標題並輸出
                var titles = document.QuerySelectorAll("span.data-v-f4150883");
                foreach (var title in titles)
                {
                    result += title.TextContent + "\n";
                }
                return result;
            }
        }
    }
}
