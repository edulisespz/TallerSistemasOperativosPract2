using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract2SisOpe
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int milsecs;

        int NumMonedas = 100;
        

        List<Proceso> Lis_Monedas = new List<Proceso>();

        private void Form1_Shown(object sender, EventArgs e)
        {
            PrincipalInit();
            
        }


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
            System.Threading.Thread.Sleep(5000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void PrincipalInit()
        {
            bool a = true;
            int i = 0, j;

            string AuxTextbox = "";


            llenarLista();

            List<Proceso> List_Listos = new List<Proceso>();
            List<Proceso> List_Nuevos = new List<Proceso>();
            List<Proceso> List_Bloqueados = new List<Proceso>();
            List<Proceso> List_Ejecucucion = new List<Proceso>();
            List<Proceso> List_Terminados = new List<Proceso>();



            for (j = 0; j < 5; j++)
            {
                AuxTextbox = AuxTextbox + Lis_Monedas.ElementAt(j).TipoMoneda + Environment.NewLine;
                textBoxNuevos.Text = AuxTextbox;
                

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonError_Click(object sender, EventArgs e)
        {
            

        }

        
    }
}
