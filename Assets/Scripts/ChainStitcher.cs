using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainStitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {

            Vector3 mousePosition = Input.mousePosition;
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 9));


            if(Vector3.Distance(newPosition, this.transform.position) > .01f)
            {
                Vector3 heading = newPosition - this.transform.position;
                this.transform.right = new Vector3(heading.x, heading.y, 0);
            }
        

            this.transform.position = newPosition;

            //Debug.Log(mousePosition);
        }
    }
}
