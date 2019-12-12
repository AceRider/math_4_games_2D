using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject tank;
    public GameObject fuel;
    public Text tankPosition;
    public Text fuelPosition;

    void Start()
    {
        tankPosition.text = tank.transform.position + "";
    }

    void Update()
    {
        
    }
}
