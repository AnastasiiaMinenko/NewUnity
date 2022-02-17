using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickListener : MonoBehaviour
{    
    private void Update()
    {
        if (Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);            

            if(Physics.Raycast(ray, out RaycastHit hitInfo, 1<<6))
            {
                var clickID = hitInfo.collider.GetComponent<ClickID>();
                if(clickID)
                {
                    OnClick(clickID.ID);
                    Debug.Log(clickID.ID);
                }                
            }            
        }
    }
    private void OnClick(string id)
    {
        if(id=="UpperDoor")
        {
            if(App.RefrigeratorController.Data.isOpenUpperDoor.Value == true)
            {
                App.RefrigeratorController.CloseDoor();
            }
            else
            {
                App.RefrigeratorController.OpenDoor();
            }
           
        }     
        
    }
    //создать монобех с ИД(кликабельные компоненты)(стринги)
}
