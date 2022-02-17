using Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common.Tools.Data;
using Scripts.Core.Data;

public class RefrigeratorData 
{
    private RefrigeratorView _view;
        
    public ActiveData<bool> isLight = new ActiveData<bool>();
    public ActiveData<bool> isTurnOn = new ActiveData<bool>();
    public ActiveData<bool> isOpenUpperDoor = new ActiveData<bool>();
    public ActiveData<bool> isOpenLowerDoor = new ActiveData<bool>();
    public ActiveData<bool> isOpenLowerDrawer = new ActiveData<bool>();
    public ActiveData<bool> isOpenUpperDrawer = new ActiveData<bool>();
    public ActiveListData<string> food = new ActiveListData<string>();
    public ActiveData<int> temperature = new ActiveData<int>();
}
