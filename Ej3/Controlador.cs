using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Controlador
    {
        List<Cliente> lCliente = new List<Cliente>();
        List<Cuentas> lCuentas = new List<Cuentas>();
                
        public void AgregarCliente(TipoDocumento pTipoDocumento, String pNroDocumento, String pNombre)
        {
            Cliente iCliente = new Cliente(pTipoDocumento, pNroDocumento, pNombre);
            lCliente.Add(iCliente);
            this.AgregarCuentas(iCliente);
        }

        public void AgregarCuentas(Cliente pCliente)
        {
            Cuentas iCuentas = new Cuentas(pCliente);
            lCuentas.Add(iCuentas);
        }

        public Boolean ExisteCliente(String pNroDoc)
        {
            return lCliente.Exists(item => item.NroDocumento == pNroDoc);
        }

        public Cliente BuscarClientePorDoc(String pNroDoc)
        {
            return lCliente.Find(item => item.NroDocumento == pNroDoc);
        }

        public Cuentas BuscarCuentasPorDoc(String pNumDoc)
        {
            Cliente cli = this.BuscarClientePorDoc(pNumDoc);
            Cuentas cue = lCuentas.Find(item => item.Cliente == cli);
            return cue;
        }
    }
}
