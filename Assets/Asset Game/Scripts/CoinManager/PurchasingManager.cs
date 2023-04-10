using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasingManager : MonoBehaviour
{
    public void OnPressDown(int i)
    {
        switch (i)
        {
            case 1:
                IAPManager.OnPurchaseSuccess = () =>
                    DirGameDataManager.Ins.playerData.AddDiamond(1);
                IAPManager.Ins.BuyProductID(Key.PACK1);
                break;
            case 2:
                IAPManager.OnPurchaseSuccess = () =>
                    DirGameDataManager.Ins.playerData.AddDiamond(2);
                IAPManager.Ins.BuyProductID(Key.PACK2);
                break;
            case 3:
                IAPManager.OnPurchaseSuccess = () =>
                    DirGameDataManager.Ins.playerData.AddDiamond(5);
                IAPManager.Ins.BuyProductID(Key.PACK3);
                break;
            case 4:
                IAPManager.OnPurchaseSuccess = () =>
                    DirGameDataManager.Ins.playerData.AddDiamond(10);
                IAPManager.Ins.BuyProductID(Key.PACK4);
                break;
            case 5:
                IAPManager.OnPurchaseSuccess = () =>
                    DirGameDataManager.Ins.playerData.AddDiamond(20);
                IAPManager.Ins.BuyProductID(Key.PACK5);
                break;
        }
    }

    public void Sub(int i)
    {
        DirGameDataManager.Ins.playerData.SubHelp(i);
    }
}