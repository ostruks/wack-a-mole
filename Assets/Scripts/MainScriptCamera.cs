using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScriptCamera : MonoBehaviour {

    public int xs, ys; //отступы от экрана
    public int w = 100; //ширина компонента
    public int h = 25; //высота компонента
    public int xm, ym;
    public int timersecond = 0; //время в секундах
    private float tsec;
    public float gamesecond;
    public float gametime;
    public float timespeed;
    public int molekill;

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width - xs, ys, w, h), "секунды: " + timersecond);
        GUI.Label(new Rect(Screen.width - xs, ys + h, w, h * 3), "игровые секунды: " + gamesecond);
        GUI.Label(new Rect(Screen.width - xs, ys + h * 3, w, h * 3), "убито кротов: " + molekill);
    }

    //обновляется каждый кадр
    void Update()
    {
        //"игровое время" - таймер без привязки ко времени
        gametime += Time.deltaTime; //время между перересовкой кадров
        if (gametime >= timespeed)
        {
            gamesecond += 1;
            gametime = 0;
        }
        //"приблизительный" отсчёт секунд
        tsec += Time.deltaTime;
        if (tsec >= 2.0)
        {
            timersecond++;
            tsec = 0;
        }
        if(gamesecond == 60 || molekill == 20)
        {
            string sceneName = "MainScene";
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
            Mole.killedMole = 0;
        }
        molekill = Mole.killedMole;
    }
}
