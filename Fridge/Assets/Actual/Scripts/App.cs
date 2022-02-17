using Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    public CoroutineRunner CoroutineRunner;
    [SerializeField] private Transform GameField;
    public static RefrigeratorController RefrigeratorController;
    private void Awake()
    {
        var refrigeratorViewPrefab = Resources.Load<RefrigeratorView>("Prefabs/Fridge1");
        var view = GameObject.Instantiate(refrigeratorViewPrefab, new Vector3(-0.1231155f, 0.27f, -0.2213184f), Quaternion.identity, GameField);

        var controller = new RefrigeratorController();        

        controller.SetData(new RefrigeratorData());        
        controller.SetView(view);
                
        RefrigeratorController = controller;
        //ссылка на кликлистенер и в клик листенер метод сетконтроллер и в него кинуть рефрижератор колнтроллер 
    }
}
