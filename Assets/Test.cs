using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {	
		//配列を初期化する
		int[] array = { 41, 47, 49, 54, 94, };

		//配列の要素を順番に表示する
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		//配列の要素を逆順に表示する
		for (int i = array.Length - 1; 0 <= i; --i){
			Debug.Log (array [i]);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
