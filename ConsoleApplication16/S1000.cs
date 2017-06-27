using GPLayoutsESocial.ver2_2_02.S1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    public static class Eventos
    {
        public static S1000 S1000(int acao)
        {
            S1000 s1000 = new S1000();
            s1000.evtInfoEmpregador.Id = "ID1851067480001262017062714401100001";
            s1000.evtInfoEmpregador.ideEmpregador.nrInsc = "85106748000126";
            s1000.evtInfoEmpregador.ideEmpregador.tpInsc = 1;

            s1000.evtInfoEmpregador.ideEvento.procEmi = 1;
            s1000.evtInfoEmpregador.ideEvento.tpAmb = 3;// produção restirta
            s1000.evtInfoEmpregador.ideEvento.verProc = "1";

            switch (acao)
            {
                case 1:
                    #region "inclusao"
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.idePeriodo.iniValid = "2018-01";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.idePeriodo.fimValid = "2019-01";

                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.classTrib = "00";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.contato.cpfCtt = "99999999999";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.contato.email = "email@email.com";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.contato.foneCel = "99991122";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.contato.foneFixo = "33331122";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.contato.nmCtt = "nmCtt";

                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.dadosIsencao.dtDou = DateTime.Today;
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.dadosIsencao.dtEmisCertif = DateTime.Today;
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.dadosIsencao.dtProtRenov = DateTime.Today;
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.dadosIsencao.dtVencCertif = DateTime.Today;
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.dadosIsencao.ideMinLei = "ideMinLei";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.dadosIsencao.nrCertif = "nrCertif";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.dadosIsencao.nrProtRenov = "nrProtRenov";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.dadosIsencao.pagDou = "1";

                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.indConstr = 1;
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.indCoop = 1;
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.indDesFolha = 1;
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.indEntEd = "S";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.indEtt = "S";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.indOptRegEletron = 1;

                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.infoComplementares.situacaoPF.indSitPF = 1;
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.infoComplementares.situacaoPJ.indSitPJ = 1;

                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.infoOP.infoEFR.cnpjEFR = "34267512000130";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.infoOP.infoEFR.ideEFR = "S";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.infoOP.infoEnte.codMunic = "1000";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.infoOP.infoEnte.indRPPS = "S";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.infoOP.infoEnte.nmEnte = "nmEnte";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.infoOP.infoEnte.subteto = 1;
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.infoOP.infoEnte.uf = "SC";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.infoOP.infoEnte.vrSubteto = 10.2M;
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.infoOP.nrSiafi = "12345";

                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.infoOrgInternacional.indAcordoIsenMulta = 1;
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.multTabRubricas = "S";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.natJurid = "1234";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.nmRazao = "nmRazao";
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.nrRegEtt = "1000";

                    TInfoEmpregadorSoftwareHouse sh1 = new TInfoEmpregadorSoftwareHouse();
                    sh1.cnpjSoftHouse = "34267512000130";
                    sh1.email = "email@email.com";
                    sh1.nmCont = "nmCont";
                    sh1.nmRazao = "nmRazao";
                    sh1.telefone = "33331122";

                    TInfoEmpregadorSoftwareHouse sh2 = new TInfoEmpregadorSoftwareHouse();
                    sh2.cnpjSoftHouse = "34267512000130";
                    sh2.email = "email@email.com";
                    sh2.nmCont = "nmCont2";
                    sh2.nmRazao = "nmRazao2";
                    sh2.telefone = "33331122";

                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.softwareHouse.Add(sh1);
                    s1000.evtInfoEmpregador.infoEmpregador.inclusao.infoCadastro.softwareHouse.Add(sh2);
                    #endregion
                    break;
                case 2:
                    #region "alteracao"
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.idePeriodo.iniValid = "2018-01";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.idePeriodo.fimValid = "2019-01";

                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.classTrib = "00";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.contato.cpfCtt = "99999999999";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.contato.email = "email@email.com";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.contato.foneCel = "99991122";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.contato.foneFixo = "33331122";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.contato.nmCtt = "nmCtt";

                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.dadosIsencao.dtDou = DateTime.Today;
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.dadosIsencao.dtEmisCertif = DateTime.Today;
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.dadosIsencao.dtProtRenov = DateTime.Today;
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.dadosIsencao.dtVencCertif = DateTime.Today;
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.dadosIsencao.ideMinLei = "ideMinLei";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.dadosIsencao.nrCertif = "nrCertif";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.dadosIsencao.nrProtRenov = "nrProtRenov";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.dadosIsencao.pagDou = "1";

                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.indConstr = 1;
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.indCoop = 1;
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.indDesFolha = 1;
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.indEntEd = "S";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.indEtt = "S";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.indOptRegEletron = 1;

                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.infoComplementares.situacaoPF.indSitPF = 1;
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.infoComplementares.situacaoPJ.indSitPJ = 1;

                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.infoOP.infoEFR.cnpjEFR = "34267512000130";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.infoOP.infoEFR.ideEFR = "S";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.infoOP.infoEnte.codMunic = "1000";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.infoOP.infoEnte.indRPPS = "S";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.infoOP.infoEnte.nmEnte = "nmEnte";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.infoOP.infoEnte.subteto = 1;
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.infoOP.infoEnte.uf = "SC";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.infoOP.infoEnte.vrSubteto = 10.2M;
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.infoOP.nrSiafi = "12345";

                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.infoOrgInternacional.indAcordoIsenMulta = 1;
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.multTabRubricas = "S";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.natJurid = "1234";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.nmRazao = "nmRazao";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.infoCadastro.nrRegEtt = "1000";

                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.novaValidade.iniValid = "2018-01";
                    s1000.evtInfoEmpregador.infoEmpregador.alteracao.novaValidade.fimValid = "2018-02";
                    #endregion
                    break;
                case 3:
                    #region "exclusao"
                    s1000.evtInfoEmpregador.infoEmpregador.exclusao.idePeriodo.iniValid = "2018-01";
                    s1000.evtInfoEmpregador.infoEmpregador.exclusao.idePeriodo.iniValid = "2018-02";
                    #endregion
                    break;
                default:
                    break;
            }

            return s1000;
        }
    }
}
