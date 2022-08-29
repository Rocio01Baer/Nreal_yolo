/****************************************************************************
* Copyright 2019 Nreal Techonology Limited. All rights reserved.
*                                                                                                                                                          
* This file is part of NRSDK.                                                                                                          
*                                                                                                                                                           
* https://www.nreal.ai/        
* 
*****************************************************************************/

using NRKernal.Record;
using System.IO;
using System.Linq;
using UnityEngine;

namespace NRKernal.NRExamples
{
    /// <summary> A video capture 2 local example. </summary>
    [HelpURL("https://developer.nreal.ai/develop/unity/video-capture")]
    public class Habilitar_Pruebaa : MonoBehaviour
    {
        public GameObject n1, n2, n3/*, n4, n5*/;
        // public Canvas menuCanvas;


        void Start()
        {
            Invoke("RestartPosition", 5f);
        }

        void RestartPosition()
        {
            // menuCanvas.enabled = true;

            n1.SetActive(true);
            n2.SetActive(true);
            n3.SetActive(true);
            //n4.SetActive(true);
            //n5.SetActive(true);
        }
    }
}