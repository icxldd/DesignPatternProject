namespace AdapterPattern.BaiDuCloud
{
    public interface IBaiDuTarget
    {
        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="qps"></param>
        void Download();

        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="qps"></param>
        void Upload();
    }
}