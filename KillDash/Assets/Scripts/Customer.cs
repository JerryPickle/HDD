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
    SpriteRenderer thisSprite;

    private void CreateCustomer()
    {

        mood = waitTimes[Random.Range(0, 2)];
        howTip = ((Tips)Random.Range(0, 2)).ToString("g");
        int numDrink = Random.Range(0, 4);
        favDrink = ((Drinks)numDrink).ToString("g");
        int numPizza = Random.Range(0, 4);
        favPizza = ((Pizza)numPizza).ToString("g");
        favSideFood = ((SideFood)Random.Range(0, 4)).ToString("g");
        int newNumPizza = Random.Range(0, 4);
        int newNumDrink = Random.Range(0, 4);

        while (newNumPizza == numPizza)
        {
            newNumPizza = Random.Range(0, 4);
        }
        hatePizza = ((Pizza)newNumPizza).ToString("g");

        while (newNumDrink == numDrink)
        {
            newNumDrink = Random.Range(0, 4);
        }
        hateDrink = ((Drinks)newNumDrink).ToString("g");

        /*print(mood);
        print(howTip);
        print(favDrink);
        print(favPizza);
        print(favSideFood);
        print(hatePizza);
        print(hateDrink);*/

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
