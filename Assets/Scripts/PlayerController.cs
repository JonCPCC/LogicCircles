using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public float speed;
     public bool right;

     // Start is called before the first frame update
     void Start()
     {
          if (!right)
          {
               transform.Rotate(Vector3.back * 180);
          }
     }

     // Update is called once per frame
     void Update()
     {
          transform.Translate(Vector3.right * speed);
          //forward = Left, back = Right
     }

     private void OnTriggerEnter2D(Collider2D other)
     {
          DirectionalNode dn = other.GetComponent<DirectionalNode>();

          //Fix Offset
          Transform position = other.GetComponent<Transform>();
          transform.position = position.transform.position;
          
          Debug.Log(other.gameObject.name + ", " + dn.current); //Log the node's name and direction in the console
          float rotation = 0;
          Vector3 dir = Vector3.zero;
          if (dn.current == "right")
          {
               dir = Vector3.back;
               rotation = 90;
          }
          else if (dn.current == "left")
          {
               dir = Vector3.forward;
               rotation = 90;
          }

          transform.Rotate(dir * rotation); 
     }

}
