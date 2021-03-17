using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodOrder : MonoBehaviour
{

    public string pizza;
    public string drink;
    public string side;

    public void CreateOrder(string piz, string dri, string si)
    {
        pizza = piz;
        drink = dri;
        side = si;
    }

    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
