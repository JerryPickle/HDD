using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{


    public List<Customer> CustomersList = new List<Customer>();
    private Customer badguy;
    private PlayerController player;
    int currentCustomers = 0;
    public Customer[] customerPrefabs;
    [SerializeField]public int decoyRangeMax = 3;
    [SerializeField]public int decoyRangeMin = 1;
    [SerializeField] public int totalCustomers = 20;
    

    // Start is called before the first frame update
    void Start()
    {
        InitializeGame();

    }


    void InitializeGame()
    {

        // This function will create all of the games customers at random, it will also make a list with all of the customers, and it will make arrays of each trait type decoy.
        // We can use these arrays to help decide what clues are good/bad/really too good of a clue, by seeing how many decoys are in each array.
        
        // Create the Baddy at Complete Random, and add him to a Mast list of Customers.
        badguy.CreateCustomer();
        CustomersList.Add(badguy);
        currentCustomers++;


        //Create at least one other person that shares the same trait for every trait, and also add them to the list.
        int favPizzaDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < favPizzaDecoys; i++)
        {
            Customer newCustomer;
            newCustomer = customerPrefabs[currentCustomers];
            newCustomer.CreateCustomer();
            newCustomer.favPizza = badguy.favPizza;
            CustomersList.Add(newCustomer);
            currentCustomers++;
        }

        int favDrinkDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < favDrinkDecoys; i++)
        {
            Customer newCustomer;
            newCustomer = customerPrefabs[currentCustomers];
            newCustomer.CreateCustomer();
            newCustomer.favDrink = badguy.favDrink;
            CustomersList.Add(newCustomer);
            currentCustomers++;
        }

        int favSideDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < favSideDecoys; i++)
        {
            Customer newCustomer;
            newCustomer = customerPrefabs[currentCustomers];
            newCustomer.CreateCustomer();
            newCustomer.favSideFood = badguy.favSideFood;
            CustomersList.Add(newCustomer);
            currentCustomers++;
        }

        int HatePizzaDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < HatePizzaDecoys; i++)
        {
            Customer newCustomer;
            newCustomer = customerPrefabs[currentCustomers];
            newCustomer.CreateCustomer();
            newCustomer.hatePizza = badguy.hatePizza;
            CustomersList.Add(newCustomer);
            currentCustomers++;
        }

        int HateDrinkDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < HateDrinkDecoys; i++)
        {
            Customer newCustomer;
            newCustomer = customerPrefabs[currentCustomers];
            newCustomer.CreateCustomer();
            newCustomer.hateDrink = badguy.hateDrink;
            CustomersList.Add(newCustomer);
            currentCustomers++;
        }

        int HowTipDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < HowTipDecoys; i++)
        {
            Customer newCustomer;
            newCustomer = customerPrefabs[currentCustomers];
            newCustomer.CreateCustomer();
            newCustomer.howTip = badguy.howTip;
            CustomersList.Add(newCustomer);
            currentCustomers++;
        }

        int MoodDecoys = Random.Range(decoyRangeMin, decoyRangeMax);

        for (int i = 0; i < MoodDecoys; i++)
        {
            Customer newCustomer;
            newCustomer = customerPrefabs[currentCustomers];
            newCustomer.CreateCustomer();
            newCustomer.mood = badguy.mood;
            CustomersList.Add(newCustomer);
            currentCustomers++;
        }


        // Figure out how many Customers are left to fill the roster and create that many at random. Then add them to the list.

        int customersRemaining = totalCustomers - currentCustomers;

        for (int i = 0; i < customersRemaining; i++)
        {
            Customer newCustomer;
            newCustomer = customerPrefabs[currentCustomers];
            newCustomer.CreateCustomer();
            CustomersList.Add(newCustomer);
            currentCustomers++;

        }
        
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }


   
}
