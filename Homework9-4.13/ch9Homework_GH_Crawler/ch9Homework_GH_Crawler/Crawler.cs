using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ch9Homework_GH_Crawler
{
    class SimpleCrawler
    {
        public Hashtable urls = new Hashtable();
        private Hashtable nextUrls = new Hashtable();

        private int count = 0;
        static void Main_Crawler(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);        //加入初始页面
            new Thread(myCrawler.Crawl).Start();        //开始爬行

        }

        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                
                foreach (string url in urls.Keys)   //找到一个还没有下载过的链接
                {
                    if ((bool)urls[url]) continue;  //已经下载过的，不再下载
                    current = url;
                    break;
                }
                if(current == null)
                {
                    foreach(string url in nextUrls.Keys)
                    {
                        Console.WriteLine((string)url);
                    }
                    //urls = nextUrls;
                    //nextUrls = null;
                    break;
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current);    // 下载
                urls[current] = true;
                count++;
                Parse(html,current);                        //解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html,string current)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');

                if (strRef.Length == 0) continue;

                Uri uri = new Uri(current);
                string CurrentURL1 = "http://" + uri.Host;
                string CurrentURL2 = "https://" + uri.Host;
                if (Regex.IsMatch(strRef, "^[/]"))
                {
                    strRef = CurrentURL1 + strRef;
                }
                else if (Regex.IsMatch(strRef, "^[http|HTTP|https|HTTPS]") == false)
                {
                    strRef = current + "/" + strRef;
                }

                if (Regex.IsMatch(strRef, CurrentURL1) == false && Regex.IsMatch(strRef,CurrentURL2)==false)
                    continue;

                if (!Regex.IsMatch(strRef, "(.html|.HTML)")) continue;

                //if (urls[strRef] == null) urls[strRef] = false;
                if (nextUrls[strRef] == null) 
                    nextUrls[strRef] = false; 
            }
        }
    }
}
