using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RefrigeratorView : MonoBehaviour
{
    [SerializeField] private Transform upperDoor;
    [SerializeField] private Transform lowerDoor;
    [SerializeField] private Transform drawerLower; 
    [SerializeField] private Transform drawerUpper;
    [SerializeField] private Transform lightbulb;
    [SerializeField] private Transform button;
    [SerializeField] private TMP_Text temperatureText;//!!!!!!!!!!!!!!

    private RefrigeratorData _data;

    public void SetData(RefrigeratorData data)
    {        
        if(_data!=null)
        {
            _data.isLight.UpdateEvent -= IsLight_UpdateEvent;
            _data.isOpenLowerDoor.UpdateEvent -= IsOpenLowerDoor_UpdateEvent;
            _data.isOpenUpperDoor.UpdateEvent -= IsOpenUpperDoor_UpdateEvent;
            _data.isOpenLowerDrawer.UpdateEvent -= IsOpenLowerDoor_UpdateEvent;
            _data.isOpenUpperDrawer.UpdateEvent -= IsOpenUpperDoor_UpdateEvent;
            _data.isTurnOn.UpdateEvent -= IsTurnOn_UpdateEvent;
            //_data.food.UpdateEvent -= Food_UpdateEvent;
            //_data.temperature.UpdateEvent -= Temp_UpdateEvent;   
        }
        _data = data;

        _data.isLight.UpdateEvent += IsLight_UpdateEvent;
        _data.isOpenLowerDoor.UpdateEvent += IsOpenLowerDoor_UpdateEvent;
        _data.isOpenUpperDoor.UpdateEvent += IsOpenUpperDoor_UpdateEvent;
        _data.isOpenLowerDrawer.UpdateEvent += IsOpenUpperDoor_UpdateEvent;
        _data.isOpenUpperDrawer.UpdateEvent += IsOpenUpperDoor_UpdateEvent;
        _data.isTurnOn.UpdateEvent += IsTurnOn_UpdateEvent;
        //_data.food.UpdateEvent += Food_UpdateEvent;
        //_data.temperature.UpdateEvent += Temp_UpdateEvent;        
    }
    private void IsLight_UpdateEvent(bool isVal)
    {
        lightbulb.gameObject.SetActive(isVal);
    }
    private void IsOpenLowerDoor_UpdateEvent(bool isVal)
    {
        lowerDoor.gameObject.SetActive(isVal);
    }
    private void IsOpenUpperDoor_UpdateEvent(bool isVal)
    {        
        upperDoor.gameObject.SetActive(isVal);        

    }
    private void IsOpenLowerDrawer_UpdateEvent(bool isVal)
    {
        drawerLower.gameObject.SetActive(isVal);
    }
    private void IsOpenUpperDrawer_UpdateEvent(bool isVal)
    {
        drawerUpper.gameObject.SetActive(isVal);
    }
    private void IsTurnOn_UpdateEvent(bool isVal)
    {
        button.gameObject.SetActive(isVal);
    }    
    /*private void Food_UpdateEvent(string food)
    {
        //lightbulb.gameObject.SetActive(isVal);
    }*/
    private void Temp_UpdateEvent(int temperature)
    {
        temperatureText.text= temperature.ToString();
    }    
    //создать корутину и по нажатию отслеживать на что нажали и изменять дату
   
}
