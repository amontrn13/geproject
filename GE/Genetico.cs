using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GE
{
    class Genetico
    {
        public static Genetico instancia = null;
        private ArrayList ordenes;
        private ArrayList agentes;
        private int n = 80;

        private Genetico() {
            ordenes = new ArrayList();
        }

        private void IniciarListas()
        {
            //TODO: obtener ordenes y agentes agregarlos a lista.
        }

        public static Genetico GetInstancia()
        {
            if (instancia == null)
                instancia = new Genetico();

            return instancia;
        }
        public void RepartirOrdenes()
        {
            Console.WriteLine("Funcionando :)");
        } 
        /*
        -Se genera la población inicial, tomando como base
         los agentes iniciales y las ordenes existentes.
        -Para posteriormente generar soluciones.
        -Cantidad recomendada: 500 individuos.
        */
        private ArrayList CrearGeneracion(ArrayList poblacion, int cantIndividuos)
        {
            ArrayList primera_generacion = new ArrayList();
            for(int i = 0; i < cantIndividuos; i++)
            {
                primera_generacion.Add(CrearIndividuos(poblacion));
            }
            return primera_generacion;
        }

        private List<ArrayList> CrearIndividuos(ArrayList poblacion)
        {
            List<ArrayList> individuos = new List<ArrayList>();
            ArrayList agentesDisponibles = new ArrayList();
            Random rand = new Random();
            foreach (Agente element in agentes)
            {
                individuos.Add(new ArrayList());
            }
            foreach (Orden ord in poblacion)
            {
                agentesDisponibles = AgentesPorTipo(ord);
                int indice = rand.Next(0, agentesDisponibles.Count - 1);
                int posDisponibleAleatoria = (int)agentesDisponibles[indice];
                individuos[posDisponibleAleatoria].Add(ord);
            }

            return individuos;
        }

        /*
         Devuelve una lista con los indices o posiciones de los agentes disponibles
         según el tipo de código.
        */
        private ArrayList AgentesPorTipo(Orden ord)
        {
            ArrayList numAgentes = new ArrayList();
            for(int i = 0; i < ordenes.Count; i++)
            {
                if (agentes.Contains(ord.Codigo_Servicios))
                {
                    numAgentes.Add(i);
                }
            }
            return numAgentes;
        }
    }
}



