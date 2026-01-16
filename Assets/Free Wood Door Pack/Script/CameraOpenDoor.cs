using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraDoorScript
{
    public class CameraOpenDoor : MonoBehaviour
    {
        public float DistanceOpen = 3;

        public GameObject text;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, DistanceOpen))
            {
                var door = hit.transform.GetComponent<DoorScript.Door>();
                if (door != null)
                {
                    text.SetActive(true);


                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (door.open) door.CloseDoor();
                        else door.OpenDoor();
                    }
                }
                else

                {
                    text.SetActive(false);
                }
            }
            else
            {
                text.SetActive(false);
            }
        }
    }
}