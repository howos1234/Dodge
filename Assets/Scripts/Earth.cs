
using UnityEngine;

public class Earth : MonoBehaviour
{
    public GameObject earth;

    void Start()
    {
        var color = earth.GetComponent<MeshRenderer>().materials[1].mainTexture;
    }

   
    void Update()
    {
        earth.transform.Rotate(0,5,0);
    }
}
