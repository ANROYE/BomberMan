using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearExplotion : MonoBehaviour {
    /// <summary>
        ///這個方法會清除爆炸
        ///
        /// <Author> Wumenghua </ Author>
        /// </ summary>
    private float destroyTime = 0.8f;

	
	void Start () {
        Destroy(gameObject, destroyTime);
    }
	
	
	void Update () {
        
    }
}
