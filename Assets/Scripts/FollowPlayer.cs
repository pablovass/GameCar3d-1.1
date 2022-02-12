using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   //puedo llamar de la clase a followObject y es mas generico
   public GameObject player;// a esta variable le arrastre el player desde unity

   public Vector3 offset= new Vector3(0,5,-5);
   
   private void Update()
   {
       transform.position = player.transform.position + offset;
   }
}
