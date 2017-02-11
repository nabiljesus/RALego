using UnityEngine;
using System.Collections;

public class carritoMovement : MonoBehaviour {

    public float speed;
    public float directionx;
    public float directionz;
    public Rigidbody carrito;
    public float[] init_pos = {0.1f,0,-0.035f};
    public float[] init_rot = { 90f, 90f, -90f };

    public Vector3 initial_v;

	// Use this for initialization
	void Start () {
        //initial_t = this.transform;
        initial_v = this.transform.localPosition;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKeyDown("r"))
        {
            this.transform.localPosition = initial_v;
        }

        Vector3 v = new Vector3(speed * directionx, 0, speed * directionz);
        carrito.velocity = v;
	}

    void OnTriggerEnter(Collider other)
    {
        //directionx *= -1;
        //directionz *= -1;
        float temp = directionz;
        directionz = directionx;
        directionx = temp;
        
        Debug.LogError("TOTONA");
        Debug.LogWarning(other.transform.parent.gameObject.tag);
    }
}

