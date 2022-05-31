using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    Vector3 firstPos, endPos;
    public float playerSpeed;
    float farkX;
    float xPosition;

    public int horizontalSpeed;
    public int speed;

    // Update is called once per frame
    void Update()
    {
        //float horizontal = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        //transform.Translate(horizontal, 0, speed * Time.deltaTime);
      
        xPosition = Mathf.Clamp(transform.position.x, -11.694f, -7.75f);
        transform.position = new Vector3(xPosition,transform.position.y,transform.position.z);
        //if (Input.GetMouseButtonDown(0))
        //{

        //    firstPos = Input.mousePosition;



        //}
        //else if (Input.GetMouseButton(0))
        //{

        //    endPos = Input.mousePosition;
        //    farkX = endPos.x - firstPos.x;
        //    transform.Translate(farkX * Time.deltaTime * playerSpeed / 100, 0, 0);



        //}
        //if (Input.GetMouseButtonUp(0))
        //{

        //    firstPos = Vector3.zero;
        //    endPos = Vector3.zero;





        //}







    }
}
