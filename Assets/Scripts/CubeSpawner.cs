using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public Transform cubeParent;
    public GameObject capsule;
    List<GameObject> cubeList = new List<GameObject>();

    void Start()
    {
        Destroy(capsule);
    }
    // Start is called before the first frame update
    public void CreatCubes()
    {
        /*var cube0 = Instantiate(cubePrefab);
        var cube1 = Instantiate(cubePrefab);
        var cube2 = Instantiate(cubePrefab);*/
        
        

        for(var i =0;i<5;i++)
        {
            var cube4 = Instantiate(cubePrefab,cubeParent);
            
            var x = Random.Range(-10.0f,10);
            var y = Random.Range(-10.0f,10);
            var z = Random.Range(-10.0f,10);
            cube4.transform.localPosition = new Vector3(x,y,z);
            cube4.transform.localScale = new Vector3(Random.Range(0.5f,1),Random.Range(0.5f,1),Random.Range(0.5f,1));

            cubeList.Add(cube4);
        }
        //큐브 참조를 저장하고 있어야 한다. 나중에 삭제 할 수 있도록
    }

    public void DestroyCubes()
    {
        foreach(var cube4 in cubeList)
        {
            Destroy(cube4);
        }

        cubeList.Clear();

        /*for(var i = 0;i<cubeList.Count;i++)
        {
            var cube = cubeList[i];
        }*/
    }

    public void DestroyLastCube()
    {
        var count = cubeList.Count;
        
        if(count <=0){
            return;
        }

        /*Destroy(cubeList[count-1]);
        cubeList.RemoveAt(count-1);*/

        var childCount = cubeParent.childCount;
        var cube = cubeParent.GetChild(childCount-1);
        Destroy(cube.gameObject);
        cubeList.RemoveAt(count-1);

    }
    
}
