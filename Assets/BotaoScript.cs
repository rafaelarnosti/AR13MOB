using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BotaoScript : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject botaoVirtual;
	public GameObject objeto;   

	void Start()
	{
		// Busca na cena o objeto e associa ao atributo
		botaoVirtual = GameObject.Find("VirtualButton");
		objeto = GameObject.Find("Link");
		// Obtem do componente o metodo - (Script->VirtualButtonBehaviour/Metodo->RegisterEventHandler)
		botaoVirtual.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		objeto.transform.Rotate(Vector3.up * 10.0f);
		throw new System.NotImplementedException();       
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{        
		throw new System.NotImplementedException();
	}


}