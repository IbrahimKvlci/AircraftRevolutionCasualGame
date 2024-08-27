using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IADService
{
    enum RewardEnum
    {
        ContinueReward,
    }

    void ShowAD();
    void ShowRewardAD(RewardEnum rewardEnum);
}
