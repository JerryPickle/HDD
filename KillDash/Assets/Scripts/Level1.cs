using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{

    private Customer badguy;
    private PlayerController player;
    [SerializeField]private Customer[] customerSprites;


    // Start is called before the first frame update
    void Start()
    {
        reshuffle(customerSprites);

        badguy = customerSprites[0];
        badguy.CreateCustomer();


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void reshuffle(Customer[] bois)
    {
        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int t = 0; t < bois.Length; t++)
        {
            Customer tmp = bois[t];
            int r = Random.Range(t, bois.Length);
            bois[t] = bois[r];
            bois[r] = tmp;
        }
    }
}
