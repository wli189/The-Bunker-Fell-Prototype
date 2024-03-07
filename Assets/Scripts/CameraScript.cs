using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;

    public int currentCamera = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentCamera++;

            if (currentCamera > 4)
            {
                currentCamera = 1;
            }

            switch (currentCamera)
            {
                case 1:
                    CameraOne();
                    break;
                case 2:
                    CameraTwo();
                    break;
                case 3:
                    CameraThree();
                    break;
                case 4:
                    CameraFour();
                    break;
            }

        }
    }

    void CameraOne()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
    }

    void CameraTwo()
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
        camera3.SetActive(false);
        camera4.SetActive(false);
    }

    void CameraThree()
    {
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(true);
        camera4.SetActive(false);
    }

    void CameraFour()
    {
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(true);
    }
}
