using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using TMPro;

public class TextInteraction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [System.Serializable]
    private class OnClickEvent : UnityEvent { }

    // Text UI를 클릭했을 때 호출하는 메소드
    [SerializeField]
    private OnClickEvent onClickEvent;

    // 색상이 바뀌고 터치가 되는 TextMeshProUGUI
    private TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.fontStyle = FontStyles.Bold;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.fontStyle = FontStyles.Normal;
    }

    // 각 오브젝트마다 event를 다르게 넣기
    public void OnPointerClick(PointerEventData eventData)
    {
        // onClickEvent에 등록해둔 메소드 실행(?를 붙여 null인지 확인)
        onClickEvent?.Invoke();
    }
}
