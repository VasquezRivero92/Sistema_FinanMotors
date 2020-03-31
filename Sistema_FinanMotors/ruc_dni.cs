using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FinanMotors
{
    class ruc_dni
    {
        public static string dni_, nombres_dni, apellidoPaterno_dni, apellidoMaterno_dni;
        public static string ruc_, razonSocial_, direccion_ruc, departamento_ruc, provincia_ruc, distrito_ruc;
        public class jsondni
        {
            public string dni { get; set; }
            public string nombres { get; set; }
            public string apellidoPaterno { get; set; }
            public string apellidoMaterno { get; set; }
        }
        public class jsonruc
        {
            public string ruc { get; set; }
            public string razonSocial { get; set; }
            public string direccion { get; set; }
            public string departamento { get; set; }
            public string provincia { get; set; }
            public string distrito { get; set; }
        }
        public static void leerdni(string dni)
        {
            {
                Console.WriteLine("Haciendo una petición al servio de clientes....");

                //se define la url del método de la api.
                string url = "https://dniruc.apisperu.com/api/v1/dni/" + dni + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Impvc2VfMjUwMTkyQGhvdG1haWwuY29tIn0.xzvbVpQKfiG9dNvuXbS15SA-j9w2Dw8zbpE7VKM8QIo";

                //Se configura la petición.
                HttpWebRequest peticion;
                peticion = WebRequest.Create(url) as HttpWebRequest;
                peticion.ContentType = "application/json; charset=utf-8";
                peticion.Method = "GET";

                // Respuesta
                try
                {
                    HttpWebResponse respuesta = peticion.GetResponse() as HttpWebResponse;
                    //Si la peticion fue correcta
                    if ((int)respuesta.StatusCode == 200)
                    {
                        var reader = new StreamReader(respuesta.GetResponseStream());
                        string s = reader.ReadToEnd();
                        var arr = JsonConvert.DeserializeObject<jsondni>(s);
                        dni_ = arr.dni;
                        nombres_dni = arr.nombres;
                        apellidoPaterno_dni = arr.apellidoPaterno;
                        apellidoMaterno_dni = arr.apellidoMaterno;

                        Console.ReadLine();
                        FormProforma.boton.Visible = true;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        FormProforma.boton.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    FormProforma.boton.Visible = true;
                }

            }
        }
        public static void leerruc(string ruc)
        {
            {
                Console.WriteLine("Haciendo una petición al servio de clientes....");

                //se define la url del método de la api.
                string url = "https://dniruc.apisperu.com/api/v1/ruc/" + ruc + "?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6Impvc2VfMjUwMTkyQGhvdG1haWwuY29tIn0.xzvbVpQKfiG9dNvuXbS15SA-j9w2Dw8zbpE7VKM8QIo";

                //Se configura la petición.
                HttpWebRequest peticion;
                peticion = WebRequest.Create(url) as HttpWebRequest;
                peticion.ContentType = "application/json; charset=utf-8";
                peticion.Method = "GET";

                // Respuesta
                try
                {
                    HttpWebResponse respuesta = peticion.GetResponse() as HttpWebResponse;
                    //Si la peticion fue correcta
                    if ((int)respuesta.StatusCode == 200)
                    {
                        var reader = new StreamReader(respuesta.GetResponseStream());
                        string s = reader.ReadToEnd();
                        var arruc = JsonConvert.DeserializeObject<jsonruc>(s);
                        ruc_ = arruc.ruc;
                        razonSocial_ = arruc.razonSocial;
                        direccion_ruc = arruc.direccion;
                        departamento_ruc = arruc.departamento;
                        provincia_ruc = arruc.provincia;
                        distrito_ruc = arruc.distrito;

                        Console.ReadLine();
                        FormProforma.boton.Visible = true;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        FormProforma.boton.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    FormProforma.boton.Visible = true;
                }

            }
        }


    }
}
