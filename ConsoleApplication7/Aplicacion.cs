using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Aplicacion
    {
        ///atributo
        IOS sistema;
        List<IGUIObject> listaGUI;
        ///METODO
        public Aplicacion(IOS sistema)
        {
            this.sistema = sistema;
            listaGUI = new List<IGUIObject>();
        }
        public void CreateUI()
        {
            Label titulo = sistema.CreateLabel("are you sure");
            Label mensaje = sistema.CreateLabel("once dely, you");
            Icon iconoAlerta = sistema.CreateIcon("alerta");
            Button buttonOK = sistema.CreateButton("ok");
            Button buttonCancelar = sistema.CreateButton("cancelar");


            listaGUI.Add(titulo);
            listaGUI.Add(mensaje);
            listaGUI.Add(iconoAlerta);
            listaGUI.Add(buttonOK);
            listaGUI.Add(buttonCancelar);
        }
        public void paint()
        {
            string screen;
            foreach (objeto in listaGUI)
            {
                screen += object.Paint() + "/n";
            }
            console.W
        }
    }
