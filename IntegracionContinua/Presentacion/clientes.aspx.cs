using Newtonsoft.Json;
using Presentacion.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvClientes.DataSource = ConsultarClientes();
            gvClientes.DataBind();
        }

        private List<Cliente> ConsultarClientes()
        {
            var url = $"https://localhost:44394/api/Clientes";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader != null)
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                clientes = JsonConvert.DeserializeObject<List<Cliente>>(responseBody);
                            }
                        }
                    }
                }

                return clientes;
            }
            catch (WebException ex)
            {
                // Handle error
                return clientes;
            }
        }

        protected void gvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}