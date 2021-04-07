using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickPicker : MonoBehaviour
{
    public EventItemData pickup_itemdata;

	private void Update()
	{
        //UIのボタンクリックを優先する
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray();
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hit2d = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit2d.collider != null)
            {
                PickableItem pickableItem = hit2d.collider.GetComponent<PickableItem>();

                if (hit2d.collider.tag == "ToFront")
                {
                    GameMain.Instance.MoveFront();
                }
                else if (pickableItem != null)
                {
                    pickup_itemdata.Invoke(pickableItem.itemData);
                    Destroy(hit2d.collider.gameObject);
                }
            }
        }
    }
}




