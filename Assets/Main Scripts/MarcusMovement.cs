using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcusMovement : MonoBehaviour {

    [HideInInspector]
    public bool CanMove = true;

    public Vector3 MarcusPosition = new Vector3(0, 0, 0);
    public float MarcusSpeed = 40;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = MarcusPosition;

        float HorizontalInput = Input.GetAxis("Horizontal");

        if (CanMove)
        {
            MarcusPosition.x += HorizontalInput * (MarcusSpeed / 100);
        }
	}
}