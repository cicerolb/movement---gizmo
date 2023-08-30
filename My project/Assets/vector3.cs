using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;



public enum Emovement
{
    Forward,
    Backward,
    Left,
    Right
}



public class vector3 : MonoBehaviour
{

    public Emovement movementType;
    public Transform pointA, pointB;
    public float moveSpeed;
    public float rangeValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //switch (movementType)
        //{
        //    case Emovement.Forward:
        //        MoveForward();
        //        break;
        //    case Emovement.Backward:
        //        MoveBack();
        //        break;
        //    case Emovement.Left:
        //        MoveLeft();
        //        break;
        //    case Emovement.Right:
        //        MoveRight();
        //        break;
        //    default:
        //        break;
        //}
        //transform.position = Vector3.Lerp(transform.position, pointB.position, moveSpeed * Time.deltaTime) ;

        float dist = Vector3.Distance(transform.position, pointB.position);


        if (dist <= rangeValue)
        {
            Debug.Log("Point B has been detected");
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangeValue);
    }



    public void MoveForward()
    {
        transform.position = Vector3.up * moveSpeed * Time.time;
    }

    public void MoveRight()
    {
        transform.position = Vector3.right * moveSpeed * Time.time;
    }  

    public void MoveBack()
    {
        transform.position = Vector3.down * moveSpeed * Time.time;
    }
    public void Moveeft()
    {
        transform.position = Vector3.left * moveSpeed * Time.time;
    }
}

