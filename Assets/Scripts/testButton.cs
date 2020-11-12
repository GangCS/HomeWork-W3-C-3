using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testButton : MonoBehaviour
{
	
	public GameObject yourButton;

	void Start()
	{
		GameObject.Find("Button25").GetComponentInChildren<Text>().text = "Play again";
		//yourButton.transform.Rotate(new Vector3(0, 0, 90));
		//t.text = "hello";
		Button btn = yourButton.GetComponent<Button>();
		//btn.gameObject.GetComponentInChildren<Text>().text = "hello";
		btn.onClick.AddListener(TaskOnClick);
	}
	public void setText(string text)
    {

        //Text txt = transform.Find("Button25").GetComponent<Text>();
        //txt.text = text;
        //SceneManager.

    }
	void TaskOnClick()
	{
		//Debug.Log("You have clicked the button!");
		SceneManager.LoadScene("SampleScene");
		//HitFire.p1 = 3;
		//HitFire.p2 = 3;
	}
}