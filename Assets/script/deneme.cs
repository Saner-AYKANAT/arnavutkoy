using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
   
    

        public float rotationSpeed = 30f; // Nesnenin d�nme h�z�

        void Update()
        {
            // Nesneyi her frame'de y ekseninde belirtilen h�zda d�nd�r
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    
}
