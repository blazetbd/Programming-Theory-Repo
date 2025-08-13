using UnityEngine;

public class Cylinder : Shape
{
    protected override void Start()
    {
        shapeName = "Cylinder";
        shapeColor = Color.yellow;
        base.Start();
    }

    public override void DisplayText()
    {
        Debug.Log("This is a " + shapeName + ". It is a bright " + shapeColor + ".");
    }
}
