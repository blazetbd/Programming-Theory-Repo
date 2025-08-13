using UnityEngine;

public class Cylinder : Shape //INHERITANCE
{
    protected override void Start()
    {
        //ENCAPSULATION
        shapeName = "Cylinder";
        shapeColor = Color.yellow;
        colorName = "yellow";
        base.Start();
    }

    public override void DisplayText() //POLYMORPHISM
    {
        string textToDisplay = "This is a " + shapeName + ". It is a bright " + colorName + ".";
        Debug.Log(textToDisplay);
        text.text = textToDisplay;
    }
}
