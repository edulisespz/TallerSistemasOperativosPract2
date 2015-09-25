using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2SisOpe
{
    class Hilo1 : Form1
    {
        bool a = true;

        

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


        public void PrincipalInit()//Core important
        {
            while(true)
            {




            int i = 0, j, x, z;
            int bloqueados = 0;

            int Fnuevos = 0, Flistos = 0, Fejec = 0;

            int temp = 0;

            string Aux1Textbox = "";


            llenarLista();

            List<Proceso> List_Listos = new List<Proceso>();
            List<Proceso> List_Nuevos = new List<Proceso>();
            List<Proceso> List_Bloqueados = new List<Proceso>();
            List<Proceso> List_Ejecucion = new List<Proceso>();
            List<Proceso> List_Terminados = new List<Proceso>();

            Proceso Ejecutado;

            //inicio while tentativo





            for (j = 0; j < 5 - Flistos; j++)//listos
            {
                temp++;
                List_Listos.Add(Lis_Monedas.ElementAt(0));
                Lis_Monedas.RemoveAt(0);
            }

            Flistos = temp;
            temp = 0;

            List_Listos.OrderBy(o => o.Tiempo_servicio).ToList();

            for (j = 0; j < List_Listos.Count; j++)//listos
            {
                //List_Listos.Add(Lis_Monedas.ElementAt(0));
                //Lis_Monedas.RemoveAt(0);

                Aux1Textbox = Aux1Textbox + "- " + (j + 1) + " " + List_Listos.ElementAt(j).TipoMoneda + "Tiempo: " + List_Listos.ElementAt(j).Tiempo_servicio + Environment.NewLine;
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

            if (ActionBlock)
            {

                ActionBlock = false;
            }
            if (ActionEnd)
            {
                ActionEnd = false;
            }

        }//end While true


        }

        
    }

}




