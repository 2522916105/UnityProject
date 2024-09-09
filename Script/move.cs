using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("****开始测试****");
        GameObject obj = this.gameObject;
        string name=obj.name;
        Debug.Log("****物体名字****"+name);
        Transform trans=obj.transform;
        Vector3 position = trans.position;
        Debug.Log("****物体位置****"+position);
        Debug.Log("123");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
