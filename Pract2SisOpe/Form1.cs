using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Pract2SisOpe
{

    public partial class Form1 : Form
    {
        //System.Timers.Timer timer = new System.Timers.Timer ();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            timer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = (1000) * (1);              // Timer will tick evert second
            timer.Enabled = true;                       // Enable the timer
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            PrincipalInit();
        }

        

        protected int NumMonedas = 100;
        protected bool ActionBlock = false, ActionEnd = false;
        bool ciclo_principal = true;

        protected List<Proceso> Lis_Monedas = new List<Proceso>();

        int i = 0, j, x, z;
        int bloqueados = 0;

        int Fnuevos = 0, Flistos = 0, Fejec = 0;

        int temp = 0;

        string Aux1Textbox = "";
        string aux2term_textbox = "";



        List<Proceso> List_Listos = new List<Proceso>();
        List<Proceso> List_Nuevos = new List<Proceso>();
        List<Proceso> List_Bloqueados = new List<Proceso>();
        List<Proceso> List_Ejecucion = new List<Proceso>();
        List<Proceso> List_Terminados = new List<Proceso>();

        Proceso Ejecutado;



        private void Form1_Shown(object sender, EventArgs e)
        {
            

            

            
        }

        // Implement a call with the right signature for events going off
        private void myEvent(object source, EventArgs e) { }


        private void llenarLista()
        {
            int i;
            int Tipo;
            Proceso temp;

            Random rand = new Random();

            for (i = 1; i <= NumMonedas; i++)
            {//aqui relleno monedas



                
                Tipo = rand.Next(1, 10);

                temp = new Proceso();

                temp.Identificador = i;
                temp.Tiempo_servicio = rand.Next(1, 5);


                switch (Tipo)
                {
                    case 1:
                        //cola.push_back("peso");
                        //falta ver lo del objeto
                        temp.TipoMoneda = "peso";
                        break;
                    case 2:
                        //cola.push_back("U.S. Dollar");
                        temp.TipoMoneda = "U.S. Dollar";
                        break;
                    case 3:
                        //cola.push_back("Euro");
                        temp.TipoMoneda = "Euro";
                        break;
                    case 4:
                        //cola.push_back("Yen");
                        temp.TipoMoneda = "Yen";
                        break;
                    case 5:
                        //cola.push_back("British Pound");
                        temp.TipoMoneda = "British Pound";
                        break;
                    case 6:
                        //cola.push_back("Swiss Franc");
                        temp.TipoMoneda = "Swiss Franc";
                        break;
                    case 7:
                        //cola.push_back("Canadian Dollar");
                        temp.TipoMoneda = "Canadian Dollar";
                        break;
                    case 8:
                        //cola.push_back("New Zealand Dollar");
                        temp.TipoMoneda = "New Zealand Dollar";
                        break;
                    case 9:
                        //cola.push_back("African Rand ");
                        temp.TipoMoneda = "African Rand";
                        break;
                    case 10:
                        //cola.push_back("Indian rupee");
                        temp.TipoMoneda = "Indian rupee";
                        break;
                }//end switch
                

                //add to the list
                Lis_Monedas.Add(temp);


            }//end for
        }

        

        



        private void buttonBlock_Click(object sender, EventArgs e)
        {
            ActionBlock = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void PrincipalInit()//Core important
        {

            
            
            
            

            llenarLista();

            //inicio while tentativo
            




                for (j = 0; j < 5 - Flistos&& List_Listos.Count <= 5 ; j++)//listos
                {
                    temp++;
                    List_Listos.Add(Lis_Monedas.ElementAt(0));
                    Lis_Monedas.RemoveAt(0);
                }

                Flistos = temp;
                temp = 0;

                List_Listos.OrderBy(o => o.Tiempo_servicio).ToList();

                for (j = 0; j < List_Listos.Count && j < 5; j++)//listos
                {
                    //List_Listos.Add(Lis_Monedas.ElementAt(0));
                    //Lis_Monedas.RemoveAt(0);

                    Aux1Textbox = Aux1Textbox + "- " + (j + 1) + " " + List_Listos.ElementAt(j).TipoMoneda 
                        + "Tiempo: " + List_Listos.ElementAt(j).Tiempo_servicio + Environment.NewLine;
                    textBoxListos.Text = Aux1Textbox;


                }

                Aux1Textbox = "";
                for (j = 0; j < 5 - bloqueados; j++)//nuevos
                {
                    Aux1Textbox = Aux1Textbox + Lis_Monedas.ElementAt(j).TipoMoneda + Environment.NewLine;
                    textBoxNuevos.Text = Aux1Textbox;


                }


                Aux1Textbox = "";

                //ejecucion
                Ejecutado = new Proceso(List_Listos.ElementAt(0));
                List_Listos.RemoveAt(0);
                Flistos--;

                for (x = 0; (x < Ejecutado.Tiempo_servicio && (ActionBlock == false && ActionEnd == false)); x++) //Core Important
                {
                    System.Threading.Thread.Sleep(1000);
                    textBoxEjecuta.Text = "id: " + Ejecutado.Identificador + Environment.NewLine +
                        " " + Ejecutado.TipoMoneda + "Tiempo: " + Ejecutado.Tiempo_servicio + Environment.NewLine;

                }
                if (x == Ejecutado.Tiempo_servicio)
                {
                    List_Terminados.Add(Ejecutado);
                    ActionEnd = true;
                }

                Aux1Textbox = "";

                if (ActionBlock)
                {
                    List_Bloqueados.Add(Ejecutado);

                    for (j = 0; j < List_Bloqueados.Count; j++)//listos
                    {
                        //List_Listos.Add(Lis_Monedas.ElementAt(0));
                        //Lis_Monedas.RemoveAt(0);

                        Aux1Textbox = Aux1Textbox + "- " + (j + 1) + " " + List_Bloqueados.ElementAt(j).TipoMoneda 
                            + "Tiempo: " + List_Bloqueados.ElementAt(j).Tiempo_servicio + Environment.NewLine;
                        textBoxBloque.Text = Aux1Textbox;


                    }

                    bloqueados++;
                    ActionBlock = false;
                }
                if (ActionEnd)
                {
                    
                    aux2term_textbox = textBoxTerminados.Text;
                    aux2term_textbox = aux2term_textbox + " " + Ejecutado.TipoMoneda + Ejecutado.Tiempo_servicio + Environment.NewLine;
                    textBoxTerminados.Text = aux2term_textbox;
                    ActionEnd = false;
                }

            
                        


            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonError_Click(object sender, EventArgs e)
        {
            ActionEnd = true;

        }

        
    }
}


//for (j = 0; j < 5; j++)
//            {
//                AuxTextbox = AuxTextbox + Lis_Monedas.ElementAt(j).TipoMoneda + Environment.NewLine;
//                textBoxNuevos.Text = AuxTextbox;
                

//            }


//--------------------------------

//for (x = 0; x < 5; x++)//ejecucion
//{
//    List_Ejecucion.Add(Lis_Monedas.ElementAt(0));
//    Lis_Monedas.RemoveAt(0);
//}


//for (x = 0; x < List_Ejecucion.Count; x++)//Ejecuta
//{
//    Aux1Textbox = Aux1Textbox + "- " + (x + 1) + " " + List_Ejecucion.ElementAt(x).TipoMoneda + Environment.NewLine;
//    textBoxEjecuta.Text = Aux1Textbox;
//}

//Aux1Textbox = "";

//espera

//for (z = 0; z < ; z++)
//{
//    for (z = 0; z < ; z++)
//    {

//    }
//}



//System.Threading.Thread.Sleep(5000);