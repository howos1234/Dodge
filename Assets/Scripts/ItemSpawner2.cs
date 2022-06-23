using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner2 : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform itemposition;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InstantiateCubeEvery1Sec());   
    }

    // Update is called once per frame
    // 1초마다 item 프리팹 생성하는 코루틴
    
  IEnumerator InstantiateCubeEvery1Sec()
  {
    for(int i=0;i<50;i++)
    {
    Instantiate(itemPrefab,itemposition);
    var x = Random.Range(-50.0f,50);
    var z = Random.Range(-50.0f,50);
    itemPrefab.transform.localPosition= new Vector3(x,0,z);

    yield return new WaitForSeconds(1.0f);
    }
  }
}
