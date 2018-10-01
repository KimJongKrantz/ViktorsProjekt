using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    public SpriteRenderer Rend;
    public TrailRenderer TrailColour;
    public Color colour;
    

	// Use this for initialization
	void Start ()
    {
        
        Rend.color = colour;
        Rend.color = new Color(0,2, 0.25f, 0.33f);

        transform.position = new Vector3(-5f, transform.position.y);

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -360f * Time.deltaTime);
    
        }
               transform.Translate(-2f * Time.deltaTime, 0, 0, Space.Self);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, 360f * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            transform.Translate(-10f * Time.deltaTime, 0, 0, Space.Self);
            TrailColour.startColor = new Color(1, 0, 1);
            TrailColour.endColor = new Color(1, 1, 1);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(1f *Time.deltaTime, 0, 0, Space.Self);
        }
    }

}
