using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PS4Control : MonoBehaviour
{
   

   void Start()
   {

   for (int i =0; i< Gamepad.all.Count; i++)
{
     
     Debug.Log(Gamepad.all[i].name);
}

   }

   void Update()
   {

       
   }



}


