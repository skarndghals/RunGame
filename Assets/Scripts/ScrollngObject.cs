using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollngObject : MonoBehaviour
{
    public float speed = 10f;


    void Update()
    {
        if (!GameManager.instance.isGameover)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            speed = 20f;
        }else if (Input.GetMouseButtonUp(1))
        {
            speed = 10f;
        }
    }

}
