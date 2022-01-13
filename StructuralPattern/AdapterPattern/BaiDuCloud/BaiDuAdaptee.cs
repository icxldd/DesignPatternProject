using System;

namespace AdapterPattern.BaiDuCloud
{
    public class BaiDuAdaptee
    {
        public void Download(int qps)
        {
            Console.WriteLine($"正在以每秒{qps}字节下载文件....");
        }

        public void Upload(int qps)
        {
            Console.WriteLine($"正在以每秒{qps}字节上传文件....");
        }
    }
}