using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] string testString = "A string is just text";
    bool testBool = false; // true or false
    int testInt = 5; // Whole numbers

    // I need to get this from another script, WITHOUT making it public! How? (See below)
    float testFloat = 6.7f; // Numbers with decimals

    // TYP NAMN VÄRDE
    // NAMN = Vad det är, och vad det gör
    // T.ex spelarens movement "playerMovement"

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetTestFloat() // Called a Getter-method/function
    {
        return testFloat; // Only GETS the value, cannot SET the value
    }
}
