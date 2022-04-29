using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadLock1
{
    public partial class Form1 : Form
    {
        /***
         * C#中async的死锁分析和解决方案
         * 地址：https://www.imzjy.com/blog/dotnet-async-locks-and-solutions
         * 
         * ***/
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var task = GetContentAsync();
            var content = task.Result;

            this.label1.Text = content;
        }

        public async Task<string> GetContentAsync()
        {
            var http = new HttpClient();
            //var result = await http.GetStringAsync("http://www.imzjy.com");
            var result = await http.GetStringAsync("http://www.baidu.com");

            var first50 = result.Substring(0, 50);
            return first50;
        }
    }
}
