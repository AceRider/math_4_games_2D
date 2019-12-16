using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{
    #region Course 3
    // public float speed = 10.0f;
    // public float rotationSpeed = 100.0f;
    // public Text energyAmt;
    // Vector3 currentLocation;

    //private void Start()
    //{
    //    currentLocation = this.transform.position;
    //}

    //void Update()
    //{
    //    if (float.Parse(energyAmt.text) <= 0) return;

    //    // Get the horizontal and vertical axis.
    //    // By default they are mapped to the arrow keys.
    //    // The value is in the range -1 to 1
    //    float translation = Input.GetAxis("Vertical") * speed;
    //    float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

    //    // Make it move 10 meters per second instead of 10 meters per frame...
    //    translation *= Time.deltaTime;
    //    rotation *= Time.deltaTime;

    //    // Move translation along the object's z-axis
    //    transform.Translate(0, translation, 0);

    //    // Rotate around our y-axis
    //    transform.Rotate(0, 0, -rotation);

    //    energyAmt.text = (float.Parse(energyAmt.text) - Vector3.Distance(currentLocation, this.transform.position)) + "";

    //    currentLocation = this.transform.position;
    //}
    #endregion
    #region Course 4

    //Vector3 Up = new Vector2(0, 1);
    //Vector3 Right = new Vector2(1, 0);
    //float speed = 0.8f;
    //private void Update()
    //{
    //    Vector3 position = this.transform.position;
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        position.x += Up.x * speed;
    //        position.y += Up.y * speed;
    //    }
    //    else if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        position.x += -Up.x * speed;
    //        position.y += -Up.y * speed;
    //    }
    //    else if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        position.x += -Right.x * speed;
    //        position.y += -Right.y * speed;
    //    }
    //    else if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        position.x += Right.x * speed;
    //        position.y += Right.y * speed;
    //    }
    //    this.transform.position = position;
    //}
    #endregion
    #region Course 4.27
    float speed = 5;
    public GameObject fuel;
    Vector3 direction;
    float stoppingDistance = 0.1f;

    private void Start()
    {
        direction = fuel.transform.position - this.transform.position;
        Coords dirNormal = HolisticMath.GetNormal(new Coords(direction));
        direction = dirNormal.ToVector();
        float a = HolisticMath.Angle(new Coords(0, 1, 0), new Coords(direction)) * 180.0f / Mathf.PI;
        //Debug.Log("Angle to fuel:" + a);
        Coords newDir = HolisticMath.Rotate(new Coords(0, 1, 0), a);
        this.transform.up = new Vector3(newDir.x, newDir.y, newDir.z);
    }

    private void Update()
    {
        if(HolisticMath.Distance(new Coords(this.transform.position),
                                    new Coords(fuel.transform.position)) > stoppingDistance)
        if(Vector3.Distance(this.transform.position, fuel.transform.position) > stoppingDistance)
            this.transform.position += direction * speed * Time.deltaTime;  
    }

    #endregion

}