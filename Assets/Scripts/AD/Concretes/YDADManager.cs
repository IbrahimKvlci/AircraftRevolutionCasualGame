using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class YDADManager : IADService
{
    public void ShowAD()
    {
        YandexGame.FullscreenShow();
    }



    public void ShowRewardAD(IADService.RewardEnum rewardEnum)
    {
        switch (rewardEnum)
        {
            case IADService.RewardEnum.ContinueReward:
                YandexGame.RewVideoShow(1);
                break;
            default:
                break;
        }
    }
}
