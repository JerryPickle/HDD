using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    int[] waitTimes = { 55, 45, 35 };
    enum Tips {Extra, Normal, None}
    enum Drinks {Coke, Juice, Milkshake, Orange_Juice, Garlic_Juice}
    enum Pizza {Cheese, Pepperoni, Pineapple, Meat_Lovers, The_Garlic_Special}
    enum SideFood {Fries,Tots,Chips,Breadsticks,The_Garlic_Surprise}

    int mood;
    string howTip;
    string favDrink;
    string favPizza;
    string favSideFood;
    string hatePizza;
    string hateDrink;

    private void CreateCustomer()
    {

        mood = waitTimes[Random.Range(0, 2)];



    }

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
