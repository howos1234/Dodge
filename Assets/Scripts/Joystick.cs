using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//터치 시작(ipointerDownHandler), 터치 드래그, 터치 종료 이벤트 발생 시 처리

public class Joystick : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerUpHandler
{
    //드래그 시작했을 떄 호출
    
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
        
    }

    //터치가 끝났을 때
    public void OnPointerUp(PointerEventData eventData)
    {
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
