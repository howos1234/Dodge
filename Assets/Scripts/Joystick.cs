using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//터치 시작(ipointerDownHandler), 터치 드래그, 터치 종료 이벤트 발생 시 처리

public class Joystick : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerUpHandler
{
    //드래그 시작했을 떄 호출
    public RectTransform rt;
    public Camera interfaceCam;
    public GameObject touchOrigin;
    public GameObject touchCurrent;
    Vector2 pointerDownPosition;
    //public GameObject player;
    Vector2 normalizedDirection;
    bool isDragging;


    //프로퍼티가 없다. 변수처럼 생겼다.
    //읽기 전용 변수를 만들 수 있다.
    public Vector2 NormalizedDirection
    {
        get
        {


            return isDragging ? normalizedDirection : Vector2.zero;
        }

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag");
        isDragging = true;
    }

    //드래그 중일떄 호출
    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("onDrag");
        var p = eventData.position;
        var d = p - pointerDownPosition;// 조작방향 벡터

        normalizedDirection = d.normalized; // d를 단위벡터로 만들어서  nd에 넣는다.

        var screenPoint = eventData.position;

        Vector3 worldPoint;
        var valid = RectTransformUtility.ScreenPointToWorldPointInRectangle(rt, screenPoint, interfaceCam, out worldPoint);
        if (valid) // 좌표 계산이 성공적일 떄만 처리
        {
            // 터치 오리진 오브젝트를 터치 위치로 옮겨준다.

            touchCurrent.transform.position = worldPoint;
        }


    }

    //드래그 끝났을 떄 호출
    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("onendDrag");
        isDragging = false;
    }

    // 터치 시작됬을 떄 호출
    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDown");
        pointerDownPosition = eventData.position;

        //touch origin 이미지를 터치 시작 위치로 옮긴다.
        var screenPoint = eventData.position;

        // 스크린 좌표를 touch origin gameobject의 월드 좌표로 변환한다.
        // 1. touch origin gameobject의 부모 오브젝트의 rect transform
        // 2. 변환 시킬 터치 위치
        // 3. 인터페이스용 카메라 위치
        Vector3 worldPoint; // 4. 변환된 좌표가 저장될 변수
        var valid = RectTransformUtility.ScreenPointToWorldPointInRectangle(rt, screenPoint, interfaceCam, out worldPoint);
        if (valid) // 좌표 계산이 성공적일 떄만 처리
        {
            // 터치 오리진 오브젝트를 터치 위치로 옮겨준다.
            touchOrigin.transform.position = worldPoint;
            touchCurrent.transform.position = worldPoint;
        }

        eventData.useDragThreshold = false;
    }

    //터치가 끝났을 때
    public void OnPointerUp(PointerEventData eventData)
    {
        pointerDownPosition = eventData.position;

        //touch origin 이미지를 터치 시작 위치로 옮긴다.
        var screenPoint = eventData.position;

        // 스크린 좌표를 touch origin gameobject의 월드 좌표로 변환한다.
        // 1. touch origin gameobject의 부모 오브젝트의 rect transform
        // 2. 변환 시킬 터치 위치
        // 3. 인터페이스용 카메라 위치
        Vector3 worldPoint; // 4. 변환된 좌표가 저장될 변수
        var valid = RectTransformUtility.ScreenPointToWorldPointInRectangle(rt, screenPoint, interfaceCam, out worldPoint);
        if (valid) // 좌표 계산이 성공적일 떄만 처리
        {
            // 터치 오리진 오브젝트를 터치 위치로 옮겨준다.
            
            touchOrigin.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            touchCurrent.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        }
        // Debug.Log("OnPointerUp");
    }

    // Start is called before the first frame update

    /*void Update()
    {
        if(isDragging == false)
        {
            return;
        }
        var dx = normalizedDirection.x;
        var dz = normalizedDirection.y;
        var pos = player.transform.localPosition;
        pos.x +=dx * Time.deltaTime;
        pos.z +=dz * Time.deltaTime;
        player.transform.localPosition = pos;
    }*/

}
