using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;

    // Use this for initialization
    void Start ()
    {
        this.myRigidbody2D = this.GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey ("up")) {
            this.myRigidbody2D.velocity += Vector2.up * 1f;
        }
    }
}
