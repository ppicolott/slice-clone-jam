using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    void Update()
    {
        transform.position = GameObject.Find("Tip").transform.position + new Vector3(-1.2f, 1f, -4.5f);
    }
}
