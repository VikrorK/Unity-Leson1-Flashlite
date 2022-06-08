using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashligthSimple : MonoBehaviour
{
    public Light light_fonarik; //свет фонарика
    public bool Vkl; //включен или выключен фонарик
    public AudioSource asF; //компонент аудиосорс для звука
    // Start is called before the first frame update
    void Start()
    {
        Proverka();
    }

    // Update is called once per frame
    void Update()
    {
        FlashLightOnOF();
    }
    //Включение и выключение фонарика
    public void FlashLightOnOF(){
        if (Input.GetKeyDown (KeyCode.F) && Vkl == false) // если нажали клавишу F и фонарик выключен
		{
			
			light_fonarik.enabled=true; // включаем свет
            Vkl = true; // указываем, что фонарик включен
            asF.Play();// проигрываем звук
		
           
            
		}
        //выключаем фонарик
		else if (Input.GetKeyDown (KeyCode.F) && Vkl == true) // если нажали клавишу F и фонарик включен
		{
			
			light_fonarik.enabled=false; //выключаем свет
            Vkl = false; // указываем, что фонарик выключен
            asF.Play();// проигрываем звук
          
			
		}
      
    }
    //Проверяем статус фонарика и включаем или выключаем
    public void Proverka() {
       if(Vkl == true) //Если фонарик должен быть включен, то включаем свет
        {
        light_fonarik.enabled=true;
        }
        else if(Vkl == false) //Если фонарик должен быть выключен, то выключаем свет
        {
        light_fonarik.enabled=false;
        }
    }
}
