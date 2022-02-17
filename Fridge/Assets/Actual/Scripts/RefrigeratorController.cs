using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefrigeratorController 
{
    private RefrigeratorView _view;
    private RefrigeratorData _data;
    public RefrigeratorData Data => _data;
    public void SetData(RefrigeratorData data)
    {
        _data = data;
    }
    public void SetView(RefrigeratorView view)
    {        
        _view = view;
        _view.SetData(_data);
    }
    public void OpenDoor()
    {
        _data.isOpenUpperDoor.Value = true;
    }
    public void CloseDoor()
    {
        _data.isOpenUpperDoor.Value = false;
    }
    private void ChangeTemp()
    {
        _data.temperature.Value = 12;
    }
    private void TurnOnFridge()
    {
        _data.isTurnOn.Value = true;
    }
    private void TurnOffFridge()
    {
        _data.isTurnOn.Value = false;
    }
    private void TurnOnLight()
    {
        _data.isLight.Value = false;
    }
    private void TurnOffLight()
    {
        _data.isLight.Value = false;
    }    


}
