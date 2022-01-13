using System;

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

    public class GoodsManager
    {
        public void Buy()
        {
            Console.WriteLine("商品下单");
        }
    }

    public class WalletManager
    {
        public void Buy()
        {
            Console.WriteLine("钱包下单");
        }
    }

}