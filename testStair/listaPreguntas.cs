
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;  
using System.Linq;

public class listaPreguntas{

	//Lista de preguntas creadas
	List<pregunta> trivia = new List<pregunta>();
	List<int> preg = new List<int>();
	//Pantalla en la que se mostraran las preguntas
	//public Rect windowRect;
	//public Rect windowRect = new Rect(20, 20, 120, 50);
	//variable a la cual se le asignara un valor aleatorio para obtener la pregunta de la lista

	//respuesta seleccionada de la pregunta

	//Tamaños de los botones de las opciones de respuesta a la pregunta
	int a=0;
	int b=0;
	int c=0;
	int d=0;
	int e=0;
	int f=0;
	int g=0;
	int h=0;

	int w1=0;
	int w2=0;
	int w3=0;
	int w4=0;

	string questionP="";

	
	void Start () {

	}


	public void casillasPreguntas()
	{
		int aux = 0;
		int trap =0;
		int cont = 0;
		for (int i=0; i<100; i++) {



            aux = 3;
			trap =0;
			cont =0;

			if(i>0 && i<=99)
			{
				while(cont<aux)
				{
                    trap = i;
					preg.Add(trap);
					cont ++;
				}
				i = i+10;
			}
		}
	
		preg.Sort ();

	}




	public List<int> getPreg()
	{
		return preg;
	}

	int saltos(string cad)
	{
		if (cad != null) {
			string[] aux = cad.Split ('\n');
			return aux.Length - 1;
		} else {
			return 0;
		}
	}

	public void formato(string cad, int i)
	{
		if (saltos (cad) == 0) {
			if (saltos (trivia [i].getResp1 ()) == 0 && saltos (trivia [i].getResp2 ()) == 0 && saltos (trivia [i].getResp3 ()) == 0 && saltos (trivia [i].getResp4 ()) == 0 && saltos (trivia [i].getResp5 ()) == 0) {
				//Debug.Log("entra1");
				w1 = 10;
				w2 = 20;
				w3 = 600;
				w4 = 400;

				a = 50;
				b = 50;
				c = 210;
				d = 50;
				e = 330; 
				f = 150;
				g = 50;
				h= 230;
				
			} else {
				
				//Debug.Log("entra2");
					//windowRect = new Rect (10, 20, 850, 400);

					w1 = 10;
					w2 = 20;
					w3 = 850;
					w4 = 450;

					a = 10;
					b = 50;
					c = 390;
					d = 100;
					e = 430;
					f = 170;
					g = 10;
					h= 280;

			}
			
		} 
		else {
			if(saltos(cad)==1)
			{
				if (saltos (trivia [i].getResp1 ()) == 0 && saltos (trivia [i].getResp2 ()) == 0 && saltos (trivia [i].getResp3 ()) == 0 && saltos (trivia [i].getResp4 ()) == 0 && saltos (trivia [i].getResp5 ()) == 0) {
					//Debug.Log("entra3");
					w1 = 10;
					w2 = 20;
					w3 = 500;
					w4 = 450;

					a=10;
					b=50;
					c=170;
					d=80;
					e=250;
					f=170;
					g=10;
					h=280;
				}

				else{
					//Debug.Log("entra4");
					w1 = 10;
					w2 = 20;
					w3 = 950;
					w4 = 400;
					
					a = 10;
					b = 50;
					c = 390;
					d = 100;
					e = 430;
					f =170;
					g = 10;
					h= 280;
				}
			}
			else{

				if (saltos (cad)==2){
					
					if (saltos (trivia [i].getResp1 ()) == 0 && saltos (trivia [i].getResp2 ()) == 0 && saltos (trivia [i].getResp3 ()) == 0 && saltos (trivia [i].getResp4 ()) == 0 && saltos (trivia [i].getResp5 ()) == 0) {
						//windowRect = new Rect(10, 20, 800, 400);
						//Debug.Log("entra5");
						w1 = 10;
						w2 = 20;
						w3 = 800;
						w4 = 450;
						
						a = 50;
						b = 70;
						c = 150;
						d = 50;
						e = 330; 
						f = 170;
						g = 50;
						h= 250;
						
					}
					else{

						if (saltos (trivia [i].getResp1 ()) > 2 || saltos (trivia [i].getResp2 ()) > 2 || saltos (trivia [i].getResp3 ()) > 2 || saltos (trivia [i].getResp4 ()) > 2 || saltos (trivia [i].getResp5 ()) > 2) {
							//windowRect = new Rect(10, 20, 850, 400);
							//Debug.Log("entra6");
							w1 = 10;
							w2 = 20;
							w3 = 850;
							w4 = 400;
							
							a = 10;
							b = 50;
							c = 390;
							d = 100;
							e = 430;
							f =170;
							g = 10;
							h = 250;
						}
					}

				}
				else
				{
					if (saltos (cad)>=3){
						//Debug.Log("entra7");	
						w1 = 10;
						w2 = 20;
						w3 = 650;
						w4 = 400;
							
						a = 10;
						b = 120;
						c = 250;
						d = 60;
						e = 310;
						f =200;
						g = 10;
						h = 280;
					}
				}
			}
		}
	}


