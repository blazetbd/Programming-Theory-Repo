using UnityEngine;

public class Cube : Shape
{
    protected override void Start()
    {
        shapeName = "Cube";
        shapeColor = Color.blue;
        colorName = "blue";
        base.Start();
    }

    public override void DisplayText()
    {
        Debug.Log("This is a " + shapeName + ". It is a normal, boring " + colorName + ".");
    }
}
