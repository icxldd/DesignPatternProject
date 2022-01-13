namespace FacePattern.Core
{
    public class PlayFace
    {
        private readonly GoodsManager _goodsManager;
        private readonly WalletManager _walletManager;

        public PlayFace()
        {
            _goodsManager =new GoodsManager();
            _walletManager = new WalletManager();
        }

        public void Buy()
        {
            _goodsManager.Buy();
            _walletManager.Buy();
        }
    }
}