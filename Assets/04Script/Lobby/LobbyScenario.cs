using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyScenario : MonoBehaviour
{
    // 메소드 호출을 위해 변수 선언
    [SerializeField]
    private UserInfo user;

    private void Awake()
    {
        // Login을 한 유저의 정보를 Lobby에 출력
        user.GetUserInfoFromBackend();
    }

    private void Start()
    {
        // Lobby 씬으로 왔을 때 데이터를 로드
        BackendGameData.Inst.GameDataLoad();
    }
}
