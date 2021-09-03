using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace NetTXTEZ
{
    public partial class Form1 : Form
    {
        bool isdoing = true;
        public Form1()
        {
            InitializeComponent();

        }

        private void b_start_Click(object sender, EventArgs e)
        {
            int tmp;
            if (int.TryParse(t_input.Text, out tmp) && int.TryParse(t_first.Text, out tmp))
            {
                isdoing = true;
                b_start.Enabled = false;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text文档（*.txt）|*.txt";
                sfd.FilterIndex = 1;
                sfd.RestoreDirectory = true;




                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.filepath = sfd.FileName.ToString();
                    Properties.Settings.Default.Save();
                    CheckForIllegalCrossThreadCalls = false;
                    Thread tr = new Thread(mainp);
                    tr.IsBackground = true;
                    tr.Start();
                    Thread tr_pic = new Thread(getimg);
                    tr_pic.IsBackground = true;
                    tr_pic.Start();
                }
                else
                {
                    MessageBox.Show("取消保存");
                    b_start.Enabled = true;
                    return;
                }

            }
            else
                MessageBox.Show("出现非法字符，请输入整数(int)");


        }



        private void mainp()
        {
            int getindex = 1;
            string mainlink = "https://www.extree.cn/xiaoshuo/" + t_input.Text + "/0.html";
            string startlink = "https://www.extree.cn/xiaoshuo/" + t_input.Text + "/" + t_first.Text + ".html";
            string html = back_html(startlink);
            string nextpage = getnextlink(html);


            FileStream fs = new FileStream(Properties.Settings.Default.filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            if(!Properties.Settings.Default.tog_conti)
                fs.SetLength(0);//首先把文件清空了。
            else
                sw.Write("\n");

            sw.Write(backnew(html));//写你的字符串。
            string gottxt;


            while (nextpage != mainlink)
            {

                if (nextpage != "" && nextpage != mainlink && isdoing)
                {
                    getindex++;
                    html = back_html(nextpage);
                    nextpage = getnextlink(html);
                    gottxt = backnew(html);
                    sw.Write(gottxt);
                    label2.Text = getindex.ToString() + "章";
                    t_output.Text = gottxt;
                }
                else
                {
                    sw.Write("\n==================================================");
                    sw.Write("\n米花提供小说网站爬虫工作，原文章请见：" + mainlink);
                    sw.Write("\n==================================================");
                    if(isdoing)
                        label2.Text = getindex.ToString() + "章，已完成！";
                    else
                    {
                        label2.Text = getindex.ToString() + "章，已停止！";
                        t_output.Text = "已在" + getindex.ToString() + "停止，继续请将写入模式调为中继模式并输入下一章链接：" + nextpage;
                    }


                    break;
                }


            }
            b_start.Enabled = true;
            sw.Close();


        }

        string back_html(string url)
        {
            if (url == "")
            {
                return "System.UriFormatException:“无效的 URI: 此 URI 为空”";
            }

            bool got = false;
            Stream myResponseStream = null;
            for (int i=0;i<Properties.Settings.Default.maxtry&&got==false;i++)
            {
                bool haserror = false;
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                    //GET请求
                    request.Method = "GET";
                    request.ReadWriteTimeout = 5000;
                    request.ContentType = "text/html";

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    myResponseStream = response.GetResponseStream();


                }
                catch (WebException)
                {
                    haserror = true;
                    label2.Text = "发生了502错误,尝试中：" + i + "/" + Properties.Settings.Default.maxtry;
                    myResponseStream = null;
                    Thread.Sleep(1000);


                }
                finally
                {
                    if(haserror)
                        got= false;
                    else
                        got= true;
                }

            }

            if (got)
            {
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("gbk"));

                //返回内容
                string retString = myStreamReader.ReadToEnd();
                myResponseStream.Close();
                return retString;

            }
            else
                return "";
        }

        string backnew(string html)
        {
            if (html == "")
            {
                return "System.UriFormatException:“无效的 htmldoc: 此 htmldoc 为空。”";
            }
            string sometxt="";

            //获取文档
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            //返回文字
            HtmlNodeCollection contentNodes = doc.DocumentNode.SelectNodes("//div[@id='content']");
            if (contentNodes != null)
            {
                foreach (var item in contentNodes)
                {

                    sometxt = item.InnerText.Replace("&nbsp;&nbsp;", string.Empty).Replace("天才一秒记住本站地址：www.extree.cn", string.Empty).Replace("笔趣阁手机版阅读网址：m.extree.cn", string.Empty);

                }
            }
            return sometxt;
        }

        string getnextlink(string html)
        {
            string link = "";

            //获取文档
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            //返回文字
            HtmlNodeCollection contentNodes = doc.DocumentNode.SelectNodes("//div[@class='bottem2']/a[position()=3]");
            if (contentNodes != null)
            {
                foreach (var item in contentNodes)
                {
                    link = RemoveLeft(item.OuterHtml, 9);
                    link = "https://www.extree.cn" + RemoveRight(link, 9);

                }

            }

            return link;
        }

        void getimg()
        {

            //获取文档
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(back_html("https://www.extree.cn/xiaoshuo/" + t_input.Text + "/0.html"));
            //返回文字
            HtmlNodeCollection contentNodes = doc.DocumentNode.SelectNodes("//div[@id='fmimg']/img");
            if (contentNodes != null)
            {
                foreach (var item in contentNodes)
                {
                    HtmlAttribute att = item.Attributes["src"];
                    try
                    {
                        picbox.LoadAsync("https:" + att.Value);

                    }
                    catch (WebException)
                    {

                    }

                }

            }

        }

        public static string RemoveLeft(string s, int len)
        {
            return s.PadLeft(len).Remove(0, len);
        }
        public static string RemoveRight(string s, int len)
        {
            s = s.PadRight(len);
            return s.Remove(s.Length - len, len);
        }

        private void t_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.extree.cn/"); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_opensettings_Click(object sender, EventArgs e)
        {
            new settings().ShowDialog();
        }

        private void b_stop_Click(object sender, EventArgs e)
        {
            isdoing = false;
        }
    }
}
