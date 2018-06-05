using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace GE
{
    class Genetico
    {
        public static Genetico instancia = null;
        private List<Orden> ordenes;
        private List<Agente> agentes;

        private Genetico() {
            this.ordenes = new List<Orden>();
            this.agentes = new List<Agente>();
            IniciarListas();
        }

        private void IniciarListas()
        {
            Console.WriteLine("IniciarListas");
            XML xmlArchivoAgente = XML.GetInstance();
            XMLOrden xmlArchivoOrden = XMLOrden.GetInstance();
            for (int i = 0; i < xmlArchivoAgente.ObtenerAgentes().Count; i++)
            {
                this.agentes.Add((Agente)xmlArchivoAgente.ObtenerAgentes()[i]);
            }
            for (int i = 0; i < xmlArchivoOrden.ObtenerOrden().Count; i++)
            {
                this.ordenes.Add((Orden)xmlArchivoOrden.ObtenerOrden()[i]);
            }
            Console.WriteLine("Len agentes " + agentes.Count);
            Console.WriteLine("Len ordenes " + ordenes.Count);
        }

        public static Genetico GetInstancia()
        {
            if (instancia == null)
                instancia = new Genetico();

            return instancia;
        }

        private int EquilibrioIndividuo(ArrayList individuo) {
            int min = 9999;
            int max = 0;
            int numOrdenesAgente = 0;
            foreach (Agente agente in individuo)
            {
                numOrdenesAgente = agente.Ordenes.Count;
                if (numOrdenesAgente > max)
                {
                    max = numOrdenesAgente;
                }
                if (numOrdenesAgente < min)
                {
                    min = numOrdenesAgente;
                }
            }
            return (max - min);
        }

        private void CalcularFitness(List<ArrayList> generacion)
        {
            foreach (ArrayList individuo in generacion)
            {
                individuo.Add(EquilibrioIndividuo(individuo));
            }
        }

        private void PopFitness(List<ArrayList> generacion)
        {
            foreach (ArrayList individuo in generacion)
            {
                individuo.RemoveAt(individuo.Count - 1);
            }
        }

        private void DistribuirOrdenes(ArrayList individuo)
        {
            for (int i = 0; i < agentes.Count; i++)
            {
                Agente agnt = (Agente)individuo[i];
                //agentes[i].Ordenes.Insert(0,agnt.Ordenes);
                foreach (Orden ord in agnt.Ordenes)
                {
                    agentes[i].Ordenes.Insert(0, ord);
                }
            }
        }

        public void RepartirOrdenes()
        {
            List<ArrayList> generacion = new List<ArrayList>();
            int iteraciones = 0;
            int maxIteraciones = 10;

            while (iteraciones < maxIteraciones)
            {
                //Cantidad de individuos;
                generacion = CrearGeneracion(ordenes, 50);
                CalcularFitness(generacion);
                PopFitness(generacion);
                generacion = generacion.GetRange(0,10);
                iteraciones++;
            }
            CalcularFitness(generacion);
            DistribuirOrdenes(generacion[0]);
            Console.WriteLine("Fin de la ejecución");
            MessageBox.Show("Órdenes Asignadas Exitosamente", "Completado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            foreach (Agente agente in agentes)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine(agente.ID);
                Console.WriteLine(agente.Nombre);
                foreach (Orden orden in agente.Ordenes)
                {
                    Console.WriteLine("\nÓrdenes del agente");
                    Console.WriteLine(orden.Cliente);
                    Console.WriteLine(orden.Codigo_Servicios);
                }
                Console.WriteLine("\n");
            }
        } 
        /*
        -Se genera la población inicial, tomando como base
         los agentes iniciales y las ordenes existentes.
        -Para posteriormente generar soluciones.
        -Cantidad recomendada: 500 individuos.
        */
        private List<ArrayList> CrearGeneracion(List<Orden> poblacion, int cantIndividuos)
        {
            List<ArrayList> primera_generacion = new List<ArrayList>();
            for(int i = 0; i < cantIndividuos; i++)
            {
                primera_generacion.Add(CrearIndividuos(poblacion));
            }
            return primera_generacion;
        }

        private ArrayList CrearIndividuos(List<Orden> poblacion)
        {
            ArrayList individuo = new ArrayList();
            ArrayList agentesDisponibles = new ArrayList();
            Random rand = new Random();
            foreach (Agente element in agentes)
            {
                //individuo.Add(new ArrayList());
                //individuo.Add(null);
                individuo.Add(new Agente());
            }
            foreach (Orden ord in poblacion)
            {
                agentesDisponibles = AgentesPorTipo(ord);
                int indice = rand.Next(0, agentesDisponibles.Count - 1);
                int posDisponibleAleatoria = (int)agentesDisponibles[indice];
                //CAST DE OBJECT A AGENTE.
                Agente agente = (Agente)individuo[posDisponibleAleatoria];
                agente.Ordenes.Add(ord);
            }

            return individuo;
        }

        /*
         Devuelve una lista con los indices o posiciones de los agentes disponibles
         según el tipo de código.
        */
        private ArrayList AgentesPorTipo(Orden ord)
        {
            //Console.WriteLine("AgentesPorTipo");
            ArrayList numAgentes = new ArrayList();
            for(int i = 0; i < agentes.Count; i++)
            {
                //Console.WriteLine("For " + i);
                if (agentes[i].Codigo_Servicios.Contains(ord.Codigo_Servicios))
                {

                    numAgentes.Add(i);
                }
            }
            return numAgentes;
        }
    }
}



