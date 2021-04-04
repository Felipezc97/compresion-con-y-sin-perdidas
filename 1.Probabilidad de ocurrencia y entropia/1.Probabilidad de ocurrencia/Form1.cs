using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1.Probabilidad_de_ocurrencia
{
    public partial class Form1 : Form
    {
        string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + //Alfabeto Mayúsculas
                          "abcdefghijklmnopqrstuvwxyz" + //Alfabeto Minusculas
                          " !¡¿?#@$%&\\|_~+-*/^'`,.:;=<>[](){}\"" + //Signos de Puntuacion y caracters imprimibles
                          "☺☻♥♦♣♠•◘○◙♂♀♪♫☼►◄↕‼▬↨↑↓→←∟↔▲▼" + // Caracteres especiasles no imprimibles
                          "ÇüéâäàåçêëèïîìÄÅÉæÆôöòûùÿÖÜø£Ø×ƒáíóúñÑªº®¬½¼«»░▒▓│┤ÁÂÀ©╣║╗╝¢¥┐└┴┬├─┼ãÃ╚╔╩╦╠═╬¤ðÐÊËÈıÍÎÏ⌂┌█▄¦Ì▀ÓßÔÒõÕµþÞÚÛÙýÝ¯´­±‗¾¶§÷¸°¨·¹³²■";
        List<Simbolo> lstSimbolos = new List<Simbolo>();
        List<SimboloProb> lstSimbolosProb = new List<SimboloProb>();
        double total;
        int totalsimbolos;
        double entropia;

        public Form1()
        {
            InitializeComponent();
        }

        //Limpieza de parámetros
        public void Sanidad()
        {
            rtxTexto.Clear();
            lbxConcurrencia.Items.Clear();
            lbxProbabilidad.Items.Clear();
            lstSimbolos.Clear();
            lstSimbolosProb.Clear();
            lblEntropia.Text = "ENTROPÍA DE LA FUENTE\nH(S) = ";
            lblTotalAnalizados.Text = "Total de simbolos analizados: ";
            lblTotalSimb.Text = "Cantidad de simbolos: ";
            total = 0;
            totalsimbolos = 0;
            entropia = 0;
            
        }

        //Evento click sobre el botón
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            Sanidad();
            //Se invoca a la funcion AbrirArchivo
            string contenidoArchivo = AbrirArchivo();

            //ver todos los simbolos y la concurrencia;
            foreach (var caracter in alfabeto)
            {

                int res = 0;

                foreach (var iter in contenidoArchivo)
                {
                    if (iter == caracter)
                    {
                        res++;
                    }
                }
                if (res != 0)
                {
                    //Se añaden los simbolos leídos a una lista y al listbox
                    Simbolo simbolo = new Simbolo(caracter, res);
                    lstSimbolos.Add(simbolo);
                    lbxConcurrencia.Items.Add(simbolo);
                    total = total + simbolo.Concurencia;
                    totalsimbolos++;
                }

            }

            //la concurecia de todos los simbolos y prob
            foreach (var iter in lstSimbolos)
            {
                //Creacion de objetos con la probalididad de simbolo
                SimboloProb simboloProb = new SimboloProb(iter.Caracter, Convert.ToDouble(iter.Concurencia) / total);
                //Se añaden los simbolos al listbox y a la lista de simbolos con probabilidad
                lstSimbolosProb.Add(simboloProb);
                lbxProbabilidad.Items.Add(simboloProb);
            }

            //Se invoca al método Enropia
            Entropia(lstSimbolosProb);

            //Se añade el texto del documento al cuadro de texto
            rtxTexto.Text = contenidoArchivo;
            //Los resultados se los dimbolos contados se muestran en la interfaz
            lblTotalSimb.Text = lblTotalSimb.Text + totalsimbolos;
            lblTotalAnalizados.Text = lblTotalAnalizados.Text + total;
        }

        //Calculo de la entrópía de la fuente
        private void Entropia(List<SimboloProb> lstSimbolosProb)
        {
            foreach (var iter in lstSimbolosProb)
            {
                entropia = entropia + (iter.Probabilidad) * Math.Log((1 / iter.Probabilidad), 2);
            }
            //El resultado se muestra en la interfaz
            lblEntropia.Text = lblEntropia.Text + entropia + " bits/simbolo";
        }

        private string AbrirArchivo()
        {
            //se crean variables locales para tener el path y el contenido del archivo
            var contenidoArchivo = string.Empty;
            var pathArchivo = string.Empty;

            //uso local de referencia
            using (OpenFileDialog abrirArchivo = new OpenFileDialog())
            {
                //Ruta por defecto disco local C
                abrirArchivo.InitialDirectory = "C:\\";
                //Solo se muestran archivos txt
                abrirArchivo.Filter = "txt files (*.txt)|*.txt";
                abrirArchivo.FilterIndex = 2;
                abrirArchivo.RestoreDirectory = true;

                //Se eligen los archivos y estos son leidos
                if (abrirArchivo.ShowDialog() == DialogResult.OK)
                {
                    pathArchivo = abrirArchivo.FileName;
                    var flujoArchivo = abrirArchivo.OpenFile();

                    using (StreamReader reader = new StreamReader(flujoArchivo))
                    {
                        //El contenido leido es transformado en un cadena de caracteres
                        contenidoArchivo = reader.ReadToEnd();
                    }
                }
            }
            return contenidoArchivo;
        }

        private void lblEntropia_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbxProbabilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
