using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
   
    

        public float rotationSpeed = 30f; // Nesnenin dönme hýzý

        void Update()
        {
            // Nesneyi her frame'de y ekseninde belirtilen hýzda döndür
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    
}
