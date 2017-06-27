using GPLayoutsESocial.ver2_2_02.S1000;
using Retorno;
using Serv;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicoEnviarLoteEventosClient client = new ServicoEnviarLoteEventosClient("WsEnviarLoteEventos");

            //servico.ServicoEnviarLoteEventosClient client = new servico.ServicoEnviarLoteEventosClient();

            //Cria um S1000 de teste
            S1000 s1000 = Eventos.S1000(1);
            string strS1000 = XMLHelper.Serialize<S1000>(s1000);
            XmlDocument xmlElemS1000 = new XmlDocument();
            xmlElemS1000.LoadXml(strS1000);


            //Cria o lote
            Envio.eSocial lote = new Envio.eSocial();
            lote.envioLoteEventos.ideEmpregador.nrInsc = "85106748000126"; // Mesmo CNPJ do certificado (olhe no services.msc)
            lote.envioLoteEventos.ideEmpregador.tpInsc = 1;

            lote.envioLoteEventos.ideTransmissor.tpInsc = 1;
            lote.envioLoteEventos.ideTransmissor.nrInsc = "85106748000126"; // Mesmo CNPJ do certificado (olhe no services.msc)
            lote.envioLoteEventos.grupo = 1;
            Envio.TArquivoEsocial evento = new Envio.TArquivoEsocial();
            evento.Id = "ID1851067480001262017062714401100001";
            lote.envioLoteEventos.eventos.evento = new Envio.TArquivoEsocial[1];
            lote.envioLoteEventos.eventos.evento[0] = evento;
            evento.Any = xmlElemS1000.DocumentElement;

            string strLote = XMLHelper.Serialize<Envio.eSocial>(lote);
            XmlDocument xmlElemLote = new XmlDocument();
            xmlElemLote.LoadXml(strLote);

            try
            {
                // Percorre todos os certificados instalados na maquina.
                // X509Store Store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
                // Store.Open(OpenFlags.ReadOnly);
                // X509Certificate2Collection CertColl = Store.Certificates;//.Find(X509FindType.FindByIssuerName, "Microsoft", true);
                // foreach (X509Certificate2 Cert in CertColl)
                //    Console.WriteLine("Cert: " + Cert.IssuerName.Name);

                // Set the certificate for the client.
                client.ClientCredentials.ClientCertificate.SetCertificate(
                    StoreLocation.LocalMachine,
                    StoreName.My,
                    X509FindType.FindBySerialNumber,
                    "220F1606274100BA"); // nome amigavel

                string strRequisicao = XMLHelper.Serialize(xmlElemLote);


                XmlElement xmlRetorno = client.EnviarLoteEventos(xmlElemLote.DocumentElement);

                var ret = XMLHelper.Deserialize<Retorno.eSocial>(xmlRetorno.OuterXml);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            client.Close();
        }
    }
}
