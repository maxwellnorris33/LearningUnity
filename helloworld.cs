using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloworld : MonoBehaviour
{
    public string myMessageOne;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myMessageOne);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(myMessageOne);
    }
}
