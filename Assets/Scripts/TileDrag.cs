using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDrag : MonoBehaviour {

    bool grabbed;
    private Vector3 screenPoint;
    private Vector3 scanPos;
    private Vector3 offset;
   

    // Use this for initialization
    void Start () {
        //ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //obj = this.GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {

        
    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(scanPos);

        //change object's position on click

        

        

        offset = scanPos - Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
            //new Vector3(this.transform.position.x, this.transform.position.y, obj.transform.position.x));

    }


    void OnMouseDrag()
    {
        
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 2, screenPoint.z);
        //Vector3 curScreenPoint = new Vector3(this.transform.position.x, this.transform.position.y + 2, this.transform.position.x);


        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
        

    }
}
