using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Text scoreText;
    public Text coinText;
    public Text coinTotal;
    public Text scoremision;
    public Text scoremisionTotal;
    

    private void Start()
	{
		scoreText.text = PlayerPrefs.GetInt ("score").ToString();
        coinText.text = PlayerPrefs.GetInt("coin").ToString();
        coinTotal.text = PlayerPrefs.GetInt("coinTotal").ToString();
        scoremision.text = PlayerPrefs.GetInt("misionscore").ToString();
        scoremisionTotal.text = PlayerPrefs.GetInt("scoremisionTotal").ToString();

    }

    

    public void ToGame()
	{
		SceneManager.LoadScene ("Game");
	}

    public void ToFloor()
    {
        SceneManager.LoadScene("Floor");
    }

    public void ToBrick()
    {
        SceneManager.LoadScene("Brick");
    }

    public void ToThung()
    {
        SceneManager.LoadScene("Thung");
    }

    public void ToRibbon()
    {
        SceneManager.LoadScene("Ribbon");
    }

    public void ToCute()
    {
        SceneManager.LoadScene("Cute");
    }

    public void ToPalette()
    {
        SceneManager.LoadScene("Palette");
    }

    public void ToBlues()
    {
        SceneManager.LoadScene("Blues");
    }

    public void ToGlass()
    {
        SceneManager.LoadScene("Glass");
    }

    public void ToTivi()
    {
        SceneManager.LoadScene("Tivi");
    }

    public void ToMinecraft()
    {
        SceneManager.LoadScene("Minecraft");
    }

    public void ToByzantine1()
    {
        SceneManager.LoadScene("Byzantine1");
    }

    public void ToByzantine2()
    {
        SceneManager.LoadScene("Byzantine2");
    }

    public void ToByzantine3()
    {
        SceneManager.LoadScene("Byzantine3");
    }

    public void ToSakura()
    {
        SceneManager.LoadScene("Sakura");
    }

    public void ToFlower()
    {
        SceneManager.LoadScene("Flower");
    }

    public void ToTim()
    {
        SceneManager.LoadScene("Tim");
    }


}
