using PlayFab;
using PlayFab.ClientModels;
using System.Collections.Generic;
using UnityEngine;

public class PlayFabController : MonoBehaviour
{
    void Start()
    {
        PlayFabClientAPI.LoginWithCustomID(
            new LoginWithCustomIDRequest { CustomId = "GettingStartedGuide", CreateAccount = true }
        , result => Debug.Log("���߂łƂ��������܂��I���O�C�������ł��I")
        , error => Debug.Log("���O�C�����s...(�L�G�ցG�M)"));
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SubmitScore(40);
        }

    }

    void SubmitScore(int playerScore)
    {
        PlayFabClientAPI.UpdatePlayerStatistics(
            new UpdatePlayerStatisticsRequest
            {
                Statistics = new List<StatisticUpdate>()
                {
                    new StatisticUpdate
                    {
                        StatisticName = "HighScoe",
                        Value = playerScore
                    }
                }
            },
            result =>
            {
                Debug.Log("�X�R�A���M");
            },
            error =>
            {
                Debug.Log(error.GenerateErrorReport());
            }
            );
    }

}