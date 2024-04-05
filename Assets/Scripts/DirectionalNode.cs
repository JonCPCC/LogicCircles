using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNode : MonoBehaviour
{
     public Sprite none;
     public Sprite left;
     public Sprite right;
     public string current;
     SpriteRenderer sr;

     // Start is called before the first frame update
     void Start()
     {
          sr = GetComponent<SpriteRenderer>();
          sr.sprite = left;
          SwitchSprite();
     }

     // Update is called once per frame
     void Update()
     {
        
     }
     
     void SwitchSprite()
     {
          //Debug.Log("Switch Sprite Ran");
          if (current == "left")
          {
               sr.sprite = left;
               //Debug.Log("Choose Left");

          }
          else if (current == "right")
          {
               sr.sprite = right;
               //Debug.Log("Choose Right");
          }
          else
          {
               sr.sprite = none;
               //Debug.Log("Choose None");
          }
     }
}