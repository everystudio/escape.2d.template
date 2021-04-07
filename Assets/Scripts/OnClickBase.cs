using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickBase : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray();
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hit2d = Physics2D.Raycast(ray.origin, ray.direction);
            if( hit2d.collider != null)
            {
                Debug.Log(hit2d.collider.gameObject.name);
            }
        }
    }
}
