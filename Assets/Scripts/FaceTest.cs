using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleCardDrawAndSpread_FaceTest {
    public class FaceTest : MonoBehaviour
    {
        public Vector3 Origin;
        private GameObject myObject;
        private GameObject myObject2;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void printObject(string name)
        {
            if(name == "BigEar"){
                myObject = GameObject.Find("BigEarLeft");
                myObject2 = GameObject.Find("BigEarRight");
            }
            else if(name == "ElfEar")
            {
                myObject = GameObject.Find("ElfEarLeft");
                myObject2 = GameObject.Find("ElfEarRight");
            }
            else if(name == "SmallEar")
            {
                myObject = GameObject.Find("SmallEarLeft");
                myObject2 = GameObject.Find("SmallEarRight");
            }
            else
            {
                myObject = GameObject.Find(name);
            }

            if(name == "BigEar" || name == "ElfEar" || name == "SmallEar")
            {
                Transform myObjectTransform = myObject.transform;
                Transform myObjectTransform2 = myObject2.transform;

                Vector3 myObjectPosition = myObjectTransform.position;
                Vector3 myObjectPosition2 = myObjectTransform2.position;

                myObjectPosition.x = 0;
                myObjectPosition2.x = 0;

                myObjectTransform.position = myObjectPosition;
                myObjectTransform2.position = myObjectPosition2;
            }
            else
            {
                Transform myObjectTransform = myObject.transform;

                Vector3 myObjectPosition = myObjectTransform.position;

                myObjectPosition.x = 0;

                myObjectTransform.position = myObjectPosition;
            }
        }
    }
}