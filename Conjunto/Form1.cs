using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conjunto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            respuesta.Clear();
            if (union.Checked)
                AccionUnion();
            if (interseccion.Checked)
                AccionInterseccion();
            if (diferencia.Checked)
                AccionDiferencia(Lista1, Lista2, "");
            if (simetrica.Checked)
                AccionDiferenciaSimetrica();
            if (complemento.Checked)
                AccionComplemento();
            if (producto.Checked)
                AccionProducto();
            if (potencia.Checked)
                AccionPotencia();
            if (CerraduraK.Checked)
                CerraduraKleene();
            if (CerraduraP.Checked)
                CerraduraPositiva();
        }

        List<String> Lista1 = new List<String>();
        List<String> Lista2 = new List<String>();
        List<String> ListaAlfa = new List<String>();


        int indicador = 0, indicador2 = 0, indicador3 = 0;

        public void AccionUnion()
        {
            string cadena1, cadena2, respuestaUnion;

            cadena1 = lenguajeA.Text.ToString();
            cadena2 = lenguajeB.Text.ToString();

            respuestaUnion = cadena1 + ", " + cadena2;
            respuesta.Text = respuestaUnion;
        }

        public void AccionInterseccion()
        {
            int indicador = 0;
            String respuestaInterseccion = "";
            foreach (String x in Lista1)
            {
                foreach (String y in Lista2)
                {
                    if (x.Equals(y))
                    {
                        if (indicador == 0)
                        {
                            respuestaInterseccion = x;
                            indicador++;
                        }
                        else
                        {
                            respuestaInterseccion = respuestaInterseccion + ", " + x;
                        }
                    }
                }
            }

            respuesta.Text = respuestaInterseccion;
        }

        public void AccionDiferencia(List<String> Lista1, List<String> Lista2, string anterior)
        {
            string respuestaDiferencia = "";
            int indicador = 0, indicador2 = 0;
            foreach (String x in Lista1)
            {
                foreach (String y in Lista2)
                {
                    if (x.Equals(y))
                    {
                        indicador++;
                    }
                }

                if (indicador == 0)
                {
                    if (indicador2 == 0)
                    {
                        respuestaDiferencia = x;
                        indicador2++;
                    }
                    else
                        respuestaDiferencia = respuestaDiferencia + ", " + x;
                }

                indicador = 0;
            }

            respuesta.Text = anterior + respuestaDiferencia;
        }

        public void AccionDiferenciaSimetrica()
        {
            string anterior;
            AccionDiferencia(Lista1, Lista2, "");
            anterior = respuesta.Text.ToString() + ", ";
            AccionDiferencia(Lista2, Lista1, anterior);
        }

        public void AccionComplemento()
        {
            AccionDiferencia(ListaAlfa, Lista1, "");
        }

        public void AccionProducto()
        {
            string respuestaProducto = "";
            int indicador = 0;
            foreach (String x in Lista1)
            {
                foreach (String y in Lista2)
                {
                    if (indicador == 0)
                    {
                        respuestaProducto = x + y;
                        indicador++;
                    }
                    else
                        respuestaProducto = respuestaProducto + ", " + x + y;
                }
            }
            respuesta.Text = respuesta.Text.ToString() + respuestaProducto;
        }

        List<String> ListaAcumulada = new List<string>();
        List<String> ListaAuxiliar = new List<string>();

        public void AccionPotencia()
        {
            ListaAcumulada.Clear();
            ListaAuxiliar.Clear();
            ListaAcumulada.AddRange(Lista1);
            String respuestaPotencia = "";
            int n = 0, indicador = 0;
            try
            {
                n = Int32.Parse(numeroPotencia.Text.ToString());
                //Console.WriteLine(n);
            }
            catch (Exception e)
            {
                error.SetError(numeroPotencia, "Valor incorrecto");
            }


            if (n > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    foreach (String x in ListaAcumulada)
                    {
                        foreach (String y in Lista1)
                        {
                            ListaAuxiliar.Add(x + y);
                        }
                    }
                    ListaAcumulada.Clear();
                    ListaAcumulada.AddRange(ListaAuxiliar);
                    ListaAuxiliar.Clear();
                }
            }

            foreach (String x in ListaAcumulada)
            {
                if (indicador == 0)
                {
                    respuestaPotencia = x;
                    indicador++;
                }
                else
                    respuestaPotencia = respuestaPotencia + ", " + x;
            }
            respuesta.Text = respuestaPotencia;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregarB_Click(object sender, EventArgs e)
        {
            string prueba = entradaB.Text.ToString();
            verificarAlfa(prueba);
            if (indicadorAlfa > 0)
            {
                if (indicador2 == 0)
                {
                    lenguajeB.Text = entradaB.Text.ToString();
                    indicador2++;
                }
                else
                    lenguajeB.Text = lenguajeB.Text.ToString() + ", " + entradaB.Text.ToString();
                Lista2.Add(entradaB.Text.ToString());
                entradaB.Clear();
                indicadorAlfa = 0;
                error.Clear();
            }
            else
            {
                error.SetError(agregarB, "Valor no econtrado en alfabeto");

            }
        }

        int indicadorAlfa = 0;

        public void verificarAlfa(string prueba)
        {
            foreach (string x in ListaAlfa)
            {
                if (x == prueba)
                {
                    indicadorAlfa++;
                }
            }
        }

        private void borrarAlfa_Click(object sender, EventArgs e)
        {
            ListaAlfa.Clear();
            alfabeto.Clear();

            Lista1.Clear();
            lenguajeA.Clear();

            Lista2.Clear();
            lenguajeB.Clear();
            indicador = 0;
            indicador2 = 0;
            indicador3 = 0;
        }

        private void borrarA_Click(object sender, EventArgs e)
        {
            indicador = 0;
            Lista1.Clear();
            lenguajeA.Clear();
        }

        private void agregarAlfa_Click_1(object sender, EventArgs e)
        {
            if (indicador3 == 0)
            {
                alfabeto.Text = entradaAlfa.Text.ToString();
                indicador3++;
            }
            else
                alfabeto.Text = alfabeto.Text.ToString() + ", " + entradaAlfa.Text.ToString();
            ListaAlfa.Add(entradaAlfa.Text.ToString());
            entradaAlfa.Clear();
        }

        private void agregarA_Click_1(object sender, EventArgs e)
        {
            string prueba = entradaA.Text.ToString();
            verificarAlfa(prueba);

            if (indicadorAlfa > 0)
            {
                if (indicador == 0)
                {
                    lenguajeA.Text = entradaA.Text.ToString();
                    indicador++;
                }
                else
                    lenguajeA.Text = lenguajeA.Text.ToString() + ", " + entradaA.Text.ToString();
                Lista1.Add(entradaA.Text.ToString());
                entradaA.Clear();
                indicadorAlfa = 0;
                error.Clear();
            }
            else
            {
                error.SetError(agregarA, "Valor no econtrado en alfabeto");

            }
        }

        private void borrarB_Click(object sender, EventArgs e)
        {
            indicador2 = 0;
            Lista2.Clear();
            lenguajeB.Clear();
        }

        private void interseccion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CerraduraP_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void CerraduraKleene()
        {
            List<String> ListaAux = new List<String>();
            List<String> ListaAux2 = new List<String>();
            respuesta.Text = "E";
            foreach (String x in Lista1)
            {
                respuesta.Text = respuesta.Text.ToString() + ", " + x;
            }

            ListaAux.AddRange(Lista1);

            for (int i=0; i<3; i++)
            {
                foreach(String x in Lista1)
                {
                    foreach (String y in ListaAux)
                    {
                        ListaAux2.Add(x + y);
                    }
                }

                foreach (String x in ListaAux2)
                {
                    respuesta.Text = respuesta.Text.ToString() + ", " + x;
                }

                ListaAux.Clear();
                ListaAux.AddRange(ListaAux2);
                ListaAux2.Clear();
            }

            respuesta.Text = respuesta.Text.ToString() + ", ...infinito";
        }

        public void CerraduraPositiva()
        {
            List<String> ListaAux = new List<String>();
            List<String> ListaAux2 = new List<String>();

            respuesta.Text = "";

            ListaAux.AddRange(Lista1);

            for (int i = 0; i < 3; i++)
            {
                foreach (String x in Lista1)
                {
                    foreach (String y in ListaAux)
                    {
                        ListaAux2.Add(x + y);
                    }
                }

                foreach (String x in ListaAux2)
                {
                    respuesta.Text = respuesta.Text.ToString() + x + ", ";
                }

                ListaAux.Clear();
                ListaAux.AddRange(ListaAux2);
                ListaAux2.Clear();
            }

            respuesta.Text = respuesta.Text.ToString() + "...infinito";
        }
    }
}