	public int getA()
	{
		return a;
	}

	public int getB()
	{
		return b;
	}
	public int getC()
	{
		return c;
	}
	public int getD()
	{
		return d;
	}
	public int getE()
	{
		return e;
	}
	public int getF()
	{
		return f;
	}
	public int getG()
	{
		return g;
	}

	public int getW1()
	{
		return w1;
	}

	public int getW2()
	{
		return w2;
	}
	public int getW3()
	{
		return w3;
	}
	public int getW4()
	{
		return w4;
	}
	public int getH()
	{
		return h;
	}

	public List<pregunta> getTrivia()
	{
		return trivia;
	}

	public void addPregunta(pregunta np)
	{	
		trivia.Add (np);
	}

		public void questions ()
		{	
			
			string preg = "";
			string resp1 = "";
			string resp2 = "";
			string resp3 = "";
			string resp4 = "";
			string resp5 = "";
			
			
			//Pregunta 1
			preg = "La inmunidad innata se caracteriza por ser inespecifica y actuar inmediatamente," +"\n" + "señale los elementos Humorales y Celulares propios de esta:";
			resp1 = "Linfocitos T - Anticuerpos";
			resp2 = "Macrofagos - Lisozima";
			resp3 = "Complemento";
			
			
			int respv = 1;
			int id = 1;
			
			pregunta p1 = new pregunta(preg, resp1, resp2, resp3, null, null, respv,id);
			trivia.Add (p1);
			//opt.Clear ();
			
			//Pregunta 2
			preg = "De las siguientes opciones,"+"\n"+ "señale la definicion que corresponda al termino Hapteno.";
			resp1 = "Molécula glicoproteína que tiene la capacidad"+"\n"+ "de reconocer un antígeno especifico.";
			resp2 = "Molécula de la superficie celular de los LT"+"\n"+ "que facilita el proceso de activación"+"\n"+ "de los linfocitos B.";
			resp3 = "Antígeno incompleto, que para ser reconocido"+"\n"+ "por el sistema inmune requiere de la"+"\n"+ "colaboración de un adyuvante.";
			resp4 = "Molécula presente en algunos virus( VIH),"+"\n"+ "Bacterias(Streptococos, Stafilococos) y "+"\n"+ "Parasitos(Plasmodium) que producen una activación"+"\n"+ " policlonal masiva equivalente al 20% "+"\n"+ "de las células del sistema inmune";
			
			respv = 3;
			id = 2;
			
			pregunta p2 = new pregunta(preg, resp1, resp2, resp3, resp4, null, respv,id);
			trivia.Add (p2);
			//opt2.Clear ();
			
			//Pregunta 3
			preg = "Señale en cual de los siguientes organos linfoides "+"\n"+ "ocurre la seleccion positiva y negativa de los LT (Linfositos T).";
			resp1 = "Medula osea fetal.";
			resp2 = "Bazo.";
			resp3 = "Higado Fetal.";
			resp4 = "Timo";
			resp5 = "Placas de Peyer";
			
			respv = 4;
			id = 3;
			
			pregunta p3 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv,id);
			trivia.Add (p3);
			//opt.Clear ();
			
			//Pregunta 4
			preg = "El Complejo de ataque a membrana (mac)"+"\n"+ "es el mecansismo final efector del complemento mediante el cual"+"\n"+ "se generan poros en la membrana de la celula blanco y "+"\n"+ "posteriormente se da la lisis osmotica, "+"\n"+ "señale las moleculas del complemento "+"\n"+ "que constituyen este complejo.";
			resp1 = "C5bC6C7C8C9n.";
			resp2 = "C3b-Fb.";
			resp3 = "Properdin C3b-Fb";
			resp4 = "ProperdinBbC3bC5C6";
			resp5 = "C5bC6C7C8";
			
