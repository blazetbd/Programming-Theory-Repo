using UnityEngine;
using UnityEngine.UI;

public class Sphere : Shape //INHERITANCE
{
    protected override void Start()
    {
        //ENCAPSULATION
        shapeName = "Sphere";
        shapeColor = Color.red;
        colorName = "red";
        base.Start();
    }

    public override void DisplayText() //POLYMORPHISM
    {
        string textToDisplay = "This is a round " + shapeName + ". It is an intense " + colorName + ".";
        Debug.Log(textToDisplay);
        text.text = textToDisplay;
    }
}
