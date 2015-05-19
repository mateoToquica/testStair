using System.Collections;
using System.Collections.Generic;

public class pregunta {
	
	string question;
	string respuesta1;
	string respuesta2;
	string respuesta3;
	string respuesta4;
	string respuesta5;
	int correcta; // el índice de la pregunta correcta
	int id; /// id de la pregunta

	public pregunta(string pregunta, string respuesta1, string respuesta2, string respuesta3, string respuesta4, string respuesta5, int correcta, int id){
		this.question = pregunta;
		this.respuesta1 = respuesta1;
		this.respuesta2 = respuesta2;
		this.respuesta3 = respuesta3;
		this.respuesta4 = respuesta4;
		this.respuesta5 = respuesta5;
		this.id = id;
		this.correcta = correcta;
	}

	public string getQuestion()
	{
		return question;
	}
	

	public string getResp1()
	{
		return respuesta1;
	}

	public string getResp2()
	{
		return respuesta2;
	}

	public string getResp3()
	{
		return respuesta3;
	}

	public string getResp4()
	{
		return respuesta4;
	}

	public string getResp5()
	{
		return respuesta5;
	}

	public int getResp(){
		return correcta;
	}

	public int getId()
	{
		return id;
	}

}