			respv = 1;
			id = 4;
			
			pregunta p4 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv,id);
			trivia.Add (p4);
			//opt.Clear ();
			
			//Pregunta 5
			preg = "Seleccione de las siguientes proteinas del "+"\n"+ "complemento cuales hacen parte  de las anafilotoxinas:";
			resp1 = "C9.";
			resp2 = "C1q.";
			resp3 = "C3a";
			resp4 = "C8";
			resp5 = "C5a";
			
			respv = 1;
			id = 5;
			
			pregunta p5 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv,id);
			trivia.Add (p5);
			//opt.Clear ();
			
			//Pregunta 6
			preg = "Los anticuerpos son glicoproteínas de gran peso molecular "+"\n"+ "secretadas por los linfocitos b activados(células plasmáticas) "+"\n"+ "por los lt helper como resultado de la respuesta inmune especifica,"+"\n"+ "señale cual es el anticuerpo predominante"+"\n"+ " en la respuesta inmune secundaria:";
			resp1 = "IgD.";
			resp2 = "IgG.";
			resp3 = "IgA";
			resp4 = "IgM.";
			resp5 = "IgE";
			
			respv = 1;
			id = 6;
			
			pregunta p6 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv,id);
			trivia.Add (p6);
			//opt.Clear ();
			
			//Pregunta 7
			preg = "Las inmunoglobulinas  de acuerdo a  su estructura y peso molecular "+"\n"+ "pueden o no atravesar la barrera placentaria, señale cual de las siguientes "+"\n"+ "inmunoglobulinas no atraviesa la barrera placentaria:";
			resp1 = "IgD.";
			resp2 = "IgG.";
			resp3 = "IgM";
			resp4 = "IgA.";
			resp5 = "IgE";
			
			respv = 3;
			id = 7;
			
			pregunta p7 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv,id);
			trivia.Add (p7);
			//opt.Clear ();
			
			//Pregunta 8
			preg = "Cuales de las siguientes inmunoglobulinas activan el complemento  por la via clasica:";
			resp1 = "IgD.";
			resp2 = "IgG.";
			resp3 = "IgA";
			resp4 = "IgM.";
			resp5 = "IgE";
			
			pregunta p8 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv,id);
			trivia.Add (p8);
			//opt.Clear ();
			
			//Pregunta 9
			preg = "Señale las características de la respuesta inmune inespecífica:";
			resp1 = "Depende principalmente de los Linfocitos B y T.";
			resp2 = "Es específica y de memoria.";
			resp3 = "Facilita los mecanismos efectores al  "+"\n"+ "integrarse con la inmunidad específica";
			resp4 = "Es rápida y no se intensifica con los contactos ulteriores.";
			resp5 = "En ella prima la IgM ";
			
			pregunta p9 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv,id);
			trivia.Add (p9);
			//opt.Clear ();
			
			//Pregunta 10
			preg = "Señale cual de los elementos  NO es un componente de la inmunidad innata:";
			resp1 = "Flora bacteriana.";
			resp2 = "Factores constitutivos "+"\n"+ "(Genéticos-Hormonales-Metabólicos).";
			resp3 = "Proteína C reactiva";
			resp4 = "Células plasmáticas.";
			resp5 = "Fagocitosis.";
			
			respv = 4;
			id = 10;
			
			pregunta p10 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv,id);
			trivia.Add (p10);
			//opt.Clear ();
			
			//Pregunta 11
			preg = "Señale cuales de las siguientes células  NO  participan en el proceso de inflamación:";
			resp1 = "Macrófagos.";
			resp2 = "Eosinofilos.";
			resp3 = "Plaquetas";
			resp4 = "Fibroblastos.";
			resp5 = "Linfocito T.";
			
			respv = 5;
			id = 11;
			
			pregunta p11 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv,id);
			trivia.Add (p11);
			//opt.Clear ();
			
			//Pregunta 12
			preg = "Durante el desarrollo embrionario los linfocitos T "+"\n"+ "deben recibir una serie de receptores de membrana que "+"\n"+ "permiten su selección clonal y ulterior  desarrollo Y,"+"\n"+ "señale en el órgano que ocurre este proceso:";
			resp1 = "Bazo.";
			resp2 = "Páncreas.";
			resp3 = "Hígado";
			resp4 = "Timo.";
			resp5 = "Médula osea.";
			
			respv = 4;
			id = 12;
			
			
			pregunta p12 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv,id);
			trivia.Add (p12);
			//opt.Clear ();
			
			//Pregunta 13
			preg = "En la siguiente lista señale los órganos linfoides primarios:";
			resp1 = "Médula Osea - Timo.";
			resp2 = "Bazo - Sistema inmune de la piel.";
			resp3 = "Ganglios Linfáticos - GALT.";
			resp4 = "Timo - Bazo.";
			resp5 = "Médula osea - Ganglios Linfáticos.";
			
			respv = 1;
			id = 13;
			
			pregunta p13 = new pregunta(preg, resp1, resp2, resp3, resp4, resp5, respv,id);
			trivia.Add (p13);
			//opt.Clear ();
			
			//Pregunta 14
			preg = "Son funciones del complemento excepto:";
			resp1 = "Activación de PMN - Activación de Linfocitos T.";
			resp2 = "Lisis bacteriana mediante CAM"+"\n"+ "Potencializa la producción de anticuerpos"+"\n"+ "Opzonización.";
			
			respv = 2;
			id = 14;
			
			pregunta p14 = new pregunta(preg, resp1, resp2, null, null,null, respv,id);
			trivia.Add (p14);
			
			//Pregunta 15
			preg = "Cuales son los componentes del complejo de ataque a la membrana";
			resp1 = "C1qIgM.";
			resp2 = "C4b,2al.";
			resp3 = "C5b,6,7,8(C9)n.";
			resp4 = "C4b,2b,3b.";
			resp5 = "C1qC5,7,9.";
			
			respv = 3;
			id = 15;
			
			pregunta p15 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p15);
			//opt.Clear ();
			
			//Pregunta 16
			preg = "Señale las fracciones del complemento con actividad de anafilotoxinas";
			resp1 = "C7.";
			resp2 = "C1q.";
			resp3 = "C3a.";
			resp4 = "C4b2a.";
			resp5 = "C5a.";
			
			respv = 5;
			id = 16;
			
			pregunta p16 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p16);
			//opt.Clear ();
			
			//Pregunta 17
			preg = "Señale cuales de las siguientes proteínas son reguladoras de la actividad del complemento:";
			resp1 = "Proteína C reactiva - Factor X.";
			resp2 = "Proteína S - Factor H - "+"\n"+"Receptor del complemento  tipo 1(CR1).";
			
			respv = 2;
			id = 17;
			
			pregunta p17 = new pregunta(preg, resp1, resp2, null, null,null, respv,id);
			trivia.Add (p17);
			//opt.Clear ();
			
			//Pregunta 18
			preg = "Señale la fracción de los anticuerpos en la que reside las "+"\n"+ "funciones efectoras de los anticuerpos tales como fijación de complemento:";
			resp1 = "FAB.";
			resp2 = "Paratope.";
			resp3 = "Puentes disulfuro.";
			resp4 = "Región hipervariable.";
			resp5 = "FC.";

			
			respv = 5;
			id = 18;
			
			pregunta p18 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p18);
			//opt.Clear ();
			
			//Pregunta 19
			preg = "Señale la célula responsable de la producción de los anticuerpos:";
			resp1 = "Células dendríticas.";
			resp2 = "Macrófagos.";
			resp3 = "LT h1.";
			resp4 = "LB.";
			resp5 = "LT h2.";
			
			respv = 4;
			id = 19;
			
			pregunta p19 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p19);
			//opt.Clear ();
			
			//Pregunta 20
			preg = "Señale cual es la inmunoglobulina más abundante en el plasma:";
			resp1 = "HLAII.";
			resp2 = "HLAI.";
			resp3 = "CD45.";
			resp4 = "CD1.";
			
			respv = 1;
			id = 20;
			
			pregunta p20 = new pregunta(preg, resp1, resp2, resp3, resp4,null, respv,id);
			trivia.Add (p20);
			//opt.Clear ();
			
			//Pregunta 21
			preg = "Señale cuales de las siguientes son células"+"\n"+ "presentadoras profesionales de antígenos:";
			resp1 = "Linfocitos T citotoxicos "+"\n"+ "Mastocitos.";
			resp2 = "Macrófagos"+"\n"+ "Células dendrítica.";
			resp3 = "Mastocitos"+"\n"+ "Macrófagos.";
			resp4 = "Células dendríticas"+"\n"+ "Linfocitos B.";
			resp5 = "Linfocitos B"+"\n"+ "Linfocitos T citotoxicos.";
			
			respv = 4;
			id = 21;
			
			pregunta p21 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p21);
			//opt.Clear ();
			
			
			//Pregunta 22
			preg = "Señales cuales de las siguientes moléculas están involucradas"+"\n"+ " en la actividad efectora citotoxica de los LT:";
			resp1 = "Granzima"+"\n"+ "Perforina.";
			resp2 = "Complemento"+"\n"+ "IgM.";
			resp3 = "Lisozima"+"\n"+ "Granzima.";
			resp4 = "Complemento"+"\n"+ "IgM.";
			resp5 = "IgM"+"\n"+ "Perforina.";
			
			respv = 1;
			id = 22;
			
			pregunta p22 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p22);
			//opt.Clear ();
			
			//Pregunta 23
			preg = "Señale cual de las siguientes  moleculas es indispensables"+"\n"+"para que una proteína sea procesada vía proteosoma:";
			resp1 = "Proteinasa K.";
			resp2 = "Ubiquitina.";
			resp3 = "Citocromo C450.";
			resp4 = "Proteina P50.";
			resp5 = "Hemoglobina.";
			
			respv = 2;
			id = 23;
			
			pregunta p23 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p23);
			//opt.Clear ();
			
			//Pregunta 24
			preg = "Los linfocitos T citotoxicos ejercen su acción mediante los siguiente mecanismos efectores,"+"\n"+ "señales las opciones  correctas:";
			resp1 = "Activación de complemento por la vida clásica.";
			resp2 = "Secreción de gránulos citotoxicos que contienen perforinas"+"\n"+ "Activación de la citocromo c "+"\n"+ "caspasas por las  granzimas.";
			resp3 = "Inhibición de la actividad de las proteínas "+"\n"+ "transportadoras de antígeno(TAP1,TAP2).";
			resp4 = "Proteina P50.";
			resp5 = "Hemoglobina.";
			
			respv = 2;
			id = 24;
			
			pregunta p24 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p24);
			//opt.Clear ();
			
			//Pregunta 25
			preg = "Cual de las siguientes citoquinas es sintetizada por los linfocitos th1:";
			resp1 = "IL2 - INF γ.";
			resp2 = "TNF - INF γ.";
			resp3 = "IL5 - TNF.";
			
			respv = 2;
			id = 25;
			
			pregunta p25 = new pregunta(preg, resp1, resp2, resp3, null, null, respv,id);;
			trivia.Add (p25);
			//opt.Clear ();
			
			//Pregunta 26
			preg = "Cual citoquina recibe la denominación de pirogeno endogeno:";
			resp1 = "IL14.";
			resp2 = "IL17.";
			resp3 = "ERITROPOYETINA.";
			resp4 = "IL1.";
			resp5 = "IL 8.";
			
			respv = 4;
			id = 26;
			
			pregunta p26 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p26);
			//opt.Clear ();
			
			//Pregunta 27
			preg = "Señale cual de las siguientes citoquinas tiene actividad antiviral directa:";
			resp1 = "IL12.";
			resp2 = "INF-γ.";
			resp3 = "TNF- α.";
			resp4 = "IL1ra.";
			
			respv = 2;
			id = 27;
			
			pregunta p27 = new pregunta(preg, resp1, resp2, resp3, resp4,null, respv,id);
			trivia.Add (p27);
			//opt.Clear ();
			
			//Pregunta 28
			preg = "Señale cual es el papel de la inmunidad humoral contra los virus:";
			resp1 = "Tienen actividad antiviral directa.";
			resp2 = "Bloquea la unión del virus a la célula hospedera, "+"\n"+ "con lo cual se  previene la infección o la reinfección (IgAs)."+"\n"+ "Mejora la fagocitosis de las partículas virales(Opsonización)."+"\n"+ "Aglutinación de las partículas virales IgG, IgM e IgA."+"\n"+ "Media la opzonización por C3b."+"\n"+ "Lisa las partículas virales envueltas por el CAM";
			resp3 = "Media la opzonización por C3b."+"\n"+ "Lisa las partículas virales envueltas por el CAM."+"\n"+ "Tienen actividad antiviral directa";
			
			respv = 2;
			id = 28;
			
			pregunta p28 = new pregunta(preg, resp1, resp2, resp3, null,null, respv,id);
			trivia.Add (p28);
			//opt.Clear ();
			
			//Pregunta 29
			preg = "Señale cual de los siguientes mecanismos corresponde a una "+"\n"+ "estrategia de evasión de la respuesta inmune por parte de los protozoos:";
			resp1 = "Síntesis de moléculas inmunopotenciadoras."+"\n"+ "Mutación de los genes del complemento.";
			resp2 = "Mutación de los genes del complemento."+"\n"+ "Síntesis de proteínas inmunosupresoras.";
			resp3 = "Síntesis de moléculas inmunopotenciadoras."+"\n"+ "Expresión de superantigenos.";
			resp4 = "Expresión de superantigenos."+"\n"+ "Mimetismo molecular."+"\n"+ "Síntesis de proteínas inmunosupresoras";
			
			respv = 4;
			id = 29;
			
			pregunta p29 = new pregunta(preg, resp1, resp2, resp3, resp4,null, respv,id);
			trivia.Add (p29);
			//opt.Clear ();
			
			//Pregunta 30
			preg = "Cual de las siguientes inmunoglobulinas permiten la opsoniza de los parásitos"+"\n"+ " y la unión  de los  eosinófilos a través de sus receptores para fc épsilon:";
			resp1 = "IgA secretoria.";
			resp2 = "IgE.";
			resp3 = "IgM.";
			resp4 = "IgD.";
			resp5 = "IgG.";
			
			respv = 2;
			id = 30;
			
			pregunta p30 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p30);
			//opt.Clear ();
			
			//Pregunta 31
			preg = "Señale cual es el tipo de respuesta inmune mas efectiva contra los virus:";
			resp1 = "LT-CD4+.";
			resp2 = "IgM.";
			resp3 = "IgA.";
			resp4 = "Complemento.";
			resp5 = "LT-CD8+.";
			
			respv = 5;
			id = 31;
			
			pregunta p31 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p31);
			//opt.Clear ();
			
			//Pregunta 32
			preg = "Seleccione de las siguientes bacterias aquellas que utilizan"+"\n"+ " como estrategia de evasión del sistema inmune la variación antigenica:";
			resp1 = "Treponema Palidum.";
			resp2 = "E. coli.";
			resp3 = "Staphilococus aureus.";
			resp4 = "Neiseira gonorrhoea.";
			resp5 = "Listeria monocitogenes.";
			
			respv = 4;
			id = 32;
			
			pregunta p32 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p32);
			//opt.Clear ();
			
			//Pregunta 33
			preg = "Señale cual de los siguientes virus utiliza como estrategia de evasión"+"\n"+ "la inhibición del procesamiento antigénico al bloquear"+"\n"+ "el transporte de antígenos por parte del tap:";
			resp1 = "Rinovirus.";
			resp2 = "Enterovirus.";
			resp3 = "VIH.";
			resp4 = "Herpes virus(HSV,CMV).";
			resp5 = "Poxvirus.";
			
			respv = 4;
			id = 33;
			
			pregunta p33 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p33);
			//opt.Clear ();
			
			//Pregunta 34
			preg = "Señale que tipo de respuesta inmune permite el control de la infección por plasmodium:";
			resp1 = "Complemento.";
			resp2 = "IgA secretoria.";
			resp3 = "PH gástrico.";
			resp4 = "Anticuerpos y LT CD8+.";
			resp5 = "IL 18.";
			
			respv = 4;
			id = 34;
			
			pregunta p34 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p34);
			//opt.Clear ();
			
			//Pregunta 35
			preg = "Señale una caracteristica del grupo de linfositos Th2:";
			resp1 = "Defensa contra"+"\n"+ "patógenos extracelulares.";
			resp2 = "Defensa contra "+"\n"+ "patógenos intracelulares.";
			resp3 = "Estimula Citotoxicidado.";
			resp4 = "Produce INFγ.";
			
			respv = 1;
			id = 35;
			
			pregunta p35 = new pregunta(preg, resp1, resp2, resp3, resp4,null, respv,id);
			trivia.Add (p35);
			//opt.Clear ();
			
			//Pregunta 36
			preg = "La respuesta inmune se divide en innata y adquirida"+"\n"+ "seleccione el tipo de mecanismo químico o celular"+"\n"+ " que corresponda a la respuesta adquirida:";
			resp1 = "Lisozimas.";
			resp2 = "Complemento.";
			resp3 = "Células dendríticas.";
			resp4 = "Células NK.";
			resp5 = "Anticuerpos";
			
			respv = 5;
			id = 36;
			
			pregunta p36 = new pregunta(preg, resp1, resp2, resp3, resp4,resp5, respv,id);
			trivia.Add (p36);
			
			//Random.Range (0, (trivia.Count));
			
			//string p = trivia [i].getQuestion();
			//formato (p);
		}


}
