using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
	public GameObject[] alvo;
	public Vector3 PosCriacao;
	public int ContaAlvos;
	public float EsperaCriacao;
	private int aa = 0;
	//public GameController s;


	void Start()
	{
		//bool s = GetComponent<GameController>();
		
	}

    //if (GameController.inicio)
    //

    private void FixedUpdate()
    {
		if (GameController.inicio && aa==0) 
        {
			StartCoroutine(SpawnTarget());
			aa++;
		}


	}

    public IEnumerator SpawnTarget()
	{
		for (int i = 0; i < ContaAlvos; i++)
		{
			GameObject a = alvo[Random.Range(0, 2)];
			Vector3 spawnPosition = new Vector3(Random.Range(-PosCriacao.x, PosCriacao.x), PosCriacao.y, Random.Range(3, PosCriacao.z));
			Instantiate(a, spawnPosition, Quaternion.Euler(90, 0, 0));
			Destroy(GameObject.Find("Green_target(Clone)"), 1.5f);
			Destroy(GameObject.Find("Red_target(Clone)"), 1.5f);
			yield return new WaitForSeconds(EsperaCriacao);
			
			
		}

	}
}
